using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Variable
{
    public partial class SequenceVariableSwfPlayerConnectionEntity : Black.Sequence.Variable.SequenceVariableSwfPlayerEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
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
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceVariableSwfPlayerConnectionEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Variable.SequenceVariableSwfPlayerConnectionEntity", 0, Black.Sequence.Variable.SequenceVariableSwfPlayerConnectionEntity.ObjectType, null, properties, 0, 2064);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Variable.SequenceVariableSwfPlayerConnectionEntity", base.GetFieldProperties(), 1162593721, 316008720);
            return fieldProperties;
        }

		
    }
}