using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.MultiPlayer
{
    public partial class SequenceMultiPlayerGetPlayerActorList : SQEX.Ebony.Framework.Sequence.SequenceVariable
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actorListOPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin connectedNumPin_;
		public bool isExcludingMyself_;
		public bool isExcludingAI_;
		public bool isExcludingDeath_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiPlayerGetPlayerActorList();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.MultiPlayer.SequenceMultiPlayerGetPlayerActorList", 0, Black.Sequence.MultiPlayer.SequenceMultiPlayerGetPlayerActorList.ObjectType, null, properties, 0, 320);
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

            fieldProperties = new PropertyContainer("Black.Sequence.MultiPlayer.SequenceMultiPlayerGetPlayerActorList", base.GetFieldProperties(), 486315804, -1362950699);
            
			
			
			return fieldProperties;
        }

		
    }
}