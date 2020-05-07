using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Event
{
    public partial class SequenceActionPlayMovie : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin play_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stop_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finished_;
		public uint eventId_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin movieFilePathPin_;
		public string moviePath_;
		public bool isRegisterEvent_;
		public bool isExcludePlay_;
		public bool isFadeOutUntilMoviePrepared_;
		public bool useLocalizeFile_;
		public UnityEngine.Color fadeColor_;
		public int preparedFadeInFrame_;
		public UnityEngine.Color preparedFadeInColor_;
		public int fadeOutFrame_;
		public UnityEngine.Color fadeOutColor_;
		public int fadeInFrame_;
		public UnityEngine.Color fadeInColor_;
		public bool isEnableSkip_;
		public int eventSkipFadeOutFrame_;
		public UnityEngine.Color eventSkipFadeOutColor_;
		public int eventSkipFadeInFrame_;
		public UnityEngine.Color eventSkipFadeInColor_;
		public bool watchState_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionPlayMovie();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Event.SequenceActionPlayMovie", 0, Black.Sequence.Action.Event.SequenceActionPlayMovie.ObjectType, null, properties, 0, 880);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Event.SequenceActionPlayMovie", base.GetFieldProperties(), -362818226, -2140049990);
            
			fieldProperties.AddProperty(new Property("play_", 3806684788, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("stop_", 3454812878, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("finished_", 3052293812, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 464, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("eventId_", 548562519, "SQEX.Ebony.Std.Fixid", 560, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("movieFilePathPin_", 604567898, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 568, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moviePath_", 2046865557, "Ebony.Base.String", 656, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("isRegisterEvent_", 359097253, "bool", 672, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isExcludePlay_", 2643231696, "bool", 673, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isFadeOutUntilMoviePrepared_", 1309641853, "bool", 674, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("useLocalizeFile_", 3398091906, "bool", 675, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("fadeColor_", 295369271, "Luminous.RenderInterface.Color", 688, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("preparedFadeInFrame_", 3246864503, "int", 704, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("preparedFadeInColor_", 366423137, "Luminous.RenderInterface.Color", 720, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("fadeOutFrame_", 3184309659, "int", 736, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("fadeOutColor_", 3998816037, "Luminous.RenderInterface.Color", 752, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("fadeInFrame_", 3674210006, "int", 768, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("fadeInColor_", 4214166776, "Luminous.RenderInterface.Color", 784, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("isEnableSkip_", 4100227358, "bool", 800, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("eventSkipFadeOutFrame_", 278089992, "int", 808, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("eventSkipFadeOutColor_", 160398290, "Luminous.RenderInterface.Color", 816, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("eventSkipFadeInFrame_", 2183039299, "int", 832, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("eventSkipFadeInColor_", 3771857421, "Luminous.RenderInterface.Color", 848, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("watchState_", 3369966742, "bool", 864, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}