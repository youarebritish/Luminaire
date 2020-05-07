using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Sample
{
    public partial class SequenceActionSamplePropertySequence : SQEX.Ebony.Framework.Sequence.Action.SequenceActionWithCurveControl
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool bool1_;
		public bool bool1R_;
		public int int1_;
		public int int1R_;
		public float float1_;
		public float float1R_;
		public UnityEngine.Vector4 vect1_;
		public UnityEngine.Vector4 vect1R_;
		public UnityEngine.Color color1_;
		public UnityEngine.Color color1R_;
		public string str1_;
		public string str1R_;
		public string fileExt1_;
		public string fileExt1R_;
		public string matchFolder1_;
		public string matchFolder1R_;
		public uint fixId1_;
		public uint fixId1R_;
		public int enum1_;
		public int enum1R_;
		public bool pointer1_;
		public bool pointer1R_;
		public bool buttonUi_;
		public bool buttonUiR_;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> pathList_;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> strList_;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem> fixIdList_;
		public IList<bool> primitiveBoolList_;
		public IList<int> primitiveIntList_;
		public IList<float> primitiveFloatList_;
		public IList<Black.Camera.CameraManager.BlackCameraParamType> primitiveEnumLongList_;
		public IList<string> primitiveStringList_;
		public IList<UnityEngine.Vector4> primitiveVectorList_;
		public IList<UnityEngine.Color> primitivecolorList_;
		public Black.System.TimeLine.TrackItem.Render.Light.LightBaseTrackItem struct1_;
		public bool deprecatedTest_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSamplePropertySequence();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Sample.SequenceActionSamplePropertySequence", 0, Black.Sequence.Action.Sample.SequenceActionSamplePropertySequence.ObjectType, null, properties, 0, 736);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Sample.SequenceActionSamplePropertySequence", base.GetFieldProperties(), 816959911, 1668750301);
            
			
			
			return fieldProperties;
        }

		
    }
}