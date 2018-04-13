
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class mxGraphModel
{

    private mxGraphModelRoot rootField;

    private ushort dxField;

    private ushort dyField;

    private byte gridField;

    private byte gridSizeField;

    private byte guidesField;

    private byte tooltipsField;

    private byte connectField;

    private byte arrowsField;

    private byte foldField;

    private byte pageField;

    private byte pageScaleField;

    private ushort pageWidthField;

    private ushort pageHeightField;

    private string backgroundField;

    private byte mathField;

    private byte shadowField;

    /// <remarks/>
    public mxGraphModelRoot root
    {
        get
        {
            return this.rootField;
        }
        set
        {
            this.rootField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort dx
    {
        get
        {
            return this.dxField;
        }
        set
        {
            this.dxField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort dy
    {
        get
        {
            return this.dyField;
        }
        set
        {
            this.dyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte grid
    {
        get
        {
            return this.gridField;
        }
        set
        {
            this.gridField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte gridSize
    {
        get
        {
            return this.gridSizeField;
        }
        set
        {
            this.gridSizeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte guides
    {
        get
        {
            return this.guidesField;
        }
        set
        {
            this.guidesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte tooltips
    {
        get
        {
            return this.tooltipsField;
        }
        set
        {
            this.tooltipsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte connect
    {
        get
        {
            return this.connectField;
        }
        set
        {
            this.connectField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte arrows
    {
        get
        {
            return this.arrowsField;
        }
        set
        {
            this.arrowsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte fold
    {
        get
        {
            return this.foldField;
        }
        set
        {
            this.foldField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte page
    {
        get
        {
            return this.pageField;
        }
        set
        {
            this.pageField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte pageScale
    {
        get
        {
            return this.pageScaleField;
        }
        set
        {
            this.pageScaleField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort pageWidth
    {
        get
        {
            return this.pageWidthField;
        }
        set
        {
            this.pageWidthField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort pageHeight
    {
        get
        {
            return this.pageHeightField;
        }
        set
        {
            this.pageHeightField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string background
    {
        get
        {
            return this.backgroundField;
        }
        set
        {
            this.backgroundField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte math
    {
        get
        {
            return this.mathField;
        }
        set
        {
            this.mathField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte shadow
    {
        get
        {
            return this.shadowField;
        }
        set
        {
            this.shadowField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class mxGraphModelRoot
{

    private object[] itemsField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("mxCell", typeof(mxGraphModelRootMxCell))]
    [System.Xml.Serialization.XmlElementAttribute("object", typeof(mxGraphModelRootObject))]
    public object[] Items
    {
        get
        {
            return this.itemsField;
        }
        set
        {
            this.itemsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class mxGraphModelRootMxCell
{

    private mxGraphModelRootMxCellMxGeometry mxGeometryField;

    private byte idField;

    private byte parentField;

    private bool parentFieldSpecified;

    private string valueField;

    private string styleField;

    private byte vertexField;

    private bool vertexFieldSpecified;

    private byte connectableField;

    private bool connectableFieldSpecified;

    /// <remarks/>
    public mxGraphModelRootMxCellMxGeometry mxGeometry
    {
        get
        {
            return this.mxGeometryField;
        }
        set
        {
            this.mxGeometryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte parent
    {
        get
        {
            return this.parentField;
        }
        set
        {
            this.parentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool parentSpecified
    {
        get
        {
            return this.parentFieldSpecified;
        }
        set
        {
            this.parentFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string style
    {
        get
        {
            return this.styleField;
        }
        set
        {
            this.styleField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte vertex
    {
        get
        {
            return this.vertexField;
        }
        set
        {
            this.vertexField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool vertexSpecified
    {
        get
        {
            return this.vertexFieldSpecified;
        }
        set
        {
            this.vertexFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte connectable
    {
        get
        {
            return this.connectableField;
        }
        set
        {
            this.connectableField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool connectableSpecified
    {
        get
        {
            return this.connectableFieldSpecified;
        }
        set
        {
            this.connectableFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class mxGraphModelRootMxCellMxGeometry
{

    private ushort xField;

    private ushort yField;

    private bool yFieldSpecified;

    private byte widthField;

    private decimal heightField;

    private string asField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ySpecified
    {
        get
        {
            return this.yFieldSpecified;
        }
        set
        {
            this.yFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte width
    {
        get
        {
            return this.widthField;
        }
        set
        {
            this.widthField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal height
    {
        get
        {
            return this.heightField;
        }
        set
        {
            this.heightField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string @as
    {
        get
        {
            return this.asField;
        }
        set
        {
            this.asField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class mxGraphModelRootObject
{

    private mxGraphModelRootObjectMxCell mxCellField;

    private string labelField;

    private string cIDRField;

    private string regionField;

    private string nameField;

    private byte idField;

    /// <remarks/>
    public mxGraphModelRootObjectMxCell mxCell
    {
        get
        {
            return this.mxCellField;
        }
        set
        {
            this.mxCellField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string label
    {
        get
        {
            return this.labelField;
        }
        set
        {
            this.labelField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CIDR
    {
        get
        {
            return this.cIDRField;
        }
        set
        {
            this.cIDRField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Region
    {
        get
        {
            return this.regionField;
        }
        set
        {
            this.regionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class mxGraphModelRootObjectMxCell
{

    private mxGraphModelRootObjectMxCellMxGeometry mxGeometryField;

    private string styleField;

    private byte vertexField;

    private byte parentField;

    /// <remarks/>
    public mxGraphModelRootObjectMxCellMxGeometry mxGeometry
    {
        get
        {
            return this.mxGeometryField;
        }
        set
        {
            this.mxGeometryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string style
    {
        get
        {
            return this.styleField;
        }
        set
        {
            this.styleField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte vertex
    {
        get
        {
            return this.vertexField;
        }
        set
        {
            this.vertexField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte parent
    {
        get
        {
            return this.parentField;
        }
        set
        {
            this.parentField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class mxGraphModelRootObjectMxCellMxGeometry
{

    private decimal yField;

    private byte widthField;

    private decimal heightField;

    private string asField;

    private byte xField;

    private bool xFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte width
    {
        get
        {
            return this.widthField;
        }
        set
        {
            this.widthField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal height
    {
        get
        {
            return this.heightField;
        }
        set
        {
            this.heightField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string @as
    {
        get
        {
            return this.asField;
        }
        set
        {
            this.asField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool xSpecified
    {
        get
        {
            return this.xFieldSpecified;
        }
        set
        {
            this.xFieldSpecified = value;
        }
    }
}

