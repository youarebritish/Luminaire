using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine
{
    public partial class SequenceActionTimeLineBlack : SQEX.Ebony.Framework.Sequence.Action.SequenceActionTimeLine
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin playRateActorInputPin_;
		public int preparedFadeInFrame_;
		public UnityEngine.Color preparedFadeInColor_;
		public int fadeOutFrame_;
		public UnityEngine.Color fadeOutColor_;
		public int fadeInFrame_;
		public UnityEngine.Color fadeInColor_;
		public int eventSkipFadeOutFrame_;
		public UnityEngine.Color eventSkipFadeOutColor_;
		public int eventSkipFadeInFrame_;
		public UnityEngine.Color eventSkipFadeInColor_;
		public bool eventSkipUseCharaRelativeCameraTrack_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineBlack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.SequenceActionTimeLineBlack", 0, Black.Sequence.Action.TimeLine.SequenceActionTimeLineBlack.ObjectType, null, properties, 0, 1792);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.SequenceActionTimeLineBlack", base.GetFieldProperties(), -1885454668, 1182788593);
            
			
			
			return fieldProperties;
        }

		
    }
}