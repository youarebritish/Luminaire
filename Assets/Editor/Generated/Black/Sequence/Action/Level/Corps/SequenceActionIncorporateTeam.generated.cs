using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level.Corps
{
    public partial class SequenceActionIncorporateTeam : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin @in;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin @out;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin incorporatedCorps;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin incorporateTeam;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionIncorporateTeam();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.Corps.SequenceActionIncorporateTeam", 0, Black.Sequence.Action.Level.Corps.SequenceActionIncorporateTeam.ObjectType, null, properties, 0, 552);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.Corps.SequenceActionIncorporateTeam", base.GetFieldProperties(), 569282412, -745901099);
            return fieldProperties;
        }

		
    }
}