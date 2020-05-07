using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level.Party
{
    public partial class SequenceActionChangePlayerSearch : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actorIPin_;
		public int searchSetting_;
		public uint searchLabelNormal_;
		public uint searchLabelHang_;
		public uint searchLabelLockCam_;
		public uint searchLabelCover_;
		public uint searchLabelTurret_;
		public uint searchLabelSpecial1_;
		public uint searchLabelSpecial2_;
		public uint searchLabelSpecial3_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionChangePlayerSearch();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.Party.SequenceActionChangePlayerSearch", 0, Black.Sequence.Action.Level.Party.SequenceActionChangePlayerSearch.ObjectType, null, properties, 0, 496);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.Party.SequenceActionChangePlayerSearch", base.GetFieldProperties(), 1609977900, -1128497474);
            
			
			
			return fieldProperties;
        }

		
    }
}