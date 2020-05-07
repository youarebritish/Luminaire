using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Chocobo
{
    public partial class SequenceActionChocoboSave : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin set_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int type_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin stringOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin fixidOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin intOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin millisecondOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin secondOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin minuteOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin stringIn_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin fixidIn_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin intIn_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin indexIn_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionChocoboSave();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Chocobo.SequenceActionChocoboSave", 0, Black.Sequence.Action.Chocobo.SequenceActionChocoboSave.ObjectType, null, properties, 0, 1256);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Chocobo.SequenceActionChocoboSave", base.GetFieldProperties(), -766019166, -2032852775);
            
			
			
			return fieldProperties;
        }

		
    }
}