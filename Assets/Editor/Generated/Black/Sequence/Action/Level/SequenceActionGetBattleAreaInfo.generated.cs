using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionGetBattleAreaInfo : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin isExistPlayerBattleAreaIn_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin isExistPlayerBattleTeritoryIn_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin isExistPlayerSafeAreaIn_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin isExistPlayerPrivateAreaIn_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin isExistPlayerRteAreaIn_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin isExistPlayerTownAreaIn_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionGetBattleAreaInfo();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionGetBattleAreaInfo", 0, Black.Sequence.Action.Level.SequenceActionGetBattleAreaInfo.ObjectType, null, properties, 0, 1184);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionGetBattleAreaInfo", base.GetFieldProperties(), -648226596, -1566751290);
            
			
			
			return fieldProperties;
        }

		
    }
}