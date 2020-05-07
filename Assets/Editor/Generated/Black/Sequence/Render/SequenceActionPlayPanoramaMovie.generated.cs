using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Render
{
    public partial class SequenceActionPlayPanoramaMovie : SQEX.Ebony.Framework.Sequence.SequenceAction
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
		public float skyRadius_;
		public bool useLocalizeFile_;
		public bool useAsIBL_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionPlayPanoramaMovie();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Render.SequenceActionPlayPanoramaMovie", 0, Black.Sequence.Render.SequenceActionPlayPanoramaMovie.ObjectType, null, properties, 0, 720);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Render.SequenceActionPlayPanoramaMovie", base.GetFieldProperties(), -236724193, -1523226129);
            
			
			
			return fieldProperties;
        }

		
    }
}