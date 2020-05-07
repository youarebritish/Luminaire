using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Variable
{
    public partial class SequenceVariableSwfPlayerConnectionMoreEntity : Black.Sequence.Variable.SequenceVariableSwfPlayerEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin40_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin39_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin38_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin37_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin36_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin35_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin34_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin33_;
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
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin8_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin7_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin6_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin5_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin4_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin3_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin2_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin1_;
		public uint instanceId1_;
		public uint instanceId2_;
		public uint instanceId3_;
		public uint instanceId4_;
		public uint instanceId5_;
		public uint instanceId6_;
		public uint instanceId7_;
		public uint instanceId8_;
		public uint instanceId9_;
		public uint instanceId10_;
		public uint instanceId11_;
		public uint instanceId12_;
		public uint instanceId13_;
		public uint instanceId14_;
		public uint instanceId15_;
		public uint instanceId16_;
		public uint instanceId17_;
		public uint instanceId18_;
		public uint instanceId19_;
		public uint instanceId20_;
		public uint instanceId21_;
		public uint instanceId22_;
		public uint instanceId23_;
		public uint instanceId24_;
		public uint instanceId25_;
		public uint instanceId26_;
		public uint instanceId27_;
		public uint instanceId28_;
		public uint instanceId29_;
		public uint instanceId30_;
		public uint instanceId31_;
		public uint instanceId32_;
		public uint instanceId33_;
		public uint instanceId34_;
		public uint instanceId35_;
		public uint instanceId36_;
		public uint instanceId37_;
		public uint instanceId38_;
		public uint instanceId39_;
		public uint instanceId40_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceVariableSwfPlayerConnectionMoreEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Variable.SequenceVariableSwfPlayerConnectionMoreEntity", 0, Black.Sequence.Variable.SequenceVariableSwfPlayerConnectionMoreEntity.ObjectType, null, properties, 0, 3904);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Variable.SequenceVariableSwfPlayerConnectionMoreEntity", base.GetFieldProperties(), 1816024873, -928487289);
            return fieldProperties;
        }

		
    }
}