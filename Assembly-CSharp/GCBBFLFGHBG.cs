using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000021 RID: 33
[AddComponentMenu("NGUI/Examples/Equip Random Item")]
public class GCBBFLFGHBG : MonoBehaviour
{
	// Token: 0x06000528 RID: 1320 RVA: 0x0004C22C File Offset: 0x0004A42C
	private void HONNFNFPCEB()
	{
		if (this.KEJQDPGPKBM == null)
		{
			return;
		}
		List<InvBaseItem> mkhifdnefbd = QJFLHFDQNPN.NGDBDCQFDHI[0].MKHIFDNEFBD;
		if (mkhifdnefbd.Count == 0)
		{
			return;
		}
		int num = UnityEngine.Random.Range(0, mkhifdnefbd.Count);
		InvBaseItem invBaseItem = mkhifdnefbd[num];
		InvGameItem invGameItem = new InvGameItem(num, invBaseItem);
		invGameItem.quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(0, 39);
		invGameItem.itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
		this.KEJQDPGPKBM.CQCFMJMFELN(invGameItem);
	}

	// Token: 0x06000529 RID: 1321 RVA: 0x0004C2B4 File Offset: 0x0004A4B4
	private void PBEBBBJCOMC()
	{
		if (this.KEJQDPGPKBM == null)
		{
			return;
		}
		List<InvBaseItem> mkhifdnefbd = QJFLHFDQNPN.BBBCFDQHLEQ()[1].MKHIFDNEFBD;
		if (mkhifdnefbd.Count == 0)
		{
			return;
		}
		int num = UnityEngine.Random.Range(0, mkhifdnefbd.Count);
		InvBaseItem invBaseItem = mkhifdnefbd[num];
		InvGameItem invGameItem = new InvGameItem(num, invBaseItem);
		invGameItem.quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(0, -6);
		invGameItem.itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
		this.KEJQDPGPKBM.NPGCQDMEENC(invGameItem);
	}

	// Token: 0x0600052A RID: 1322 RVA: 0x0004C33C File Offset: 0x0004A53C
	private void INOQDGMGINK()
	{
		if (this.KEJQDPGPKBM == null)
		{
			return;
		}
		List<InvBaseItem> mkhifdnefbd = QJFLHFDQNPN.BBHEKMJMBGL()[1].MKHIFDNEFBD;
		if (mkhifdnefbd.Count == 0)
		{
			return;
		}
		int num = UnityEngine.Random.Range(1, mkhifdnefbd.Count);
		InvBaseItem invBaseItem = mkhifdnefbd[num];
		InvGameItem invGameItem = new InvGameItem(num, invBaseItem);
		invGameItem.quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(1, -99);
		invGameItem.itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
		this.KEJQDPGPKBM.CFFIKHGQDGP(invGameItem);
	}

	// Token: 0x0600052B RID: 1323 RVA: 0x0004C3C4 File Offset: 0x0004A5C4
	private void CGOHHFENQJC()
	{
		if (this.KEJQDPGPKBM == null)
		{
			return;
		}
		List<InvBaseItem> mkhifdnefbd = QJFLHFDQNPN.BBBCFDQHLEQ()[1].MKHIFDNEFBD;
		if (mkhifdnefbd.Count == 0)
		{
			return;
		}
		int num = UnityEngine.Random.Range(1, mkhifdnefbd.Count);
		InvBaseItem invBaseItem = mkhifdnefbd[num];
		InvGameItem invGameItem = new InvGameItem(num, invBaseItem);
		invGameItem.quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(1, 18);
		invGameItem.itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
		this.KEJQDPGPKBM.ODDDIPBOCGL(invGameItem);
	}

	// Token: 0x0600052C RID: 1324 RVA: 0x0004C44C File Offset: 0x0004A64C
	private void NGMQHPMGDPP()
	{
		if (this.KEJQDPGPKBM == null)
		{
			return;
		}
		List<InvBaseItem> mkhifdnefbd = QJFLHFDQNPN.FNCJDMODFGC()[0].MKHIFDNEFBD;
		if (mkhifdnefbd.Count == 0)
		{
			return;
		}
		int num = UnityEngine.Random.Range(0, mkhifdnefbd.Count);
		InvBaseItem invBaseItem = mkhifdnefbd[num];
		InvGameItem invGameItem = new InvGameItem(num, invBaseItem);
		invGameItem.quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(1, -115);
		invGameItem.itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
		this.KEJQDPGPKBM.LHQNDMIELIL(invGameItem);
	}

	// Token: 0x0600052D RID: 1325 RVA: 0x0004C4D4 File Offset: 0x0004A6D4
	private void ODIGFHJCILQ()
	{
		if (this.KEJQDPGPKBM == null)
		{
			return;
		}
		List<InvBaseItem> mkhifdnefbd = QJFLHFDQNPN.BBBCFDQHLEQ()[1].MKHIFDNEFBD;
		if (mkhifdnefbd.Count == 0)
		{
			return;
		}
		int num = UnityEngine.Random.Range(1, mkhifdnefbd.Count);
		InvBaseItem invBaseItem = mkhifdnefbd[num];
		InvGameItem invGameItem = new InvGameItem(num, invBaseItem);
		invGameItem.quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(0, -109);
		invGameItem.itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
		this.KEJQDPGPKBM.NPGCQDMEENC(invGameItem);
	}

	// Token: 0x0600052E RID: 1326 RVA: 0x0004C55C File Offset: 0x0004A75C
	private void KKELLJLGPCO()
	{
		if (this.KEJQDPGPKBM == null)
		{
			return;
		}
		List<InvBaseItem> mkhifdnefbd = QJFLHFDQNPN.FNCJDMODFGC()[0].MKHIFDNEFBD;
		if (mkhifdnefbd.Count == 0)
		{
			return;
		}
		int num = UnityEngine.Random.Range(1, mkhifdnefbd.Count);
		InvBaseItem invBaseItem = mkhifdnefbd[num];
		InvGameItem invGameItem = new InvGameItem(num, invBaseItem);
		invGameItem.quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(1, 60);
		invGameItem.itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
		this.KEJQDPGPKBM.LHQNDMIELIL(invGameItem);
	}

	// Token: 0x0600052F RID: 1327 RVA: 0x0004C5E4 File Offset: 0x0004A7E4
	private void OnClick()
	{
		if (this.KEJQDPGPKBM == null)
		{
			return;
		}
		List<InvBaseItem> mkhifdnefbd = QJFLHFDQNPN.NGDBDCQFDHI[0].MKHIFDNEFBD;
		if (mkhifdnefbd.Count == 0)
		{
			return;
		}
		int num = UnityEngine.Random.Range(0, mkhifdnefbd.Count);
		InvBaseItem invBaseItem = mkhifdnefbd[num];
		InvGameItem invGameItem = new InvGameItem(num, invBaseItem);
		invGameItem.quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(0, 12);
		invGameItem.itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
		this.KEJQDPGPKBM.ODDDIPBOCGL(invGameItem);
	}

	// Token: 0x06000530 RID: 1328 RVA: 0x0004C66C File Offset: 0x0004A86C
	private void MQQHIHHPHNN()
	{
		if (this.KEJQDPGPKBM == null)
		{
			return;
		}
		List<InvBaseItem> mkhifdnefbd = QJFLHFDQNPN.NGDBDCQFDHI[0].MKHIFDNEFBD;
		if (mkhifdnefbd.Count == 0)
		{
			return;
		}
		int num = UnityEngine.Random.Range(0, mkhifdnefbd.Count);
		InvBaseItem invBaseItem = mkhifdnefbd[num];
		InvGameItem invGameItem = new InvGameItem(num, invBaseItem);
		invGameItem.quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(0, 27);
		invGameItem.itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
		this.KEJQDPGPKBM.ODDDIPBOCGL(invGameItem);
	}

	// Token: 0x06000531 RID: 1329 RVA: 0x0004C6F4 File Offset: 0x0004A8F4
	private void IQMGMONIMIO()
	{
		if (this.KEJQDPGPKBM == null)
		{
			return;
		}
		List<InvBaseItem> mkhifdnefbd = QJFLHFDQNPN.NGDBDCQFDHI[0].MKHIFDNEFBD;
		if (mkhifdnefbd.Count == 0)
		{
			return;
		}
		int num = UnityEngine.Random.Range(0, mkhifdnefbd.Count);
		InvBaseItem invBaseItem = mkhifdnefbd[num];
		InvGameItem invGameItem = new InvGameItem(num, invBaseItem);
		invGameItem.quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(1, 113);
		invGameItem.itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
		this.KEJQDPGPKBM.CFFIKHGQDGP(invGameItem);
	}

	// Token: 0x06000532 RID: 1330 RVA: 0x0004C77C File Offset: 0x0004A97C
	private void JFJGPKOICMD()
	{
		if (this.KEJQDPGPKBM == null)
		{
			return;
		}
		List<InvBaseItem> mkhifdnefbd = QJFLHFDQNPN.GGFPHQBKJBJ()[0].MKHIFDNEFBD;
		if (mkhifdnefbd.Count == 0)
		{
			return;
		}
		int num = UnityEngine.Random.Range(1, mkhifdnefbd.Count);
		InvBaseItem invBaseItem = mkhifdnefbd[num];
		InvGameItem invGameItem = new InvGameItem(num, invBaseItem);
		invGameItem.quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(0, 122);
		invGameItem.itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
		this.KEJQDPGPKBM.NPGCQDMEENC(invGameItem);
	}

	// Token: 0x06000533 RID: 1331 RVA: 0x0004C804 File Offset: 0x0004AA04
	private void NHDKCIJQGCH()
	{
		if (this.KEJQDPGPKBM == null)
		{
			return;
		}
		List<InvBaseItem> mkhifdnefbd = QJFLHFDQNPN.GGFPHQBKJBJ()[1].MKHIFDNEFBD;
		if (mkhifdnefbd.Count == 0)
		{
			return;
		}
		int num = UnityEngine.Random.Range(0, mkhifdnefbd.Count);
		InvBaseItem invBaseItem = mkhifdnefbd[num];
		InvGameItem invGameItem = new InvGameItem(num, invBaseItem);
		invGameItem.quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(0, -46);
		invGameItem.itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
		this.KEJQDPGPKBM.CQCFMJMFELN(invGameItem);
	}

	// Token: 0x06000535 RID: 1333 RVA: 0x0004C88C File Offset: 0x0004AA8C
	private void LMIJQMCBOFB()
	{
		if (this.KEJQDPGPKBM == null)
		{
			return;
		}
		List<InvBaseItem> mkhifdnefbd = QJFLHFDQNPN.NJPHFKFPDPQ()[1].MKHIFDNEFBD;
		if (mkhifdnefbd.Count == 0)
		{
			return;
		}
		int num = UnityEngine.Random.Range(1, mkhifdnefbd.Count);
		InvBaseItem invBaseItem = mkhifdnefbd[num];
		InvGameItem invGameItem = new InvGameItem(num, invBaseItem);
		invGameItem.quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(0, -124);
		invGameItem.itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
		this.KEJQDPGPKBM.ODDDIPBOCGL(invGameItem);
	}

	// Token: 0x06000536 RID: 1334 RVA: 0x0004C914 File Offset: 0x0004AB14
	private void CFOPEJIQPPF()
	{
		if (this.KEJQDPGPKBM == null)
		{
			return;
		}
		List<InvBaseItem> mkhifdnefbd = QJFLHFDQNPN.NGDBDCQFDHI[1].MKHIFDNEFBD;
		if (mkhifdnefbd.Count == 0)
		{
			return;
		}
		int num = UnityEngine.Random.Range(1, mkhifdnefbd.Count);
		InvBaseItem invBaseItem = mkhifdnefbd[num];
		InvGameItem invGameItem = new InvGameItem(num, invBaseItem);
		invGameItem.quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(1, -17);
		invGameItem.itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
		this.KEJQDPGPKBM.CFFIKHGQDGP(invGameItem);
	}

	// Token: 0x06000537 RID: 1335 RVA: 0x0004C99C File Offset: 0x0004AB9C
	private void CJGOBLFNQOE()
	{
		if (this.KEJQDPGPKBM == null)
		{
			return;
		}
		List<InvBaseItem> mkhifdnefbd = QJFLHFDQNPN.BBHEKMJMBGL()[0].MKHIFDNEFBD;
		if (mkhifdnefbd.Count == 0)
		{
			return;
		}
		int num = UnityEngine.Random.Range(1, mkhifdnefbd.Count);
		InvBaseItem invBaseItem = mkhifdnefbd[num];
		InvGameItem invGameItem = new InvGameItem(num, invBaseItem);
		invGameItem.quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(1, 42);
		invGameItem.itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
		this.KEJQDPGPKBM.ODDDIPBOCGL(invGameItem);
	}

	// Token: 0x06000538 RID: 1336 RVA: 0x0004CA24 File Offset: 0x0004AC24
	private void NQDGCNMFKLL()
	{
		if (this.KEJQDPGPKBM == null)
		{
			return;
		}
		List<InvBaseItem> mkhifdnefbd = QJFLHFDQNPN.BBBCFDQHLEQ()[1].MKHIFDNEFBD;
		if (mkhifdnefbd.Count == 0)
		{
			return;
		}
		int num = UnityEngine.Random.Range(1, mkhifdnefbd.Count);
		InvBaseItem invBaseItem = mkhifdnefbd[num];
		InvGameItem invGameItem = new InvGameItem(num, invBaseItem);
		invGameItem.quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(0, 87);
		invGameItem.itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
		this.KEJQDPGPKBM.CQCFMJMFELN(invGameItem);
	}

	// Token: 0x06000539 RID: 1337 RVA: 0x0004CAAC File Offset: 0x0004ACAC
	private void CJIFEQFKPIM()
	{
		if (this.KEJQDPGPKBM == null)
		{
			return;
		}
		List<InvBaseItem> mkhifdnefbd = QJFLHFDQNPN.FNCJDMODFGC()[0].MKHIFDNEFBD;
		if (mkhifdnefbd.Count == 0)
		{
			return;
		}
		int num = UnityEngine.Random.Range(0, mkhifdnefbd.Count);
		InvBaseItem invBaseItem = mkhifdnefbd[num];
		InvGameItem invGameItem = new InvGameItem(num, invBaseItem);
		invGameItem.quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(0, -31);
		invGameItem.itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
		this.KEJQDPGPKBM.CFFIKHGQDGP(invGameItem);
	}

	// Token: 0x0600053A RID: 1338 RVA: 0x0004CB34 File Offset: 0x0004AD34
	private void OIFHQPQKEFF()
	{
		if (this.KEJQDPGPKBM == null)
		{
			return;
		}
		List<InvBaseItem> mkhifdnefbd = QJFLHFDQNPN.NJPHFKFPDPQ()[0].MKHIFDNEFBD;
		if (mkhifdnefbd.Count == 0)
		{
			return;
		}
		int num = UnityEngine.Random.Range(1, mkhifdnefbd.Count);
		InvBaseItem invBaseItem = mkhifdnefbd[num];
		InvGameItem invGameItem = new InvGameItem(num, invBaseItem);
		invGameItem.quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(0, -12);
		invGameItem.itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
		this.KEJQDPGPKBM.CQCFMJMFELN(invGameItem);
	}

	// Token: 0x0600053B RID: 1339 RVA: 0x0004CBBC File Offset: 0x0004ADBC
	private void JKCPMBPBDCH()
	{
		if (this.KEJQDPGPKBM == null)
		{
			return;
		}
		List<InvBaseItem> mkhifdnefbd = QJFLHFDQNPN.BBBCFDQHLEQ()[1].MKHIFDNEFBD;
		if (mkhifdnefbd.Count == 0)
		{
			return;
		}
		int num = UnityEngine.Random.Range(1, mkhifdnefbd.Count);
		InvBaseItem invBaseItem = mkhifdnefbd[num];
		InvGameItem invGameItem = new InvGameItem(num, invBaseItem);
		invGameItem.quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(1, -79);
		invGameItem.itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
		this.KEJQDPGPKBM.ODDDIPBOCGL(invGameItem);
	}

	// Token: 0x0600053C RID: 1340 RVA: 0x0004CC44 File Offset: 0x0004AE44
	private void JMLMNQIHQBJ()
	{
		if (this.KEJQDPGPKBM == null)
		{
			return;
		}
		List<InvBaseItem> mkhifdnefbd = QJFLHFDQNPN.NGDBDCQFDHI[1].MKHIFDNEFBD;
		if (mkhifdnefbd.Count == 0)
		{
			return;
		}
		int num = UnityEngine.Random.Range(1, mkhifdnefbd.Count);
		InvBaseItem invBaseItem = mkhifdnefbd[num];
		InvGameItem invGameItem = new InvGameItem(num, invBaseItem);
		invGameItem.quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(1, 3);
		invGameItem.itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
		this.KEJQDPGPKBM.NPGCQDMEENC(invGameItem);
	}

	// Token: 0x0600053D RID: 1341 RVA: 0x0004CCC8 File Offset: 0x0004AEC8
	private void DNLLCMHCHMJ()
	{
		if (this.KEJQDPGPKBM == null)
		{
			return;
		}
		List<InvBaseItem> mkhifdnefbd = QJFLHFDQNPN.BBBCFDQHLEQ()[1].MKHIFDNEFBD;
		if (mkhifdnefbd.Count == 0)
		{
			return;
		}
		int num = UnityEngine.Random.Range(1, mkhifdnefbd.Count);
		InvBaseItem invBaseItem = mkhifdnefbd[num];
		InvGameItem invGameItem = new InvGameItem(num, invBaseItem);
		invGameItem.quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(0, 38);
		invGameItem.itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
		this.KEJQDPGPKBM.CQCFMJMFELN(invGameItem);
	}

	// Token: 0x0600053E RID: 1342 RVA: 0x0004CD50 File Offset: 0x0004AF50
	private void MNCOKCFNDHB()
	{
		if (this.KEJQDPGPKBM == null)
		{
			return;
		}
		List<InvBaseItem> mkhifdnefbd = QJFLHFDQNPN.BBHEKMJMBGL()[1].MKHIFDNEFBD;
		if (mkhifdnefbd.Count == 0)
		{
			return;
		}
		int num = UnityEngine.Random.Range(0, mkhifdnefbd.Count);
		InvBaseItem invBaseItem = mkhifdnefbd[num];
		InvGameItem invGameItem = new InvGameItem(num, invBaseItem);
		invGameItem.quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(0, -27);
		invGameItem.itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
		this.KEJQDPGPKBM.CQCFMJMFELN(invGameItem);
	}

	// Token: 0x0600053F RID: 1343 RVA: 0x0004CDD8 File Offset: 0x0004AFD8
	private void ELMMBCJCEOB()
	{
		if (this.KEJQDPGPKBM == null)
		{
			return;
		}
		List<InvBaseItem> mkhifdnefbd = QJFLHFDQNPN.NJPHFKFPDPQ()[0].MKHIFDNEFBD;
		if (mkhifdnefbd.Count == 0)
		{
			return;
		}
		int num = UnityEngine.Random.Range(0, mkhifdnefbd.Count);
		InvBaseItem invBaseItem = mkhifdnefbd[num];
		InvGameItem invGameItem = new InvGameItem(num, invBaseItem);
		invGameItem.quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(0, 70);
		invGameItem.itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
		this.KEJQDPGPKBM.CFFIKHGQDGP(invGameItem);
	}

	// Token: 0x040000A5 RID: 165
	public QFEIBBLLDQE KEJQDPGPKBM;
}
