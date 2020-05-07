using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Chocobo
{
    public partial class SequenceActionChocoboSupport : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int action_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin chocoboActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin speedPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin jumpHeightPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin timePin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionChocoboSupport();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Chocobo.SequenceActionChocoboSupport", 0, Black.Sequence.Action.Chocobo.SequenceActionChocoboSupport.ObjectType, null, properties, 0, 728);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Chocobo.SequenceActionChocoboSupport", base.GetFieldProperties(), -283848557, 1306492729);
            
			
			
			return fieldProperties;
        }

		
    }
}