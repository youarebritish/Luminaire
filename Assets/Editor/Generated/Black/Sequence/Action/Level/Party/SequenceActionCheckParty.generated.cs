using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level.Party
{
    public partial class SequenceActionCheckParty : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin member0ExistPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin member1ExistPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin member2ExistPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin member3ExistPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin member4ExistPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin member5ExistPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin member6ExistPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin member7ExistPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin member8ExistPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin conditionTruePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin conditionFalsePin_;
		public int member0CheckType_;
		public int member1CheckType_;
		public int member2CheckType_;
		public int member3CheckType_;
		public int member4CheckType_;
		public int member5CheckType_;
		public int member6CheckType_;
		public int member7CheckType_;
		public int member8CheckType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCheckParty();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.Party.SequenceActionCheckParty", 0, Black.Sequence.Action.Level.Party.SequenceActionCheckParty.ObjectType, null, properties, 0, 1368);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.Party.SequenceActionCheckParty", base.GetFieldProperties(), 280313634, 1842573798);
            return fieldProperties;
        }

		
    }
}