using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceActionActorCreate : Black.Sequence.Actor.SequenceActionActorCreateBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finished_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failed_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inCharEntryPath_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rotation_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin position_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin baseScale_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin spawnPointPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin createdActor_;
		public int actoryType_;
		public string CharaEntry_;
		public uint overwriteParamId_;
		public int defaultAIControllerType_;
		public string sourcePathAI_;
		public string sourcePathAIGraph_;
		public uint overwriteInteractionParamId_;
		public bool isOverwriteDefaultControllerType_;
		public string sourcePathScheduleAI_;
		public string sourcePathScheduleDefault_;
		public uint overrideAIParamId_;
		public string sourcePathCommand_;
		public bool bAsync_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorCreate();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionActorCreate", 0, Black.Sequence.Actor.SequenceActionActorCreate.ObjectType, null, properties, 0, 1856);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionActorCreate", base.GetFieldProperties(), -1892091469, 1964481557);
            
			
			
			return fieldProperties;
        }

		
    }
}