using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Accessory
{
    public partial class SequenceActionActorSetCloth : Black.Sequence.Actor.SequenceActionActorStatusOneBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin clothIdPin_;
		public int playerBankNumber_;
		public uint clothId_;
		public uint characterParamId_;
		public bool injured_;
		public bool age_;
		public bool miners_;
		public bool child_;
		public bool first_person_;
		public bool friend_control_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorSetCloth();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Accessory.SequenceActionActorSetCloth", 0, Black.Sequence.Action.Actor.Accessory.SequenceActionActorSetCloth.ObjectType, null, properties, 0, 576);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Accessory.SequenceActionActorSetCloth", base.GetFieldProperties(), 1593721034, 1854601590);
            return fieldProperties;
        }

		
    }
}