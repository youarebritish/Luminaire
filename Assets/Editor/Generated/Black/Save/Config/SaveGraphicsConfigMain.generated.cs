using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Config
{
    public partial class SaveGraphicsConfigMain
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int displayResolutionWidth_;
		public int displayResolutionHeight_;
		public int currentDisplay_;
		public int maxFramerate_;
		public bool fullScreen_;
		public bool vSyncWaitEnable_;
		public int hdrBlightness_;
		public bool showFPS_;
		public int graphicsPreset_;
		public int display3DResolution_;
		public int assetSpecLevel_;
		public int modelLODScaling_;
		public int textureStreamingMemory_;
		public int textureAnisotropicFilter_;
		public bool terrainTessellationEnable_;
		public int lighting_;
		public int shadow_;
		public int ambientOcclusion_;
		public int antialias_;
		public bool motionBlur_;
		public int screenFilterDetail_;
		public bool nvidiaHairWorks_;
		public bool nvidiaVXAO_;
		public bool nvidiaTurf_;
		public bool nvidiaShadowLibs_;
		public bool hardwareFullScreen_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveGraphicsConfigMain();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Config.SaveGraphicsConfigMain", 0, Black.Save.Config.SaveGraphicsConfigMain.ObjectType, null, properties, 0, 88);
        }
		
        public  ObjectType GetObjectType()
        {
            return ObjectType;
        }

        protected  PropertyContainer GetFieldProperties()
        {
            if (fieldProperties != null)
            {
                return fieldProperties;
            }

            fieldProperties = new PropertyContainer("Black.Save.Config.SaveGraphicsConfigMain", null, 1128139620, 60261537);
            
			
			
			return fieldProperties;
        }

		
    }
}