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
            return fieldProperties;
        }

		
    }
}