using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000028 RID: 40
[Serializable]
public class InvBaseItem
{
	// Token: 0x040000C4 RID: 196
	public int id16;

	// Token: 0x040000C5 RID: 197
	public string name;

	// Token: 0x040000C6 RID: 198
	public string description;

	// Token: 0x040000C7 RID: 199
	public InvBaseItem.EKIPQNMFBLN slot;

	// Token: 0x040000C8 RID: 200
	public int minItemLevel = 1;

	// Token: 0x040000C9 RID: 201
	public int maxItemLevel = 50;

	// Token: 0x040000CA RID: 202
	public List<InvStat> stats = new List<InvStat>();

	// Token: 0x040000CB RID: 203
	public GameObject attachment;

	// Token: 0x040000CC RID: 204
	public Color color = Color.white;

	// Token: 0x040000CD RID: 205
	public BPLKJMJMHFI iconAtlas;

	// Token: 0x040000CE RID: 206
	public string iconName = string.Empty;

	// Token: 0x02000029 RID: 41
	public enum EKIPQNMFBLN
	{
		// Token: 0x040000D0 RID: 208
		None,
		// Token: 0x040000D1 RID: 209
		Weapon,
		// Token: 0x040000D2 RID: 210
		Shield,
		// Token: 0x040000D3 RID: 211
		Body,
		// Token: 0x040000D4 RID: 212
		Shoulders,
		// Token: 0x040000D5 RID: 213
		Bracers,
		// Token: 0x040000D6 RID: 214
		Boots,
		// Token: 0x040000D7 RID: 215
		Trinket,
		// Token: 0x040000D8 RID: 216
		_LastDoNotUse
	}
}
