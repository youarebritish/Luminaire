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
            return fieldProperties;
        }

		
    }
}