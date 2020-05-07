using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionGetExeInfomation : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outIsMaster_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outIsWindows_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outIsPS4_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outIsXBoxOne_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outRegion_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outLocale_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outSystemLocale_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outFieldCounter_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outIsAuthoring_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outIsXBoxOneAndUWP_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outIsSteam_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outIsOrigin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outIsSingleLocale_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outIsSteamBigPicture_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionGetExeInfomation();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionGetExeInfomation", 0, Black.Sequence.Action.Menu.SequenceActionGetExeInfomation.ObjectType, null, properties, 0, 1408);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionGetExeInfomation", base.GetFieldProperties(), 1691006831, 907264568);
            
			fieldProperties.AddProperty(new Property("outIsMaster_", 2617584282, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 176, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outIsWindows_", 3902397989, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 264, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outIsPS4_", 2364611651, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 352, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outIsXBoxOne_", 4044437563, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 440, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outRegion_", 3685005720, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 528, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outLocale_", 2330113818, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 616, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outSystemLocale_", 2959205389, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 704, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outFieldCounter_", 2358034096, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 792, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outIsAuthoring_", 3139157129, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 880, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outIsXBoxOneAndUWP_", 4116657802, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 968, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outIsSteam_", 3286470178, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1056, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outIsOrigin_", 1710501206, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1144, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outIsSingleLocale_", 2313729894, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1232, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outIsSteamBigPicture_", 2364981722, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1320, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}