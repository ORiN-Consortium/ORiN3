namespace Design.ORiN3.Common.V1;

/// <summary>
/// Class used to branch the process for each object type in ORiN3.
/// </summary>
public interface IObjectTypeBranch
{
    /// <summary>
    /// For provider root
    /// </summary>
    void CaseOfProviderRoot();

    /// <summary>
    /// For controller
    /// </summary>
    void CaseOfController();

    /// <summary>
    /// For module
    /// </summary>
    void CaseOfModule();

    /// <summary>
    /// For variable
    /// </summary>
    void CaseOfVariable();

    /// <summary>
    /// For file
    /// </summary>
    void CaseOfFile();

    /// <summary>
    /// For stream
    /// </summary>
    void CaseOfStream();

    /// <summary>
    /// For event
    /// </summary>
    void CaseOfEvent();

    /// <summary>
    /// For task
    /// </summary>
    void CaseOfJob();

    /// <summary>
    /// For error
    /// </summary>
    void CaseOfError();
}
