using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Variable
{
    public partial class SequenceConstDataGrid : SQEX.Ebony.Framework.Sequence.Variable.SequenceConstBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin colIndexPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rowIndexPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin rowValuePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin cellValuePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin colNumPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin rowNumPin_;
		public string gridName_;
		public int windowWidth_;
		public int windowHeight_;
		public int columnNum_;
		public int keyIndex_;
		public int accessRowIndex_;
		public int accessColIndex_;
		public string name1_;
		public int type1_;
		public int width1_;
		public string name2_;
		public int type2_;
		public int width2_;
		public string name3_;
		public int type3_;
		public int width3_;
		public string name4_;
		public int type4_;
		public int width4_;
		public string name5_;
		public int type5_;
		public int width5_;
		public string name6_;
		public int type6_;
		public int width6_;
		public string name7_;
		public int type7_;
		public int width7_;
		public string name8_;
		public int type8_;
		public int width8_;
		public SQEX.Ebony.Framework.Data.DataTable dataTable_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceConstDataGrid();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Variable.SequenceConstDataGrid", 0, SQEX.Ebony.Framework.Sequence.Variable.SequenceConstDataGrid.ObjectType, null, properties, 0, 872);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Variable.SequenceConstDataGrid", base.GetFieldProperties(), -553805739, 1052445092);
            return fieldProperties;
        }

		
    }
}