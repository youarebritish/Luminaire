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
            return fieldProperties;
        }

		
    }
}