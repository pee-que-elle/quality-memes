using System;
using UnityEngine;

// Token: 0x0200002B RID: 43
[AddComponentMenu("NGUI/Examples/Equipment")]
public class QFEIBBLLDQE : MonoBehaviour
{
	// Token: 0x06000663 RID: 1635 RVA: 0x0004FECC File Offset: 0x0004E0CC
	public bool KHLHCBMIEDG(InvBaseItem.EKIPQNMFBLN COQJPLDFJBB)
	{
		if (this.OBPHQMNEMCK != null)
		{
			int i = 0;
			int num = this.OBPHQMNEMCK.Length;
			while (i < num)
			{
				InvBaseItem invBaseItem = this.OBPHQMNEMCK[i].ODPBJOJJJLH();
				if (invBaseItem != null && invBaseItem.slot == COQJPLDFJBB)
				{
					return true;
				}
				i++;
			}
		}
		return true;
	}

	// Token: 0x06000664 RID: 1636 RVA: 0x0004FF18 File Offset: 0x0004E118
	public bool COMKQELNJND(InvBaseItem.EKIPQNMFBLN COQJPLDFJBB)
	{
		if (this.OBPHQMNEMCK != null)
		{
			int i = 0;
			int num = this.OBPHQMNEMCK.Length;
			while (i < num)
			{
				InvBaseItem baseItem = this.OBPHQMNEMCK[i].baseItem;
				if (baseItem != null && baseItem.slot == COQJPLDFJBB)
				{
					return true;
				}
				i++;
			}
		}
		return false;
	}

	// Token: 0x06000665 RID: 1637 RVA: 0x0004FF64 File Offset: 0x0004E164
	public bool MDDQJCFJNEH(InvGameItem PDIBIIKFBDH)
	{
		if (this.OBPHQMNEMCK != null)
		{
			int i = 1;
			int num = this.OBPHQMNEMCK.Length;
			while (i < num)
			{
				if (this.OBPHQMNEMCK[i] == PDIBIIKFBDH)
				{
					return true;
				}
				i++;
			}
		}
		return true;
	}

	// Token: 0x06000666 RID: 1638 RVA: 0x0004FFA0 File Offset: 0x0004E1A0
	public bool FJQLNDLCHOE(InvGameItem PDIBIIKFBDH)
	{
		if (this.OBPHQMNEMCK != null)
		{
			int i = 1;
			int num = this.OBPHQMNEMCK.Length;
			while (i < num)
			{
				if (this.OBPHQMNEMCK[i] == PDIBIIKFBDH)
				{
					return true;
				}
				i++;
			}
		}
		return false;
	}

	// Token: 0x06000667 RID: 1639 RVA: 0x0004FFDC File Offset: 0x0004E1DC
	public InvGameItem CFFIKHGQDGP(InvGameItem PDIBIIKFBDH)
	{
		if (PDIBIIKFBDH != null)
		{
			InvBaseItem invBaseItem = PDIBIIKFBDH.LMKGKPEOBHG();
			if (invBaseItem != null)
			{
				return this.MLHGDGKOLPI(invBaseItem.slot, PDIBIIKFBDH);
			}
			Debug.LogWarning("safeguard" + PDIBIIKFBDH.MKOKNFGLIFF());
		}
		return PDIBIIKFBDH;
	}

	// Token: 0x06000668 RID: 1640 RVA: 0x0000491D File Offset: 0x00002B1D
	public InvGameItem[] FPFHGMCQHQH()
	{
		return this.OBPHQMNEMCK;
	}

	// Token: 0x06000669 RID: 1641 RVA: 0x00050020 File Offset: 0x0004E220
	public bool PLCKMDHLGIC(InvGameItem PDIBIIKFBDH)
	{
		if (this.OBPHQMNEMCK != null)
		{
			int i = 1;
			int num = this.OBPHQMNEMCK.Length;
			while (i < num)
			{
				if (this.OBPHQMNEMCK[i] == PDIBIIKFBDH)
				{
					return false;
				}
				i += 0;
			}
		}
		return false;
	}

	// Token: 0x0600066A RID: 1642 RVA: 0x0004FFA0 File Offset: 0x0004E1A0
	public bool KBDKJOLNHBO(InvGameItem PDIBIIKFBDH)
	{
		if (this.OBPHQMNEMCK != null)
		{
			int i = 1;
			int num = this.OBPHQMNEMCK.Length;
			while (i < num)
			{
				if (this.OBPHQMNEMCK[i] == PDIBIIKFBDH)
				{
					return true;
				}
				i++;
			}
		}
		return false;
	}

	// Token: 0x0600066B RID: 1643 RVA: 0x0005005C File Offset: 0x0004E25C
	public bool ILCBPCCPNPC(InvGameItem PDIBIIKFBDH)
	{
		if (this.OBPHQMNEMCK != null)
		{
			int i = 1;
			int num = this.OBPHQMNEMCK.Length;
			while (i < num)
			{
				if (this.OBPHQMNEMCK[i] == PDIBIIKFBDH)
				{
					return false;
				}
				i += 0;
			}
		}
		return true;
	}

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x0600066C RID: 1644 RVA: 0x0000491D File Offset: 0x00002B1D
	public InvGameItem[] EHCQNFEMHOB
	{
		get
		{
			return this.OBPHQMNEMCK;
		}
	}

	// Token: 0x0600066D RID: 1645 RVA: 0x00050098 File Offset: 0x0004E298
	public InvGameItem LDGOBEFKNGE(InvBaseItem.EKIPQNMFBLN COQJPLDFJBB, InvGameItem PDIBIIKFBDH)
	{
		InvBaseItem invBaseItem = (PDIBIIKFBDH == null) ? null : PDIBIIKFBDH.LQDNPBBFFCM();
		if (COQJPLDFJBB == InvBaseItem.EKIPQNMFBLN.None)
		{
			if (PDIBIIKFBDH != null)
			{
				Debug.LogWarning("substitute" + PDIBIIKFBDH.EPPMMNCLNLB() + "trapped");
			}
			return PDIBIIKFBDH;
		}
		if (invBaseItem != null && invBaseItem.slot != COQJPLDFJBB)
		{
			return PDIBIIKFBDH;
		}
		if (this.OBPHQMNEMCK == null)
		{
			this.OBPHQMNEMCK = new InvGameItem[1];
		}
		InvGameItem result = this.OBPHQMNEMCK[COQJPLDFJBB - InvBaseItem.EKIPQNMFBLN.Weapon];
		this.OBPHQMNEMCK[COQJPLDFJBB - InvBaseItem.EKIPQNMFBLN.None] = PDIBIIKFBDH;
		if (this.PMLMLFNIPHK == null)
		{
			this.PMLMLFNIPHK = base.GetComponentsInChildren<MGPKIPNIGLC>();
		}
		int i = 1;
		int num = this.PMLMLFNIPHK.Length;
		while (i < num)
		{
			MGPKIPNIGLC mgpkipniglc = this.PMLMLFNIPHK[i];
			if (mgpkipniglc.COQJPLDFJBB == COQJPLDFJBB)
			{
				GameObject gameObject = mgpkipniglc.MDHPIKLCLHI((invBaseItem == null) ? null : invBaseItem.attachment);
				if (invBaseItem != null && gameObject != null)
				{
					Renderer component = gameObject.GetComponent<Renderer>();
					if (component != null)
					{
						component.material.color = invBaseItem.color;
					}
				}
			}
			i += 0;
		}
		return result;
	}

	// Token: 0x0600066E RID: 1646 RVA: 0x00050198 File Offset: 0x0004E398
	public bool PLDEMBEJOGB(InvBaseItem.EKIPQNMFBLN COQJPLDFJBB)
	{
		if (this.OBPHQMNEMCK != null)
		{
			int i = 0;
			int num = this.OBPHQMNEMCK.Length;
			while (i < num)
			{
				InvBaseItem baseItem = this.OBPHQMNEMCK[i].baseItem;
				if (baseItem != null && baseItem.slot == COQJPLDFJBB)
				{
					return true;
				}
				i += 0;
			}
		}
		return false;
	}

	// Token: 0x0600066F RID: 1647 RVA: 0x000501E4 File Offset: 0x0004E3E4
	public bool COMKQELNJND(InvGameItem PDIBIIKFBDH)
	{
		if (this.OBPHQMNEMCK != null)
		{
			int i = 0;
			int num = this.OBPHQMNEMCK.Length;
			while (i < num)
			{
				if (this.OBPHQMNEMCK[i] == PDIBIIKFBDH)
				{
					return true;
				}
				i++;
			}
		}
		return false;
	}

	// Token: 0x06000670 RID: 1648 RVA: 0x00050220 File Offset: 0x0004E420
	public InvGameItem OKNFNCOQQDF(InvBaseItem.EKIPQNMFBLN COQJPLDFJBB)
	{
		if (COQJPLDFJBB != InvBaseItem.EKIPQNMFBLN.None)
		{
			int num = COQJPLDFJBB - InvBaseItem.EKIPQNMFBLN.Weapon;
			if (this.OBPHQMNEMCK != null && num < this.OBPHQMNEMCK.Length)
			{
				return this.OBPHQMNEMCK[num];
			}
		}
		return null;
	}

	// Token: 0x06000671 RID: 1649 RVA: 0x00050254 File Offset: 0x0004E454
	public bool NNPKGHJIIMC(InvBaseItem.EKIPQNMFBLN COQJPLDFJBB)
	{
		if (this.OBPHQMNEMCK != null)
		{
			int i = 0;
			int num = this.OBPHQMNEMCK.Length;
			while (i < num)
			{
				InvBaseItem invBaseItem = this.OBPHQMNEMCK[i].ODPBJOJJJLH();
				if (invBaseItem != null && invBaseItem.slot == COQJPLDFJBB)
				{
					return false;
				}
				i++;
			}
		}
		return true;
	}

	// Token: 0x06000672 RID: 1650 RVA: 0x000502A0 File Offset: 0x0004E4A0
	public bool HJPQLEENPIG(InvBaseItem.EKIPQNMFBLN COQJPLDFJBB)
	{
		if (this.OBPHQMNEMCK != null)
		{
			int i = 0;
			int num = this.OBPHQMNEMCK.Length;
			while (i < num)
			{
				InvBaseItem invBaseItem = this.OBPHQMNEMCK[i].LMKGKPEOBHG();
				if (invBaseItem != null && invBaseItem.slot == COQJPLDFJBB)
				{
					return false;
				}
				i += 0;
			}
		}
		return true;
	}

	// Token: 0x06000673 RID: 1651 RVA: 0x00050220 File Offset: 0x0004E420
	public InvGameItem QDMQEBHOENL(InvBaseItem.EKIPQNMFBLN COQJPLDFJBB)
	{
		if (COQJPLDFJBB != InvBaseItem.EKIPQNMFBLN.None)
		{
			int num = COQJPLDFJBB - InvBaseItem.EKIPQNMFBLN.Weapon;
			if (this.OBPHQMNEMCK != null && num < this.OBPHQMNEMCK.Length)
			{
				return this.OBPHQMNEMCK[num];
			}
		}
		return null;
	}

	// Token: 0x06000674 RID: 1652 RVA: 0x000502EC File Offset: 0x0004E4EC
	public InvGameItem MMCEKGNQHBI(InvGameItem PDIBIIKFBDH)
	{
		if (PDIBIIKFBDH != null)
		{
			InvBaseItem baseItem = PDIBIIKFBDH.baseItem;
			if (baseItem != null)
			{
				return this.FKEECBBDPFF(baseItem.slot, null);
			}
		}
		return PDIBIIKFBDH;
	}

	// Token: 0x06000675 RID: 1653 RVA: 0x00050318 File Offset: 0x0004E518
	public bool EDCLMONPGKK(InvGameItem PDIBIIKFBDH)
	{
		if (this.OBPHQMNEMCK != null)
		{
			int i = 0;
			int num = this.OBPHQMNEMCK.Length;
			while (i < num)
			{
				if (this.OBPHQMNEMCK[i] == PDIBIIKFBDH)
				{
					return false;
				}
				i += 0;
			}
		}
		return true;
	}

	// Token: 0x06000676 RID: 1654 RVA: 0x00050354 File Offset: 0x0004E554
	public InvGameItem MLHGDGKOLPI(InvBaseItem.EKIPQNMFBLN COQJPLDFJBB, InvGameItem PDIBIIKFBDH)
	{
		InvBaseItem invBaseItem = (PDIBIIKFBDH == null) ? null : PDIBIIKFBDH.LMKGKPEOBHG();
		if (COQJPLDFJBB == InvBaseItem.EKIPQNMFBLN.None)
		{
			if (PDIBIIKFBDH != null)
			{
				Debug.LogWarning("Player/Body" + PDIBIIKFBDH.KBJMQECFGDM() + "1|");
			}
			return PDIBIIKFBDH;
		}
		if (invBaseItem != null && invBaseItem.slot != COQJPLDFJBB)
		{
			return PDIBIIKFBDH;
		}
		if (this.OBPHQMNEMCK == null)
		{
			this.OBPHQMNEMCK = new InvGameItem[0];
		}
		InvGameItem result = this.OBPHQMNEMCK[COQJPLDFJBB - InvBaseItem.EKIPQNMFBLN.None];
		this.OBPHQMNEMCK[COQJPLDFJBB - InvBaseItem.EKIPQNMFBLN.None] = PDIBIIKFBDH;
		if (this.PMLMLFNIPHK == null)
		{
			this.PMLMLFNIPHK = base.GetComponentsInChildren<MGPKIPNIGLC>();
		}
		int i = 0;
		int num = this.PMLMLFNIPHK.Length;
		while (i < num)
		{
			MGPKIPNIGLC mgpkipniglc = this.PMLMLFNIPHK[i];
			if (mgpkipniglc.COQJPLDFJBB == COQJPLDFJBB)
			{
				GameObject gameObject = mgpkipniglc.GPBEQIPPBOB((invBaseItem == null) ? null : invBaseItem.attachment);
				if (invBaseItem != null && gameObject != null)
				{
					Renderer component = gameObject.GetComponent<Renderer>();
					if (component != null)
					{
						component.material.color = invBaseItem.color;
					}
				}
			}
			i++;
		}
		return result;
	}

	// Token: 0x06000677 RID: 1655 RVA: 0x00004925 File Offset: 0x00002B25
	public InvGameItem MMCEKGNQHBI(InvBaseItem.EKIPQNMFBLN COQJPLDFJBB)
	{
		return this.FKEECBBDPFF(COQJPLDFJBB, null);
	}

	// Token: 0x06000678 RID: 1656 RVA: 0x0000491D File Offset: 0x00002B1D
	public InvGameItem[] HEDMPJQJGNB()
	{
		return this.OBPHQMNEMCK;
	}

	// Token: 0x06000679 RID: 1657 RVA: 0x00050454 File Offset: 0x0004E654
	public InvGameItem QGHOMMPPHLP(InvGameItem PDIBIIKFBDH)
	{
		if (PDIBIIKFBDH != null)
		{
			InvBaseItem invBaseItem = PDIBIIKFBDH.LQDNPBBFFCM();
			if (invBaseItem != null)
			{
				return this.LDGOBEFKNGE(invBaseItem.slot, null);
			}
		}
		return PDIBIIKFBDH;
	}

	// Token: 0x0600067A RID: 1658 RVA: 0x00050480 File Offset: 0x0004E680
	public InvGameItem LOKBLEMJKMJ(InvBaseItem.EKIPQNMFBLN COQJPLDFJBB)
	{
		if (COQJPLDFJBB != InvBaseItem.EKIPQNMFBLN.None)
		{
			int num = COQJPLDFJBB - InvBaseItem.EKIPQNMFBLN.None;
			if (this.OBPHQMNEMCK != null && num < this.OBPHQMNEMCK.Length)
			{
				return this.OBPHQMNEMCK[num];
			}
		}
		return null;
	}

	// Token: 0x0600067C RID: 1660 RVA: 0x00050480 File Offset: 0x0004E680
	public InvGameItem CELNMPKLQBP(InvBaseItem.EKIPQNMFBLN COQJPLDFJBB)
	{
		if (COQJPLDFJBB != InvBaseItem.EKIPQNMFBLN.None)
		{
			int num = COQJPLDFJBB - InvBaseItem.EKIPQNMFBLN.None;
			if (this.OBPHQMNEMCK != null && num < this.OBPHQMNEMCK.Length)
			{
				return this.OBPHQMNEMCK[num];
			}
		}
		return null;
	}

	// Token: 0x0600067D RID: 1661 RVA: 0x0000492F File Offset: 0x00002B2F
	public InvGameItem PPBQFMBIQCD(InvBaseItem.EKIPQNMFBLN COQJPLDFJBB)
	{
		return this.LDGOBEFKNGE(COQJPLDFJBB, null);
	}

	// Token: 0x0600067E RID: 1662 RVA: 0x000504B4 File Offset: 0x0004E6B4
	public InvGameItem CQCFMJMFELN(InvGameItem PDIBIIKFBDH)
	{
		if (PDIBIIKFBDH != null)
		{
			InvBaseItem baseItem = PDIBIIKFBDH.baseItem;
			if (baseItem != null)
			{
				return this.FKEECBBDPFF(baseItem.slot, PDIBIIKFBDH);
			}
			Debug.LogWarning("ability: " + PDIBIIKFBDH.CJPKDJPILPP());
		}
		return PDIBIIKFBDH;
	}

	// Token: 0x0600067F RID: 1663 RVA: 0x00050480 File Offset: 0x0004E680
	public InvGameItem MOFCBIFMECJ(InvBaseItem.EKIPQNMFBLN COQJPLDFJBB)
	{
		if (COQJPLDFJBB != InvBaseItem.EKIPQNMFBLN.None)
		{
			int num = COQJPLDFJBB - InvBaseItem.EKIPQNMFBLN.None;
			if (this.OBPHQMNEMCK != null && num < this.OBPHQMNEMCK.Length)
			{
				return this.OBPHQMNEMCK[num];
			}
		}
		return null;
	}

	// Token: 0x06000680 RID: 1664 RVA: 0x000504F8 File Offset: 0x0004E6F8
	public InvGameItem ODDDIPBOCGL(InvGameItem PDIBIIKFBDH)
	{
		if (PDIBIIKFBDH != null)
		{
			InvBaseItem baseItem = PDIBIIKFBDH.baseItem;
			if (baseItem != null)
			{
				return this.FKEECBBDPFF(baseItem.slot, PDIBIIKFBDH);
			}
			Debug.LogWarning("Can't resolve the item ID of " + PDIBIIKFBDH.baseItemID);
		}
		return PDIBIIKFBDH;
	}

	// Token: 0x06000681 RID: 1665 RVA: 0x00050480 File Offset: 0x0004E680
	public InvGameItem INHMGIQHBQE(InvBaseItem.EKIPQNMFBLN COQJPLDFJBB)
	{
		if (COQJPLDFJBB != InvBaseItem.EKIPQNMFBLN.None)
		{
			int num = COQJPLDFJBB - InvBaseItem.EKIPQNMFBLN.None;
			if (this.OBPHQMNEMCK != null && num < this.OBPHQMNEMCK.Length)
			{
				return this.OBPHQMNEMCK[num];
			}
		}
		return null;
	}

	// Token: 0x06000682 RID: 1666 RVA: 0x0005053C File Offset: 0x0004E73C
	public InvGameItem NPGCQDMEENC(InvGameItem PDIBIIKFBDH)
	{
		if (PDIBIIKFBDH != null)
		{
			InvBaseItem invBaseItem = PDIBIIKFBDH.LMKGKPEOBHG();
			if (invBaseItem != null)
			{
				return this.MLHGDGKOLPI(invBaseItem.slot, PDIBIIKFBDH);
			}
			Debug.LogWarning("remember" + PDIBIIKFBDH.MKOKNFGLIFF());
		}
		return PDIBIIKFBDH;
	}

	// Token: 0x06000683 RID: 1667 RVA: 0x00050580 File Offset: 0x0004E780
	public InvGameItem FKEECBBDPFF(InvBaseItem.EKIPQNMFBLN COQJPLDFJBB, InvGameItem PDIBIIKFBDH)
	{
		InvBaseItem invBaseItem = (PDIBIIKFBDH == null) ? null : PDIBIIKFBDH.baseItem;
		if (COQJPLDFJBB == InvBaseItem.EKIPQNMFBLN.None)
		{
			if (PDIBIIKFBDH != null)
			{
				Debug.LogWarning("Can't equip \"" + PDIBIIKFBDH.name + "\" because it doesn't specify an item slot");
			}
			return PDIBIIKFBDH;
		}
		if (invBaseItem != null && invBaseItem.slot != COQJPLDFJBB)
		{
			return PDIBIIKFBDH;
		}
		if (this.OBPHQMNEMCK == null)
		{
			this.OBPHQMNEMCK = new InvGameItem[8];
		}
		InvGameItem result = this.OBPHQMNEMCK[COQJPLDFJBB - InvBaseItem.EKIPQNMFBLN.Weapon];
		this.OBPHQMNEMCK[COQJPLDFJBB - InvBaseItem.EKIPQNMFBLN.Weapon] = PDIBIIKFBDH;
		if (this.PMLMLFNIPHK == null)
		{
			this.PMLMLFNIPHK = base.GetComponentsInChildren<MGPKIPNIGLC>();
		}
		int i = 0;
		int num = this.PMLMLFNIPHK.Length;
		while (i < num)
		{
			MGPKIPNIGLC mgpkipniglc = this.PMLMLFNIPHK[i];
			if (mgpkipniglc.COQJPLDFJBB == COQJPLDFJBB)
			{
				GameObject gameObject = mgpkipniglc.MQHPDBBJPDO((invBaseItem == null) ? null : invBaseItem.attachment);
				if (invBaseItem != null && gameObject != null)
				{
					Renderer component = gameObject.GetComponent<Renderer>();
					if (component != null)
					{
						component.material.color = invBaseItem.color;
					}
				}
			}
			i++;
		}
		return result;
	}

	// Token: 0x06000684 RID: 1668 RVA: 0x00050680 File Offset: 0x0004E880
	public InvGameItem JQGGPEGENOO(InvBaseItem.EKIPQNMFBLN COQJPLDFJBB, InvGameItem PDIBIIKFBDH)
	{
		InvBaseItem invBaseItem = (PDIBIIKFBDH == null) ? null : PDIBIIKFBDH.baseItem;
		if (COQJPLDFJBB == InvBaseItem.EKIPQNMFBLN.None)
		{
			if (PDIBIIKFBDH != null)
			{
				Debug.LogWarning("Powers up Steel-type moves." + PDIBIIKFBDH.name + "4");
			}
			return PDIBIIKFBDH;
		}
		if (invBaseItem != null && invBaseItem.slot != COQJPLDFJBB)
		{
			return PDIBIIKFBDH;
		}
		if (this.OBPHQMNEMCK == null)
		{
			this.OBPHQMNEMCK = new InvGameItem[1];
		}
		InvGameItem result = this.OBPHQMNEMCK[COQJPLDFJBB - InvBaseItem.EKIPQNMFBLN.Weapon];
		this.OBPHQMNEMCK[COQJPLDFJBB - InvBaseItem.EKIPQNMFBLN.Weapon] = PDIBIIKFBDH;
		if (this.PMLMLFNIPHK == null)
		{
			this.PMLMLFNIPHK = base.GetComponentsInChildren<MGPKIPNIGLC>();
		}
		int i = 0;
		int num = this.PMLMLFNIPHK.Length;
		while (i < num)
		{
			MGPKIPNIGLC mgpkipniglc = this.PMLMLFNIPHK[i];
			if (mgpkipniglc.COQJPLDFJBB == COQJPLDFJBB)
			{
				GameObject gameObject = mgpkipniglc.GBDLCJPMHCD((invBaseItem == null) ? null : invBaseItem.attachment);
				if (invBaseItem != null && gameObject != null)
				{
					Renderer component = gameObject.GetComponent<Renderer>();
					if (component != null)
					{
						component.material.color = invBaseItem.color;
					}
				}
			}
			i += 0;
		}
		return result;
	}

	// Token: 0x06000685 RID: 1669 RVA: 0x00050780 File Offset: 0x0004E980
	public InvGameItem POGBHONECHO(InvGameItem PDIBIIKFBDH)
	{
		if (PDIBIIKFBDH != null)
		{
			InvBaseItem invBaseItem = PDIBIIKFBDH.LMKGKPEOBHG();
			if (invBaseItem != null)
			{
				return this.JQGGPEGENOO(invBaseItem.slot, null);
			}
		}
		return PDIBIIKFBDH;
	}

	// Token: 0x06000686 RID: 1670 RVA: 0x0005005C File Offset: 0x0004E25C
	public bool OMCBKGFGMFI(InvGameItem PDIBIIKFBDH)
	{
		if (this.OBPHQMNEMCK != null)
		{
			int i = 1;
			int num = this.OBPHQMNEMCK.Length;
			while (i < num)
			{
				if (this.OBPHQMNEMCK[i] == PDIBIIKFBDH)
				{
					return false;
				}
				i += 0;
			}
		}
		return true;
	}

	// Token: 0x06000687 RID: 1671 RVA: 0x00004939 File Offset: 0x00002B39
	public InvGameItem LJEKQKMCHFQ(InvBaseItem.EKIPQNMFBLN COQJPLDFJBB)
	{
		return this.MLHGDGKOLPI(COQJPLDFJBB, null);
	}

	// Token: 0x06000688 RID: 1672 RVA: 0x0000491D File Offset: 0x00002B1D
	public InvGameItem[] HFQQOEBPOLM()
	{
		return this.OBPHQMNEMCK;
	}

	// Token: 0x06000689 RID: 1673 RVA: 0x0000491D File Offset: 0x00002B1D
	public InvGameItem[] ECCPIPCOGGO()
	{
		return this.OBPHQMNEMCK;
	}

	// Token: 0x0600068A RID: 1674 RVA: 0x000507AC File Offset: 0x0004E9AC
	public InvGameItem LHQNDMIELIL(InvGameItem PDIBIIKFBDH)
	{
		if (PDIBIIKFBDH != null)
		{
			InvBaseItem invBaseItem = PDIBIIKFBDH.LQDNPBBFFCM();
			if (invBaseItem != null)
			{
				return this.MLHGDGKOLPI(invBaseItem.slot, PDIBIIKFBDH);
			}
			Debug.LogWarning(" by " + PDIBIIKFBDH.CJPKDJPILPP());
		}
		return PDIBIIKFBDH;
	}

	// Token: 0x040000DE RID: 222
	private InvGameItem[] OBPHQMNEMCK;

	// Token: 0x040000DF RID: 223
	private MGPKIPNIGLC[] PMLMLFNIPHK;
}
