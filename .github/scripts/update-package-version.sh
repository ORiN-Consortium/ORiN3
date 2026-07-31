#!/usr/bin/env bash

set -euo pipefail

version_file="${1:?version file is required}"
increment="${2:?increment is required}"

current_version=$(sed -n 's|.*<NugetPackageVersion>\(.*\)</NugetPackageVersion>.*|\1|p' "${version_file}")
if [[ -z "${current_version}" ]]; then
  echo "NugetPackageVersion was not found in ${version_file}." >&2
  exit 1
fi

version_core="${current_version%%-*}"
prerelease=""
if [[ "${current_version}" == *-* ]]; then
  prerelease="${current_version#*-}"
fi

IFS='.' read -r major minor patch <<< "${version_core}"
if [[ ! "${major}" =~ ^[0-9]+$ || ! "${minor}" =~ ^[0-9]+$ || ! "${patch}" =~ ^[0-9]+$ ]]; then
  echo "Unsupported NuGet version: ${current_version}" >&2
  exit 1
fi

case "${increment}" in
  patch)
    if [[ "${prerelease}" == beta.* ]]; then
      target_version="${major}.${minor}.${patch}"
    else
      target_version="${major}.${minor}.$((patch + 1))"
    fi
    ;;
  minor)
    target_version="${major}.$((minor + 1)).0"
    ;;
  major)
    target_version="$((major + 1)).0.0"
    ;;
  'pre(beta)')
    if [[ "${prerelease}" == beta.* ]]; then
      beta_number="${prerelease#beta.}"
      if [[ ! "${beta_number}" =~ ^[0-9]+$ ]]; then
        echo "Unsupported beta version: ${current_version}" >&2
        exit 1
      fi
      target_version="${major}.${minor}.${patch}-beta.$((beta_number + 1))"
    elif [[ -n "${prerelease}" ]]; then
      echo "Only beta prerelease versions are supported: ${current_version}" >&2
      exit 1
    else
      target_version="${major}.${minor}.$((patch + 1))-beta.1"
    fi
    ;;
  *)
    echo "Unsupported increment: ${increment}" >&2
    exit 1
    ;;
esac

target_core="${target_version%%-*}"
target_project_version="${target_core}.0"

sed -i "s|<ProjectVersion>.*</ProjectVersion>|<ProjectVersion>${target_project_version}</ProjectVersion>|" "${version_file}"
sed -i "s|<NugetPackageVersion>.*</NugetPackageVersion>|<NugetPackageVersion>${target_version}</NugetPackageVersion>|" "${version_file}"

if [[ -n "${GITHUB_OUTPUT:-}" ]]; then
  echo "target_project_version=${target_project_version}" >> "${GITHUB_OUTPUT}"
  echo "target_nuget_version=${target_version}" >> "${GITHUB_OUTPUT}"
fi

echo "${current_version} -> ${target_version}"
