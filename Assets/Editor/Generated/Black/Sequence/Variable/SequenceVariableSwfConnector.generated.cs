using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Variable
{
    public partial class SequenceVariableSwfConnector : SQEX.Ebony.Framework.Sequence.SequenceVariable
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int pinNum_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin8_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin7_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin6_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin5_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin4_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin3_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin2_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin1_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin32_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin31_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin30_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin29_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin28_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin27_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin26_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin25_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin24_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin23_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin22_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin21_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin20_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin19_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin18_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin17_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin16_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin15_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin14_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin13_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin12_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin11_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin10_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin9_;
		public string prefix1_;
		public string prefix2_;
		public string prefix3_;
		public string prefix4_;
		public string prefix5_;
		public string prefix6_;
		public string prefix7_;
		public string prefix8_;
		public string prefix9_;
		public string prefix10_;
		public string prefix11_;
		public string prefix12_;
		public string prefix13_;
		public string prefix14_;
		public string prefix15_;
		public string prefix16_;
		public string prefix17_;
		public string prefix18_;
		public string prefix19_;
		public string prefix20_;
		public string prefix21_;
		public string prefix22_;
		public string prefix23_;
		public string prefix24_;
		public string prefix25_;
		public string prefix26_;
		public string prefix27_;
		public string prefix28_;
		public string prefix29_;
		public string prefix30_;
		public string prefix31_;
		public string prefix32_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceVariableSwfConnector();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Variable.SequenceVariableSwfConnector", 0, Black.Sequence.Variable.SequenceVariableSwfConnector.ObjectType, null, properties, 0, 3456);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Variable.SequenceVariableSwfConnector", base.GetFieldProperties(), -1655035652, -1705851642);
            return fieldProperties;
        }

		
    }
}