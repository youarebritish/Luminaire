using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Variable
{
    public partial class SequenceVariableChocoboRaceFriendPoint : SQEX.Ebony.Framework.Sequence.SequenceVariable
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin isAdded_;
		public int pointType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceVariableChocoboRaceFriendPoint();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Variable.SequenceVariableChocoboRaceFriendPoint", 0, Black.Sequence.Variable.SequenceVariableChocoboRaceFriendPoint.ObjectType, null, properties, 0, 184);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Variable.SequenceVariableChocoboRaceFriendPoint", base.GetFieldProperties(), 51397132, -632849541);
            return fieldProperties;
        }

		
    }
}