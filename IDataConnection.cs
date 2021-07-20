using System;

namespace Speech.DataAccess
{
	public interface IDataConnection
	{
		void CreateCategory(CategoryModel model);

		void CreatePhrase(PhraseModel model);
	}
}
