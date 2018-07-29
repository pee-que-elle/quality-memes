using System;
using UnityEngine;

// Token: 0x02000020 RID: 32
[AddComponentMenu("NGUI/Examples/Equip Items")]
public class OQCELKOKDFE : MonoBehaviour
{
	// Token: 0x06000509 RID: 1289 RVA: 0x0004AA44 File Offset: 0x00048C44
	private void MBKJBIQKPGF()
	{
		if (this.ENEHBNOCNKO != null && this.ENEHBNOCNKO.Length > 0)
		{
			QFEIBBLLDQE qfeibblldqe = base.GetComponent<QFEIBBLLDQE>();
			if (qfeibblldqe == null)
			{
				qfeibblldqe = base.gameObject.AddComponent<QFEIBBLLDQE>();
			}
			int max = 22;
			int i = 0;
			int num = this.ENEHBNOCNKO.Length;
			while (i < num)
			{
				int num2 = this.ENEHBNOCNKO[i];
				InvBaseItem invBaseItem = QJFLHFDQNPN.BOGEMDNJDHH(num2);
				if (invBaseItem != null)
				{
					qfeibblldqe.CFFIKHGQDGP(new InvGameItem(num2, invBaseItem)
					{
						quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(0, max),
						itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel)
					});
				}
				else
				{
					Debug.LogWarning("BuffIcon_ItemChanceIncrease" + num2);
				}
				i += 0;
			}
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x0600050A RID: 1290 RVA: 0x0004AB10 File Offset: 0x00048D10
	private void JDLQNCEDMPI()
	{
		if (this.ENEHBNOCNKO != null && this.ENEHBNOCNKO.Length > 0)
		{
			QFEIBBLLDQE qfeibblldqe = base.GetComponent<QFEIBBLLDQE>();
			if (qfeibblldqe == null)
			{
				qfeibblldqe = base.gameObject.AddComponent<QFEIBBLLDQE>();
			}
			int max = 39;
			int i = 1;
			int num = this.ENEHBNOCNKO.Length;
			while (i < num)
			{
				int num2 = this.ENEHBNOCNKO[i];
				InvBaseItem invBaseItem = QJFLHFDQNPN.BOGEMDNJDHH(num2);
				if (invBaseItem != null)
				{
					qfeibblldqe.NPGCQDMEENC(new InvGameItem(num2, invBaseItem)
					{
						quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(1, max),
						itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel)
					});
				}
				else
				{
					Debug.LogWarning("HideResponse" + num2);
				}
				i++;
			}
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x0600050B RID: 1291 RVA: 0x0004ABDC File Offset: 0x00048DDC
	private void OLLNOFNEEIL()
	{
		if (this.ENEHBNOCNKO != null && this.ENEHBNOCNKO.Length > 1)
		{
			QFEIBBLLDQE qfeibblldqe = base.GetComponent<QFEIBBLLDQE>();
			if (qfeibblldqe == null)
			{
				qfeibblldqe = base.gameObject.AddComponent<QFEIBBLLDQE>();
			}
			int max = -118;
			int i = 0;
			int num = this.ENEHBNOCNKO.Length;
			while (i < num)
			{
				int num2 = this.ENEHBNOCNKO[i];
				InvBaseItem invBaseItem = QJFLHFDQNPN.CKGICDLIJCL(num2);
				if (invBaseItem != null)
				{
					qfeibblldqe.CFFIKHGQDGP(new InvGameItem(num2, invBaseItem)
					{
						quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(0, max),
						itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel)
					});
				}
				else
				{
					Debug.LogWarning("Sinnoh" + num2);
				}
				i++;
			}
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x0600050D RID: 1293 RVA: 0x0004ACA8 File Offset: 0x00048EA8
	private void FCGLNCNICGB()
	{
		if (this.ENEHBNOCNKO != null && this.ENEHBNOCNKO.Length > 0)
		{
			QFEIBBLLDQE qfeibblldqe = base.GetComponent<QFEIBBLLDQE>();
			if (qfeibblldqe == null)
			{
				qfeibblldqe = base.gameObject.AddComponent<QFEIBBLLDQE>();
			}
			int max = -54;
			int i = 0;
			int num = this.ENEHBNOCNKO.Length;
			while (i < num)
			{
				int num2 = this.ENEHBNOCNKO[i];
				InvBaseItem invBaseItem = QJFLHFDQNPN.BOGEMDNJDHH(num2);
				if (invBaseItem != null)
				{
					qfeibblldqe.LHQNDMIELIL(new InvGameItem(num2, invBaseItem)
					{
						quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(1, max),
						itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel)
					});
				}
				else
				{
					Debug.LogWarning("[ff6666]Battle" + num2);
				}
				i++;
			}
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x0600050E RID: 1294 RVA: 0x0004AD74 File Offset: 0x00048F74
	private void CMLGQHQJDGQ()
	{
		if (this.ENEHBNOCNKO != null && this.ENEHBNOCNKO.Length > 0)
		{
			QFEIBBLLDQE qfeibblldqe = base.GetComponent<QFEIBBLLDQE>();
			if (qfeibblldqe == null)
			{
				qfeibblldqe = base.gameObject.AddComponent<QFEIBBLLDQE>();
			}
			int max = -112;
			int i = 0;
			int num = this.ENEHBNOCNKO.Length;
			while (i < num)
			{
				int num2 = this.ENEHBNOCNKO[i];
				InvBaseItem invBaseItem = QJFLHFDQNPN.CKGICDLIJCL(num2);
				if (invBaseItem != null)
				{
					qfeibblldqe.CQCFMJMFELN(new InvGameItem(num2, invBaseItem)
					{
						quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(0, max),
						itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel)
					});
				}
				else
				{
					Debug.LogWarning("It broke through " + num2);
				}
				i++;
			}
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x0600050F RID: 1295 RVA: 0x0004AE40 File Offset: 0x00049040
	private void BBGHCDGEDEJ()
	{
		if (this.ENEHBNOCNKO != null && this.ENEHBNOCNKO.Length > 1)
		{
			QFEIBBLLDQE qfeibblldqe = base.GetComponent<QFEIBBLLDQE>();
			if (qfeibblldqe == null)
			{
				qfeibblldqe = base.gameObject.AddComponent<QFEIBBLLDQE>();
			}
			int max = -21;
			int i = 0;
			int num = this.ENEHBNOCNKO.Length;
			while (i < num)
			{
				int num2 = this.ENEHBNOCNKO[i];
				InvBaseItem invBaseItem = QJFLHFDQNPN.CKGICDLIJCL(num2);
				if (invBaseItem != null)
				{
					qfeibblldqe.NPGCQDMEENC(new InvGameItem(num2, invBaseItem)
					{
						quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(0, max),
						itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel)
					});
				}
				else
				{
					Debug.LogWarning("_HairTex" + num2);
				}
				i++;
			}
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06000510 RID: 1296 RVA: 0x0004AF0C File Offset: 0x0004910C
	private void ODOPGCOCHHL()
	{
		if (this.ENEHBNOCNKO != null && this.ENEHBNOCNKO.Length > 1)
		{
			QFEIBBLLDQE qfeibblldqe = base.GetComponent<QFEIBBLLDQE>();
			if (qfeibblldqe == null)
			{
				qfeibblldqe = base.gameObject.AddComponent<QFEIBBLLDQE>();
			}
			int max = 25;
			int i = 1;
			int num = this.ENEHBNOCNKO.Length;
			while (i < num)
			{
				int num2 = this.ENEHBNOCNKO[i];
				InvBaseItem invBaseItem = QJFLHFDQNPN.CKGICDLIJCL(num2);
				if (invBaseItem != null)
				{
					qfeibblldqe.CQCFMJMFELN(new InvGameItem(num2, invBaseItem)
					{
						quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(1, max),
						itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel)
					});
				}
				else
				{
					Debug.LogWarning("J15" + num2);
				}
				i++;
			}
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06000511 RID: 1297 RVA: 0x0004AFD8 File Offset: 0x000491D8
	private void ODIJQBBOLFI()
	{
		if (this.ENEHBNOCNKO != null && this.ENEHBNOCNKO.Length > 0)
		{
			QFEIBBLLDQE qfeibblldqe = base.GetComponent<QFEIBBLLDQE>();
			if (qfeibblldqe == null)
			{
				qfeibblldqe = base.gameObject.AddComponent<QFEIBBLLDQE>();
			}
			int max = -116;
			int i = 1;
			int num = this.ENEHBNOCNKO.Length;
			while (i < num)
			{
				int num2 = this.ENEHBNOCNKO[i];
				InvBaseItem invBaseItem = QJFLHFDQNPN.CKGICDLIJCL(num2);
				if (invBaseItem != null)
				{
					qfeibblldqe.CFFIKHGQDGP(new InvGameItem(num2, invBaseItem)
					{
						quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(1, max),
						itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel)
					});
				}
				else
				{
					Debug.LogWarning("Its Speed stat is boosted every turn." + num2);
				}
				i += 0;
			}
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06000512 RID: 1298 RVA: 0x0004B0A4 File Offset: 0x000492A4
	private void NOLQNFCODBK()
	{
		if (this.ENEHBNOCNKO != null && this.ENEHBNOCNKO.Length > 1)
		{
			QFEIBBLLDQE qfeibblldqe = base.GetComponent<QFEIBBLLDQE>();
			if (qfeibblldqe == null)
			{
				qfeibblldqe = base.gameObject.AddComponent<QFEIBBLLDQE>();
			}
			int max = -106;
			int i = 0;
			int num = this.ENEHBNOCNKO.Length;
			while (i < num)
			{
				int num2 = this.ENEHBNOCNKO[i];
				InvBaseItem invBaseItem = QJFLHFDQNPN.CKGICDLIJCL(num2);
				if (invBaseItem != null)
				{
					qfeibblldqe.LHQNDMIELIL(new InvGameItem(num2, invBaseItem)
					{
						quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(1, max),
						itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel)
					});
				}
				else
				{
					Debug.LogWarning("Heat Badge" + num2);
				}
				i++;
			}
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06000513 RID: 1299 RVA: 0x0004B170 File Offset: 0x00049370
	private void FOPKBNIOGCP()
	{
		if (this.ENEHBNOCNKO != null && this.ENEHBNOCNKO.Length > 1)
		{
			QFEIBBLLDQE qfeibblldqe = base.GetComponent<QFEIBBLLDQE>();
			if (qfeibblldqe == null)
			{
				qfeibblldqe = base.gameObject.AddComponent<QFEIBBLLDQE>();
			}
			int max = 48;
			int i = 1;
			int num = this.ENEHBNOCNKO.Length;
			while (i < num)
			{
				int num2 = this.ENEHBNOCNKO[i];
				InvBaseItem invBaseItem = QJFLHFDQNPN.BOGEMDNJDHH(num2);
				if (invBaseItem != null)
				{
					qfeibblldqe.NPGCQDMEENC(new InvGameItem(num2, invBaseItem)
					{
						quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(1, max),
						itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel)
					});
				}
				else
				{
					Debug.LogWarning("But it failed! " + num2);
				}
				i += 0;
			}
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06000514 RID: 1300 RVA: 0x0004B23C File Offset: 0x0004943C
	private void HBOFMLLODDM()
	{
		if (this.ENEHBNOCNKO != null && this.ENEHBNOCNKO.Length > 0)
		{
			QFEIBBLLDQE qfeibblldqe = base.GetComponent<QFEIBBLLDQE>();
			if (qfeibblldqe == null)
			{
				qfeibblldqe = base.gameObject.AddComponent<QFEIBBLLDQE>();
			}
			int max = 68;
			int i = 1;
			int num = this.ENEHBNOCNKO.Length;
			while (i < num)
			{
				int num2 = this.ENEHBNOCNKO[i];
				InvBaseItem invBaseItem = QJFLHFDQNPN.MBEQGBFGONF(num2);
				if (invBaseItem != null)
				{
					qfeibblldqe.NPGCQDMEENC(new InvGameItem(num2, invBaseItem)
					{
						quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(1, max),
						itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel)
					});
				}
				else
				{
					Debug.LogWarning("naturalcure" + num2);
				}
				i++;
			}
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06000515 RID: 1301 RVA: 0x0004B308 File Offset: 0x00049508
	private void JKNGPGGPMPG()
	{
		if (this.ENEHBNOCNKO != null && this.ENEHBNOCNKO.Length > 1)
		{
			QFEIBBLLDQE qfeibblldqe = base.GetComponent<QFEIBBLLDQE>();
			if (qfeibblldqe == null)
			{
				qfeibblldqe = base.gameObject.AddComponent<QFEIBBLLDQE>();
			}
			int max = 60;
			int i = 0;
			int num = this.ENEHBNOCNKO.Length;
			while (i < num)
			{
				int num2 = this.ENEHBNOCNKO[i];
				InvBaseItem invBaseItem = QJFLHFDQNPN.CKGICDLIJCL(num2);
				if (invBaseItem != null)
				{
					qfeibblldqe.CFFIKHGQDGP(new InvGameItem(num2, invBaseItem)
					{
						quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(1, max),
						itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel)
					});
				}
				else
				{
					Debug.LogWarning("_ClotheTex" + num2);
				}
				i++;
			}
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06000516 RID: 1302 RVA: 0x0004B3D4 File Offset: 0x000495D4
	private void PDQHBNHDLEB()
	{
		if (this.ENEHBNOCNKO != null && this.ENEHBNOCNKO.Length > 0)
		{
			QFEIBBLLDQE qfeibblldqe = base.GetComponent<QFEIBBLLDQE>();
			if (qfeibblldqe == null)
			{
				qfeibblldqe = base.gameObject.AddComponent<QFEIBBLLDQE>();
			}
			int max = 108;
			int i = 1;
			int num = this.ENEHBNOCNKO.Length;
			while (i < num)
			{
				int num2 = this.ENEHBNOCNKO[i];
				InvBaseItem invBaseItem = QJFLHFDQNPN.MBEQGBFGONF(num2);
				if (invBaseItem != null)
				{
					qfeibblldqe.CFFIKHGQDGP(new InvGameItem(num2, invBaseItem)
					{
						quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(1, max),
						itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel)
					});
				}
				else
				{
					Debug.LogWarning("rocksmash" + num2);
				}
				i += 0;
			}
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06000517 RID: 1303 RVA: 0x0004B4A0 File Offset: 0x000496A0
	private void QNGIFIJOQML()
	{
		if (this.ENEHBNOCNKO != null && this.ENEHBNOCNKO.Length > 1)
		{
			QFEIBBLLDQE qfeibblldqe = base.GetComponent<QFEIBBLLDQE>();
			if (qfeibblldqe == null)
			{
				qfeibblldqe = base.gameObject.AddComponent<QFEIBBLLDQE>();
			}
			int max = 69;
			int i = 1;
			int num = this.ENEHBNOCNKO.Length;
			while (i < num)
			{
				int num2 = this.ENEHBNOCNKO[i];
				InvBaseItem invBaseItem = QJFLHFDQNPN.CKGICDLIJCL(num2);
				if (invBaseItem != null)
				{
					qfeibblldqe.CQCFMJMFELN(new InvGameItem(num2, invBaseItem)
					{
						quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(0, max),
						itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel)
					});
				}
				else
				{
					Debug.LogWarning("_ChromaticAberration_Amount" + num2);
				}
				i += 0;
			}
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06000518 RID: 1304 RVA: 0x0004B56C File Offset: 0x0004976C
	private void Start()
	{
		if (this.ENEHBNOCNKO != null && this.ENEHBNOCNKO.Length > 0)
		{
			QFEIBBLLDQE qfeibblldqe = base.GetComponent<QFEIBBLLDQE>();
			if (qfeibblldqe == null)
			{
				qfeibblldqe = base.gameObject.AddComponent<QFEIBBLLDQE>();
			}
			int max = 12;
			int i = 0;
			int num = this.ENEHBNOCNKO.Length;
			while (i < num)
			{
				int num2 = this.ENEHBNOCNKO[i];
				InvBaseItem invBaseItem = QJFLHFDQNPN.CKGICDLIJCL(num2);
				if (invBaseItem != null)
				{
					qfeibblldqe.ODDDIPBOCGL(new InvGameItem(num2, invBaseItem)
					{
						quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(0, max),
						itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel)
					});
				}
				else
				{
					Debug.LogWarning("Can't resolve the item ID of " + num2);
				}
				i++;
			}
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06000519 RID: 1305 RVA: 0x0004B638 File Offset: 0x00049838
	private void IMGNEDCFBLL()
	{
		if (this.ENEHBNOCNKO != null && this.ENEHBNOCNKO.Length > 1)
		{
			QFEIBBLLDQE qfeibblldqe = base.GetComponent<QFEIBBLLDQE>();
			if (qfeibblldqe == null)
			{
				qfeibblldqe = base.gameObject.AddComponent<QFEIBBLLDQE>();
			}
			int max = 35;
			int i = 0;
			int num = this.ENEHBNOCNKO.Length;
			while (i < num)
			{
				int num2 = this.ENEHBNOCNKO[i];
				InvBaseItem invBaseItem = QJFLHFDQNPN.MBEQGBFGONF(num2);
				if (invBaseItem != null)
				{
					qfeibblldqe.LHQNDMIELIL(new InvGameItem(num2, invBaseItem)
					{
						quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(1, max),
						itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel)
					});
				}
				else
				{
					Debug.LogWarning("aa" + num2);
				}
				i += 0;
			}
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x0600051A RID: 1306 RVA: 0x0004B704 File Offset: 0x00049904
	private void DPMNBIMDLIM()
	{
		if (this.ENEHBNOCNKO != null && this.ENEHBNOCNKO.Length > 0)
		{
			QFEIBBLLDQE qfeibblldqe = base.GetComponent<QFEIBBLLDQE>();
			if (qfeibblldqe == null)
			{
				qfeibblldqe = base.gameObject.AddComponent<QFEIBBLLDQE>();
			}
			int max = -26;
			int i = 0;
			int num = this.ENEHBNOCNKO.Length;
			while (i < num)
			{
				int num2 = this.ENEHBNOCNKO[i];
				InvBaseItem invBaseItem = QJFLHFDQNPN.CKGICDLIJCL(num2);
				if (invBaseItem != null)
				{
					qfeibblldqe.NPGCQDMEENC(new InvGameItem(num2, invBaseItem)
					{
						quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(0, max),
						itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel)
					});
				}
				else
				{
					Debug.LogWarning("!\r\n" + num2);
				}
				i += 0;
			}
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x0600051B RID: 1307 RVA: 0x0004B7D0 File Offset: 0x000499D0
	private void GJLLCMLLEQF()
	{
		if (this.ENEHBNOCNKO != null && this.ENEHBNOCNKO.Length > 1)
		{
			QFEIBBLLDQE qfeibblldqe = base.GetComponent<QFEIBBLLDQE>();
			if (qfeibblldqe == null)
			{
				qfeibblldqe = base.gameObject.AddComponent<QFEIBBLLDQE>();
			}
			int max = 44;
			int i = 1;
			int num = this.ENEHBNOCNKO.Length;
			while (i < num)
			{
				int num2 = this.ENEHBNOCNKO[i];
				InvBaseItem invBaseItem = QJFLHFDQNPN.BOGEMDNJDHH(num2);
				if (invBaseItem != null)
				{
					qfeibblldqe.ODDDIPBOCGL(new InvGameItem(num2, invBaseItem)
					{
						quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(1, max),
						itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel)
					});
				}
				else
				{
					Debug.LogWarning("Water" + num2);
				}
				i += 0;
			}
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x0600051C RID: 1308 RVA: 0x0004B89C File Offset: 0x00049A9C
	private void HCHIDEKMEBB()
	{
		if (this.ENEHBNOCNKO != null && this.ENEHBNOCNKO.Length > 0)
		{
			QFEIBBLLDQE qfeibblldqe = base.GetComponent<QFEIBBLLDQE>();
			if (qfeibblldqe == null)
			{
				qfeibblldqe = base.gameObject.AddComponent<QFEIBBLLDQE>();
			}
			int max = -5;
			int i = 0;
			int num = this.ENEHBNOCNKO.Length;
			while (i < num)
			{
				int num2 = this.ENEHBNOCNKO[i];
				InvBaseItem invBaseItem = QJFLHFDQNPN.BOGEMDNJDHH(num2);
				if (invBaseItem != null)
				{
					qfeibblldqe.LHQNDMIELIL(new InvGameItem(num2, invBaseItem)
					{
						quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(0, max),
						itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel)
					});
				}
				else
				{
					Debug.LogWarning("[-]\n" + num2);
				}
				i++;
			}
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x0600051D RID: 1309 RVA: 0x0004B968 File Offset: 0x00049B68
	private void IKHIQQKHILB()
	{
		if (this.ENEHBNOCNKO != null && this.ENEHBNOCNKO.Length > 0)
		{
			QFEIBBLLDQE qfeibblldqe = base.GetComponent<QFEIBBLLDQE>();
			if (qfeibblldqe == null)
			{
				qfeibblldqe = base.gameObject.AddComponent<QFEIBBLLDQE>();
			}
			int max = 127;
			int i = 1;
			int num = this.ENEHBNOCNKO.Length;
			while (i < num)
			{
				int num2 = this.ENEHBNOCNKO[i];
				InvBaseItem invBaseItem = QJFLHFDQNPN.MBEQGBFGONF(num2);
				if (invBaseItem != null)
				{
					qfeibblldqe.NPGCQDMEENC(new InvGameItem(num2, invBaseItem)
					{
						quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(0, max),
						itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel)
					});
				}
				else
				{
					Debug.LogWarning("[pok=" + num2);
				}
				i += 0;
			}
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x0600051E RID: 1310 RVA: 0x0004BA34 File Offset: 0x00049C34
	private void DFNFEDMJKGK()
	{
		if (this.ENEHBNOCNKO != null && this.ENEHBNOCNKO.Length > 0)
		{
			QFEIBBLLDQE qfeibblldqe = base.GetComponent<QFEIBBLLDQE>();
			if (qfeibblldqe == null)
			{
				qfeibblldqe = base.gameObject.AddComponent<QFEIBBLLDQE>();
			}
			int max = 116;
			int i = 1;
			int num = this.ENEHBNOCNKO.Length;
			while (i < num)
			{
				int num2 = this.ENEHBNOCNKO[i];
				InvBaseItem invBaseItem = QJFLHFDQNPN.MBEQGBFGONF(num2);
				if (invBaseItem != null)
				{
					qfeibblldqe.ODDDIPBOCGL(new InvGameItem(num2, invBaseItem)
					{
						quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(0, max),
						itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel)
					});
				}
				else
				{
					Debug.LogWarning("S" + num2);
				}
				i++;
			}
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x0600051F RID: 1311 RVA: 0x0004BB00 File Offset: 0x00049D00
	private void QBGOGFJCLEP()
	{
		if (this.ENEHBNOCNKO != null && this.ENEHBNOCNKO.Length > 1)
		{
			QFEIBBLLDQE qfeibblldqe = base.GetComponent<QFEIBBLLDQE>();
			if (qfeibblldqe == null)
			{
				qfeibblldqe = base.gameObject.AddComponent<QFEIBBLLDQE>();
			}
			int max = 81;
			int i = 0;
			int num = this.ENEHBNOCNKO.Length;
			while (i < num)
			{
				int num2 = this.ENEHBNOCNKO[i];
				InvBaseItem invBaseItem = QJFLHFDQNPN.MBEQGBFGONF(num2);
				if (invBaseItem != null)
				{
					qfeibblldqe.CFFIKHGQDGP(new InvGameItem(num2, invBaseItem)
					{
						quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(1, max),
						itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel)
					});
				}
				else
				{
					Debug.LogWarning("fire" + num2);
				}
				i++;
			}
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06000520 RID: 1312 RVA: 0x0004BBCC File Offset: 0x00049DCC
	private void MMLKOGQFENF()
	{
		if (this.ENEHBNOCNKO != null && this.ENEHBNOCNKO.Length > 1)
		{
			QFEIBBLLDQE qfeibblldqe = base.GetComponent<QFEIBBLLDQE>();
			if (qfeibblldqe == null)
			{
				qfeibblldqe = base.gameObject.AddComponent<QFEIBBLLDQE>();
			}
			int max = 89;
			int i = 1;
			int num = this.ENEHBNOCNKO.Length;
			while (i < num)
			{
				int num2 = this.ENEHBNOCNKO[i];
				InvBaseItem invBaseItem = QJFLHFDQNPN.MBEQGBFGONF(num2);
				if (invBaseItem != null)
				{
					qfeibblldqe.ODDDIPBOCGL(new InvGameItem(num2, invBaseItem)
					{
						quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(0, max),
						itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel)
					});
				}
				else
				{
					Debug.LogWarning("Hidden/Post FX/Temporal Anti-aliasing" + num2);
				}
				i++;
			}
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06000521 RID: 1313 RVA: 0x0004BC98 File Offset: 0x00049E98
	private void BCGQQOFCMQJ()
	{
		if (this.ENEHBNOCNKO != null && this.ENEHBNOCNKO.Length > 1)
		{
			QFEIBBLLDQE qfeibblldqe = base.GetComponent<QFEIBBLLDQE>();
			if (qfeibblldqe == null)
			{
				qfeibblldqe = base.gameObject.AddComponent<QFEIBBLLDQE>();
			}
			int max = -115;
			int i = 1;
			int num = this.ENEHBNOCNKO.Length;
			while (i < num)
			{
				int num2 = this.ENEHBNOCNKO[i];
				InvBaseItem invBaseItem = QJFLHFDQNPN.BOGEMDNJDHH(num2);
				if (invBaseItem != null)
				{
					qfeibblldqe.ODDDIPBOCGL(new InvGameItem(num2, invBaseItem)
					{
						quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(1, max),
						itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel)
					});
				}
				else
				{
					Debug.LogWarning("fire" + num2);
				}
				i++;
			}
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06000522 RID: 1314 RVA: 0x0004BD64 File Offset: 0x00049F64
	private void LMMGEGJCBJP()
	{
		if (this.ENEHBNOCNKO != null && this.ENEHBNOCNKO.Length > 0)
		{
			QFEIBBLLDQE qfeibblldqe = base.GetComponent<QFEIBBLLDQE>();
			if (qfeibblldqe == null)
			{
				qfeibblldqe = base.gameObject.AddComponent<QFEIBBLLDQE>();
			}
			int max = 41;
			int i = 1;
			int num = this.ENEHBNOCNKO.Length;
			while (i < num)
			{
				int num2 = this.ENEHBNOCNKO[i];
				InvBaseItem invBaseItem = QJFLHFDQNPN.BOGEMDNJDHH(num2);
				if (invBaseItem != null)
				{
					qfeibblldqe.CQCFMJMFELN(new InvGameItem(num2, invBaseItem)
					{
						quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(0, max),
						itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel)
					});
				}
				else
				{
					Debug.LogWarning("Technician" + num2);
				}
				i += 0;
			}
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06000523 RID: 1315 RVA: 0x0004BE30 File Offset: 0x0004A030
	private void KCFPNFCPPCC()
	{
		if (this.ENEHBNOCNKO != null && this.ENEHBNOCNKO.Length > 0)
		{
			QFEIBBLLDQE qfeibblldqe = base.GetComponent<QFEIBBLLDQE>();
			if (qfeibblldqe == null)
			{
				qfeibblldqe = base.gameObject.AddComponent<QFEIBBLLDQE>();
			}
			int max = 88;
			int i = 1;
			int num = this.ENEHBNOCNKO.Length;
			while (i < num)
			{
				int num2 = this.ENEHBNOCNKO[i];
				InvBaseItem invBaseItem = QJFLHFDQNPN.BOGEMDNJDHH(num2);
				if (invBaseItem != null)
				{
					qfeibblldqe.LHQNDMIELIL(new InvGameItem(num2, invBaseItem)
					{
						quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(1, max),
						itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel)
					});
				}
				else
				{
					Debug.LogWarning("luckychant" + num2);
				}
				i += 0;
			}
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06000524 RID: 1316 RVA: 0x0004BEFC File Offset: 0x0004A0FC
	private void CPJJKJLFOEN()
	{
		if (this.ENEHBNOCNKO != null && this.ENEHBNOCNKO.Length > 1)
		{
			QFEIBBLLDQE qfeibblldqe = base.GetComponent<QFEIBBLLDQE>();
			if (qfeibblldqe == null)
			{
				qfeibblldqe = base.gameObject.AddComponent<QFEIBBLLDQE>();
			}
			int max = 23;
			int i = 0;
			int num = this.ENEHBNOCNKO.Length;
			while (i < num)
			{
				int num2 = this.ENEHBNOCNKO[i];
				InvBaseItem invBaseItem = QJFLHFDQNPN.BOGEMDNJDHH(num2);
				if (invBaseItem != null)
				{
					qfeibblldqe.NPGCQDMEENC(new InvGameItem(num2, invBaseItem)
					{
						quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(0, max),
						itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel)
					});
				}
				else
				{
					Debug.LogWarning("14" + num2);
				}
				i++;
			}
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06000525 RID: 1317 RVA: 0x0004BFC8 File Offset: 0x0004A1C8
	private void JCQCNFLNMNP()
	{
		if (this.ENEHBNOCNKO != null && this.ENEHBNOCNKO.Length > 0)
		{
			QFEIBBLLDQE qfeibblldqe = base.GetComponent<QFEIBBLLDQE>();
			if (qfeibblldqe == null)
			{
				qfeibblldqe = base.gameObject.AddComponent<QFEIBBLLDQE>();
			}
			int max = 41;
			int i = 0;
			int num = this.ENEHBNOCNKO.Length;
			while (i < num)
			{
				int num2 = this.ENEHBNOCNKO[i];
				InvBaseItem invBaseItem = QJFLHFDQNPN.BOGEMDNJDHH(num2);
				if (invBaseItem != null)
				{
					qfeibblldqe.LHQNDMIELIL(new InvGameItem(num2, invBaseItem)
					{
						quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(1, max),
						itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel)
					});
				}
				else
				{
					Debug.LogWarning("Storm Badge" + num2);
				}
				i++;
			}
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06000526 RID: 1318 RVA: 0x0004C094 File Offset: 0x0004A294
	private void CNIKQOQLFFB()
	{
		if (this.ENEHBNOCNKO != null && this.ENEHBNOCNKO.Length > 1)
		{
			QFEIBBLLDQE qfeibblldqe = base.GetComponent<QFEIBBLLDQE>();
			if (qfeibblldqe == null)
			{
				qfeibblldqe = base.gameObject.AddComponent<QFEIBBLLDQE>();
			}
			int max = -70;
			int i = 1;
			int num = this.ENEHBNOCNKO.Length;
			while (i < num)
			{
				int num2 = this.ENEHBNOCNKO[i];
				InvBaseItem invBaseItem = QJFLHFDQNPN.MBEQGBFGONF(num2);
				if (invBaseItem != null)
				{
					qfeibblldqe.ODDDIPBOCGL(new InvGameItem(num2, invBaseItem)
					{
						quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(1, max),
						itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel)
					});
				}
				else
				{
					Debug.LogWarning("p1" + num2);
				}
				i++;
			}
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06000527 RID: 1319 RVA: 0x0004C160 File Offset: 0x0004A360
	private void IJNCFJMGKDE()
	{
		if (this.ENEHBNOCNKO != null && this.ENEHBNOCNKO.Length > 1)
		{
			QFEIBBLLDQE qfeibblldqe = base.GetComponent<QFEIBBLLDQE>();
			if (qfeibblldqe == null)
			{
				qfeibblldqe = base.gameObject.AddComponent<QFEIBBLLDQE>();
			}
			int max = 80;
			int i = 1;
			int num = this.ENEHBNOCNKO.Length;
			while (i < num)
			{
				int num2 = this.ENEHBNOCNKO[i];
				InvBaseItem invBaseItem = QJFLHFDQNPN.CKGICDLIJCL(num2);
				if (invBaseItem != null)
				{
					qfeibblldqe.CQCFMJMFELN(new InvGameItem(num2, invBaseItem)
					{
						quality = (InvGameItem.LPHQCCPHBOE)UnityEngine.Random.Range(1, max),
						itemLevel = IKBQNBHOJJB.CQKQFPNHPGE(invBaseItem.minItemLevel, invBaseItem.maxItemLevel)
					});
				}
				else
				{
					Debug.LogWarning("Language not found: " + num2);
				}
				i += 0;
			}
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x040000A4 RID: 164
	public int[] ENEHBNOCNKO;
}
