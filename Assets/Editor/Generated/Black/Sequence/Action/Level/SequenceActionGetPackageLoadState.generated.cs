using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionGetPackageLoadState : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin triggerIn_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin triggerOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valueMargin_;
		public int prefixType_;
		public uint searchLabelId_;
		public uint searchPackageId_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin searchLabelIdPin_;
		public float margin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionGetPackageLoadState();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionGetPackageLoadState", 0, Black.Sequence.Action.Level.SequenceActionGetPackageLoadState.ObjectType, null, properties, 0, 760);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionGetPackageLoadState", base.GetFieldProperties(), 504636479, -1428710809);
            
			
			
			return fieldProperties;
        }

		
    }
}