using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionMenuLogic : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin openMenu_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin closeMenu_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin requestAddMenu_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin cancelRequestMenu_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin quitMenu_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin suspendMenu_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin resumeMenu_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin swfEntryEntity_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionMenuLogic();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionMenuLogic", 0, Black.Sequence.Action.Menu.SequenceActionMenuLogic.ObjectType, null, properties, 0, 936);
        }
		
        public override ObjectType GetObjectType()
        {
            return ObjectType;
        }

        protected override PropertyContainer GetFieldProperties()
        {
            if (fieldProperties != null)
            {
                return fieldProperties;
            }

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionMenuLogic", base.GetFieldProperties(), -1417215128, 639910902);
            
			fieldProperties.AddProperty(new Property("openMenu_", 2126052019, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("closeMenu_", 2474037169, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("requestAddMenu_", 2976475891, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("cancelRequestMenu_", 1862182124, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 464, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("quitMenu_", 678020130, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 560, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("suspendMenu_", 1618982385, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 656, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("resumeMenu_", 113771670, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 752, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfEntryEntity_", 2279946639, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 848, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}