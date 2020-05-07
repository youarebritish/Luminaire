using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Render
{
    public partial class SequenceActionPlayBackgroundMovie : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin play_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stop_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin started_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin stoped_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finished_;
		public string moviePath_;
		public bool loopPlay_;
		public int textureWidth_;
		public int textureHeight_;
		public float shadowPower_;
		public UnityEngine.Color shadowColor_;
		public bool useLocalizeFile_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionPlayBackgroundMovie();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Render.SequenceActionPlayBackgroundMovie", 0, Black.Sequence.Action.Render.SequenceActionPlayBackgroundMovie.ObjectType, null, properties, 0, 720);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Render.SequenceActionPlayBackgroundMovie", base.GetFieldProperties(), 1986118353, -2006676571);
            return fieldProperties;
        }

		
    }
}