
namespace mulova.i18n
{
	public class SpreadSheetColumnAttribute : System.Attribute {
		public readonly string column;
		public readonly int columnIndex;
		public readonly object defaultValue;

		public SpreadSheetColumnAttribute(string column) : this(column, null) { }

		public SpreadSheetColumnAttribute(string column, object defaultValue) {
			this.column = column;
			this.columnIndex = GetColumnIndex(column);
			this.defaultValue = defaultValue;
		}

		private int GetColumnIndex(string col) {
			string uppercase = col.ToUpper();
			int index = uppercase[0]-'A'+1;
			for (int i=1; i<uppercase.Length; i++) {
				index*=26;
                index += (uppercase[i]-'A')+1;
			}
			return index-1;
		}
	}
}