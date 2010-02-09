using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI;
using System.ComponentModel;
using System.Web.UI.Design.WebControls;
using System.Web.UI.Design;
using System.Web.UI.WebControls;

namespace SAMaster.Web.UI
{
    /// <summary>
    /// A designer class for a strongly typed repeater <c>MstLinksAcRepeater</c>
    /// </summary>
	public class MstLinksAcRepeaterDesigner : System.Web.UI.Design.ControlDesigner
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:MstLinksAcRepeaterDesigner"/> class.
        /// </summary>
		public MstLinksAcRepeaterDesigner()
		{
		}

        /// <summary>
        /// Initializes the control designer and loads the specified component.
        /// </summary>
        /// <param name="component">The control being designed.</param>
		public override void Initialize(IComponent component)
		{
			if (!(component is MstLinksAcRepeater))
			{ 
				throw new ArgumentException("Component is not a MstLinksAcRepeater."); 
			} 
			base.Initialize(component); 
			base.SetViewFlags(ViewFlags.TemplateEditing, true); 
		}


		/// <summary>
		/// Generate HTML for the designer
		/// </summary>
		/// <returns>a string of design time HTML</returns>
		public override string GetDesignTimeHtml()
		{

			// Get the instance this designer applies to
			//
			MstLinksAcRepeater z = (MstLinksAcRepeater)Component;
			z.DataBind();

			return base.GetDesignTimeHtml();

			//return z.RenderAtDesignTime();

			//	ControlCollection c = z.Controls;
			//Totem z = (Totem) Component;
			//Totem z = (Totem) Component;
			//return ("<div style='border: 1px gray dotted; background-color: lightgray'><b>TagStat :</b> zae |  qsdds</div>");

		}
	}

    /// <summary>
    /// A strongly typed repeater control for the <c cref="MstLinksAcRepeater"></c> Type.
    /// </summary>
	[Designer(typeof(MstLinksAcRepeaterDesigner))]
	[ParseChildren(true)]
	[ToolboxData("<{0}:MstLinksAcRepeater runat=\"server\"></{0}:MstLinksAcRepeater>")]
	public class MstLinksAcRepeater : CompositeDataBoundControl, System.Web.UI.INamingContainer
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:MstLinksAcRepeater"/> class.
        /// </summary>
		public MstLinksAcRepeater()
		{
		}

		/// <summary>
        /// Gets a <see cref="T:System.Web.UI.ControlCollection"></see> object that represents the child controls for a specified server control in the UI hierarchy.
        /// </summary>
        /// <value></value>
        /// <returns>The collection of child controls for the specified server control.</returns>
		public override ControlCollection Controls
		{
			get
			{
				this.EnsureChildControls();
				return base.Controls;
			}
		}

		private ITemplate m_headerTemplate;
		/// <summary>
        /// Gets or sets the header template.
        /// </summary>
        /// <value>The header template.</value>
		[Browsable(false)]
		[TemplateContainer(typeof(MstLinksAcItem))]
		[PersistenceMode(PersistenceMode.InnerDefaultProperty)]
		public ITemplate HeaderTemplate
		{
			get { return m_headerTemplate; }
			set { m_headerTemplate = value; }
		}

		private ITemplate m_itemTemplate;
		/// <summary>
        /// Gets or sets the item template.
        /// </summary>
        /// <value>The item template.</value>
		[Browsable(false)]
		[TemplateContainer(typeof(MstLinksAcItem))]
		[PersistenceMode(PersistenceMode.InnerDefaultProperty)]
		public ITemplate ItemTemplate
		{
			get { return m_itemTemplate; }
			set { m_itemTemplate = value; }
		}

		private ITemplate m_seperatorTemplate;
        /// <summary>
        /// Gets or sets the Seperator Template
        /// </summary>
        [Browsable(false)]
        [TemplateContainer(typeof(MstLinksAcItem))]
        [PersistenceMode(PersistenceMode.InnerDefaultProperty)]
        public ITemplate SeperatorTemplate
        {
            get { return m_seperatorTemplate; }
            set { m_seperatorTemplate = value; }
        }
			
		private ITemplate m_altenateItemTemplate;
        /// <summary>
        /// Gets or sets the alternating item template.
        /// </summary>
        /// <value>The alternating item template.</value>
		[Browsable(false)]
		[TemplateContainer(typeof(MstLinksAcItem))]
		[PersistenceMode(PersistenceMode.InnerDefaultProperty)]
		public ITemplate AlternatingItemTemplate
		{
			get { return m_altenateItemTemplate; }
			set { m_altenateItemTemplate = value; }
		}

		private ITemplate m_footerTemplate;
        /// <summary>
        /// Gets or sets the footer template.
        /// </summary>
        /// <value>The footer template.</value>
		[Browsable(false)]
		[TemplateContainer(typeof(MstLinksAcItem))]
		[PersistenceMode(PersistenceMode.InnerDefaultProperty)]
		public ITemplate FooterTemplate
		{
			get { return m_footerTemplate; }
			set { m_footerTemplate = value; }
		}

//      /// <summary>
//      /// Called by the ASP.NET page framework to notify server controls that use composition-based implementation to create any child controls they contain in preparation for posting back or rendering.
//      /// </summary>
//		protected override void CreateChildControls()
//      {
//         if (ChildControlsCreated)
//         {
//            return;
//         }

//         Controls.Clear();

//         //Instantiate the Header template (if exists)
//         if (m_headerTemplate != null)
//         {
//            Control headerItem = new Control();
//            m_headerTemplate.InstantiateIn(headerItem);
//            Controls.Add(headerItem);
//         }

//         //Instantiate the Footer template (if exists)
//         if (m_footerTemplate != null)
//         {
//            Control footerItem = new Control();
//            m_footerTemplate.InstantiateIn(footerItem);
//            Controls.Add(footerItem);
//         }
//
//         ChildControlsCreated = true;
//      }
	
		/// <summary>
        /// Overridden and Empty so that span tags are not written
        /// </summary>
        /// <param name="writer"></param>
        public override void RenderBeginTag(HtmlTextWriter writer)
        {
            
        }

        /// <summary>
        /// Overridden and Empty so that span tags are not written
        /// </summary>
        /// <param name="writer"></param>
        public override void RenderEndTag(HtmlTextWriter writer)
        {
                
        }		
		
		/// <summary>
      	/// Called by the ASP.NET page framework to notify server controls that use composition-based implementation to create any child controls they contain in preparation for posting back or rendering.
      	/// </summary>
		protected override int CreateChildControls(System.Collections.IEnumerable dataSource, bool dataBinding)
      	{
         int pos = 0;

         if (dataBinding)
         {
            //Instantiate the Header template (if exists)
            if (m_headerTemplate != null)
            {
                Control headerItem = new Control();
                m_headerTemplate.InstantiateIn(headerItem);
                Controls.Add(headerItem);
            }
			if (dataSource != null)
			{
				foreach (object o in dataSource)
				{
						SAMaster.Entities.MstLinksAc entity = o as SAMaster.Entities.MstLinksAc;
						MstLinksAcItem container = new MstLinksAcItem(entity);
	
						if (m_itemTemplate != null && (pos % 2) == 0)
						{
							m_itemTemplate.InstantiateIn(container);
							
							if (m_seperatorTemplate != null)
							{
								m_seperatorTemplate.InstantiateIn(container);
							}
						}
						else
						{
							if (m_altenateItemTemplate != null)
							{
								m_altenateItemTemplate.InstantiateIn(container);
								
								if (m_seperatorTemplate != null)
								{
									m_seperatorTemplate.InstantiateIn(container);
								}
								
							}
							else if (m_itemTemplate != null)
							{
								m_itemTemplate.InstantiateIn(container);
								
								if (m_seperatorTemplate != null)
								{
									m_seperatorTemplate.InstantiateIn(container);
								}
							}
							else
							{
								// no template !!!
							}
						}
						Controls.Add(container);
						
						container.DataBind();
						
						pos++;
				}
			}
            //Instantiate the Footer template (if exists)
            if (m_footerTemplate != null)
            {
                Control footerItem = new Control();
                m_footerTemplate.InstantiateIn(footerItem);
                Controls.Add(footerItem);
            }

		}
			
			return pos;
		}

        /// <summary>
        /// Raises the <see cref="E:System.Web.UI.Control.PreRender"></see> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs"></see> object that contains the event data.</param>
		protected override void OnPreRender(EventArgs e)
		{
			base.DataBind();
		}

		#region Design time
        /// <summary>
        /// Renders at design time.
        /// </summary>
        /// <returns>a  string of the Designed HTML</returns>
		internal string RenderAtDesignTime()
		{			
			return "Designer currently not implemented"; 
		}

		#endregion
	}

    /// <summary>
    /// A wrapper type for the entity
    /// </summary>
	[System.ComponentModel.ToolboxItem(false)]
	public class MstLinksAcItem : System.Web.UI.Control, System.Web.UI.INamingContainer
	{
		private SAMaster.Entities.MstLinksAc _entity;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:MstLinksAcItem"/> class.
        /// </summary>
		public MstLinksAcItem()
			: base()
		{ }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:MstLinksAcItem"/> class.
        /// </summary>
		public MstLinksAcItem(SAMaster.Entities.MstLinksAc entity)
			: base()
		{
			_entity = entity;
		}
		
        /// <summary>
        /// Gets the MapinfoId
        /// </summary>
        /// <value>The MapinfoId.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32 MapinfoId
		{
			get { return _entity.MapinfoId; }
		}
        /// <summary>
        /// Gets the MlinkId
        /// </summary>
        /// <value>The MlinkId.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? MlinkId
		{
			get { return _entity.MlinkId; }
		}
        /// <summary>
        /// Gets the CompKey
        /// </summary>
        /// <value>The CompKey.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? CompKey
		{
			get { return _entity.CompKey; }
		}
        /// <summary>
        /// Gets the UsNode
        /// </summary>
        /// <value>The UsNode.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String UsNode
		{
			get { return _entity.UsNode; }
		}
        /// <summary>
        /// Gets the DsNode
        /// </summary>
        /// <value>The DsNode.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String DsNode
		{
			get { return _entity.DsNode; }
		}
        /// <summary>
        /// Gets the PipeShape
        /// </summary>
        /// <value>The PipeShape.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String PipeShape
		{
			get { return _entity.PipeShape; }
		}
        /// <summary>
        /// Gets the LinkType
        /// </summary>
        /// <value>The LinkType.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String LinkType
		{
			get { return _entity.LinkType; }
		}
        /// <summary>
        /// Gets the PipeFlowType
        /// </summary>
        /// <value>The PipeFlowType.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String PipeFlowType
		{
			get { return _entity.PipeFlowType; }
		}
        /// <summary>
        /// Gets the Length
        /// </summary>
        /// <value>The Length.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Double? Length
		{
			get { return _entity.Length; }
		}
        /// <summary>
        /// Gets the DiamWidth
        /// </summary>
        /// <value>The DiamWidth.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Double? DiamWidth
		{
			get { return _entity.DiamWidth; }
		}
        /// <summary>
        /// Gets the Height
        /// </summary>
        /// <value>The Height.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Double? Height
		{
			get { return _entity.Height; }
		}
        /// <summary>
        /// Gets the Material
        /// </summary>
        /// <value>The Material.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String Material
		{
			get { return _entity.Material; }
		}
        /// <summary>
        /// Gets the Upsdpth
        /// </summary>
        /// <value>The Upsdpth.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Double? Upsdpth
		{
			get { return _entity.Upsdpth; }
		}
        /// <summary>
        /// Gets the Dwndpth
        /// </summary>
        /// <value>The Dwndpth.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Double? Dwndpth
		{
			get { return _entity.Dwndpth; }
		}
        /// <summary>
        /// Gets the Usie
        /// </summary>
        /// <value>The Usie.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Double? Usie
		{
			get { return _entity.Usie; }
		}
        /// <summary>
        /// Gets the Dsie
        /// </summary>
        /// <value>The Dsie.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Double? Dsie
		{
			get { return _entity.Dsie; }
		}
        /// <summary>
        /// Gets the AsBuilt
        /// </summary>
        /// <value>The AsBuilt.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String AsBuilt
		{
			get { return _entity.AsBuilt; }
		}
        /// <summary>
        /// Gets the Instdate
        /// </summary>
        /// <value>The Instdate.</value>
		[System.ComponentModel.Bindable(true)]
		public System.DateTime? Instdate
		{
			get { return _entity.Instdate; }
		}
        /// <summary>
        /// Gets the Fromx
        /// </summary>
        /// <value>The Fromx.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Double? Fromx
		{
			get { return _entity.Fromx; }
		}
        /// <summary>
        /// Gets the Fromy
        /// </summary>
        /// <value>The Fromy.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Double? Fromy
		{
			get { return _entity.Fromy; }
		}
        /// <summary>
        /// Gets the Tox
        /// </summary>
        /// <value>The Tox.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Double? Tox
		{
			get { return _entity.Tox; }
		}
        /// <summary>
        /// Gets the Toy
        /// </summary>
        /// <value>The Toy.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Double? Toy
		{
			get { return _entity.Toy; }
		}
        /// <summary>
        /// Gets the Roughness
        /// </summary>
        /// <value>The Roughness.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Double? Roughness
		{
			get { return _entity.Roughness; }
		}
        /// <summary>
        /// Gets the TimeFrame
        /// </summary>
        /// <value>The TimeFrame.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String TimeFrame
		{
			get { return _entity.TimeFrame; }
		}
        /// <summary>
        /// Gets the DataFlagSynth
        /// </summary>
        /// <value>The DataFlagSynth.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? DataFlagSynth
		{
			get { return _entity.DataFlagSynth; }
		}
        /// <summary>
        /// Gets the DataQual
        /// </summary>
        /// <value>The DataQual.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String DataQual
		{
			get { return _entity.DataQual; }
		}
        /// <summary>
        /// Gets the Hservstat
        /// </summary>
        /// <value>The Hservstat.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String Hservstat
		{
			get { return _entity.Hservstat; }
		}
        /// <summary>
        /// Gets the ValidFromDate
        /// </summary>
        /// <value>The ValidFromDate.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String ValidFromDate
		{
			get { return _entity.ValidFromDate; }
		}
        /// <summary>
        /// Gets the ValidToDate
        /// </summary>
        /// <value>The ValidToDate.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String ValidToDate
		{
			get { return _entity.ValidToDate; }
		}
        /// <summary>
        /// Gets the CadKey
        /// </summary>
        /// <value>The CadKey.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String CadKey
		{
			get { return _entity.CadKey; }
		}
        /// <summary>
        /// Gets the AuditNodeId
        /// </summary>
        /// <value>The AuditNodeId.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String AuditNodeId
		{
			get { return _entity.AuditNodeId; }
		}
        /// <summary>
        /// Gets the AuditDups
        /// </summary>
        /// <value>The AuditDups.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String AuditDups
		{
			get { return _entity.AuditDups; }
		}
        /// <summary>
        /// Gets the AuditSpatial
        /// </summary>
        /// <value>The AuditSpatial.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String AuditSpatial
		{
			get { return _entity.AuditSpatial; }
		}
        /// <summary>
        /// Gets the AuditOk2Go
        /// </summary>
        /// <value>The AuditOk2Go.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Boolean AuditOk2Go
		{
			get { return _entity.AuditOk2Go; }
		}
        /// <summary>
        /// Gets the AuditProcTimestamp
        /// </summary>
        /// <value>The AuditProcTimestamp.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String AuditProcTimestamp
		{
			get { return _entity.AuditProcTimestamp; }
		}
        /// <summary>
        /// Gets the Qdes
        /// </summary>
        /// <value>The Qdes.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Double? Qdes
		{
			get { return _entity.Qdes; }
		}
        /// <summary>
        /// Gets the DmeGlobalId
        /// </summary>
        /// <value>The DmeGlobalId.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? DmeGlobalId
		{
			get { return _entity.DmeGlobalId; }
		}

        /// <summary>
        /// Gets a <see cref="T:SAMaster.Entities.MstLinksAc"></see> object
        /// </summary>
        /// <value></value>
        [System.ComponentModel.Bindable(true)]
        public SAMaster.Entities.MstLinksAc Entity
        {
            get { return _entity; }
        }
	}
}
