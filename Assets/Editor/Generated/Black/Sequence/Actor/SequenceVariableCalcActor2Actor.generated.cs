using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceVariableCalcActor2Actor : SQEX.Ebony.Framework.Sequence.SequenceVariable
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor1_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor2_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin float_;
		public int kind_;
		public uint joint1_;
		public uint joint2_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceVariableCalcActor2Actor();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceVariableCalcActor2Actor", 0, Black.Sequence.Actor.SequenceVariableCalcActor2Actor.ObjectType, null, properties, 0, 368);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceVariableCalcActor2Actor", base.GetFieldProperties(), -1722707190, 832125100);
            return fieldProperties;
        }

		
    }
}