﻿using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

public class PortfolioFileData : FileAttachmentBase
{
    public PortfolioFileData(Session session) : base(session) { }
    protected Resume resume;
    [Persistent, Association("Resume-PortfolioFileData")]
    public Resume Resume
    {
        get { return resume; }
        set
        {
            SetPropertyValue(nameof(Resume), ref resume, value);
        }
    }
    public override void AfterConstruction()
    {
        base.AfterConstruction();
        documentType = DocumentType.Unknown;
    }
    private DocumentType documentType;
    public DocumentType DocumentType
    {
        get { return documentType; }
        set { SetPropertyValue(nameof(DocumentType), ref documentType, value); }
    }
}
public enum DocumentType
{
    SourceCode = 1, Tests = 2, Documentation = 3,
    Diagrams = 4, ScreenShots = 5, Unknown = 6
};