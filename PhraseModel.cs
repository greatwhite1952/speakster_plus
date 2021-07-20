using System;

namespace Speech.Models
{
	public PhraseModel()
	{
		public int Id { get; set; }
		public string Phrase { get; set; }
		public List<PhraseModel> CategoryMembers { get; set; } = new List<PhraseModel>();
	}
}
