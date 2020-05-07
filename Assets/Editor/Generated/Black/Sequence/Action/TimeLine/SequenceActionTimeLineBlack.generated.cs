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
            
			fieldProperties.AddProperty(new Property("playRateActorInputPin_", 2278438602, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1504, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("preparedFadeInFrame_", 3246864503, "int", 1596, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("preparedFadeInColor_", 366423137, "Luminous.RenderInterface.Color", 1600, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("fadeOutFrame_", 3184309659, "int", 1616, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("fadeOutColor_", 3998816037, "Luminous.RenderInterface.Color", 1632, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("fadeInFrame_", 3674210006, "int", 1648, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("fadeInColor_", 4214166776, "Luminous.RenderInterface.Color", 1664, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("eventSkipFadeOutFrame_", 278089992, "int", 1684, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("eventSkipFadeOutColor_", 160398290, "Luminous.RenderInterface.Color", 1696, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("eventSkipFadeInFrame_", 2183039299, "int", 1712, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("eventSkipFadeInColor_", 3771857421, "Luminous.RenderInterface.Color", 1728, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("eventSkipUseCharaRelativeCameraTrack_", 3270596885, "bool", 1744, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}