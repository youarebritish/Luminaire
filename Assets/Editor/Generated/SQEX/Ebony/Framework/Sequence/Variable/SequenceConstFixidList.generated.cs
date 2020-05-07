using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Variable
{
    public partial class SequenceConstFixidList : SQEX.Ebony.Framework.Sequence.Variable.SequenceConstBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin out_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData data0_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData data1_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData data2_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData data3_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData data4_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData data5_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData data6_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData data7_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData data8_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData data9_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData data10_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData data11_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData data12_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData data13_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData data14_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData data15_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData data16_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData data17_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData data18_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData data19_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceConstFixidList();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Variable.SequenceConstFixidList", 0, SQEX.Ebony.Framework.Sequence.Variable.SequenceConstFixidList.ObjectType, null, properties, 0, 496);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Variable.SequenceConstFixidList", base.GetFieldProperties(), -2113154256, -1293660806);
            return fieldProperties;
        }

		
    }
}