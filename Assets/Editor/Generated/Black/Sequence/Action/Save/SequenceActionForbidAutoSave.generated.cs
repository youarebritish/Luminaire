using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Save
{
    public partial class SequenceActionForbidAutoSave : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin forbid_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin permit_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool notForbidFastTravel_;
		public bool notForbidSaveAnyWhere_;
		public bool onlyForbidReturnCamp_;
		public int forbidType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionForbidAutoSave();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Save.SequenceActionForbidAutoSave", 0, Black.Sequence.Action.Save.SequenceActionForbidAutoSave.ObjectType, null, properties, 0, 472);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Save.SequenceActionForbidAutoSave", base.GetFieldProperties(), -598847051, 1012250788);
            return fieldProperties;
        }

		
    }
}