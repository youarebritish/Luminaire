using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.SceneControl
{
    public partial class SequenceActionSCPersonalSetting : SQEX.Ebony.Framework.Sequence.Variable.SequenceConstBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inCharEntryPath_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin overwriteParameterIDPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin spawnSet_;
		public int actorType_;
		public bool autoLoadCharaEntry_;
		public string charaEntry_;
		public uint overwriteParameterID_;
		public int defaultAIControllerType_;
		public string sourcePathAI_;
		public string sourcePathAIGraph_;
		public uint overwriteInteractionParamId_;
		public uint teritoryFixId_;
		public bool isOverwriteDefaultControllerType_;
		public string sourcePathScheduleAI_;
		public string sourcePathScheduleDefault_;
		public uint overrideAIParamId_;
		public string sourcePathCommand_;
		public int maxSpawnNum_;
		public int minSpawnNum_;
		public int maxAliveNum_;
		public int minAliveNum_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSCPersonalSetting();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SceneControl.SequenceActionSCPersonalSetting", 0, Black.Sequence.Actor.SceneControl.SequenceActionSCPersonalSetting.ObjectType, null, properties, 0, 504);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SceneControl.SequenceActionSCPersonalSetting", base.GetFieldProperties(), -849926598, -390443165);
            return fieldProperties;
        }

		
    }
}