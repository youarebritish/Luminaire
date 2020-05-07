using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceActionPlayerCharacter : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool noct_;
		public uint characterEntryIdNoct_;
		public bool gladio_;
		public uint characterEntryIdGladio_;
		public bool prompt_;
		public uint characterEntryIdPrompt_;
		public bool iginis_;
		public uint characterEntryIdIgnis_;
		public bool cor_;
		public uint characterEntryIdCor_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionPlayerCharacter();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionPlayerCharacter", 0, Black.Sequence.Actor.SequenceActionPlayerCharacter.ObjectType, null, properties, 0, 408);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionPlayerCharacter", base.GetFieldProperties(), -1699924221, 765981038);
            return fieldProperties;
        }

		
    }
}