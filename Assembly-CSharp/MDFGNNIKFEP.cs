using System;
using UnityEngine;

// Token: 0x02000354 RID: 852
[HelpURL("http://www.procamera2d.com/user-guide/extension-numeric-boundaries/")]
public class MDFGNNIKFEP : BNEFIOCKQOE, LIJCFDMDDIJ, NLQPOLOJJQE
{
	// Token: 0x060070EB RID: 28907 RVA: 0x0002967F File Offset: 0x0002787F
	public int HMFPLFJMGOF()
	{
		return this.GKLLDJLQPMM;
	}

	// Token: 0x060070EC RID: 28908 RVA: 0x00029687 File Offset: 0x00027887
	public int EBIMDKOJDHL()
	{
		return this.IEDKDIJGNNO;
	}

	// Token: 0x060070ED RID: 28909 RVA: 0x0002968F File Offset: 0x0002788F
	protected virtual void HMNFDLJGBIM()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.CQCBELCFQBK(this);
		base.GPONHFNLHCN.QNDGKBBGHNK(this);
	}

	// Token: 0x060070EE RID: 28910 RVA: 0x0002968F File Offset: 0x0002788F
	protected virtual void NQEKOEPCGNM()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.CQCBELCFQBK(this);
		base.GPONHFNLHCN.QNDGKBBGHNK(this);
	}

	// Token: 0x060070EF RID: 28911 RVA: 0x000296AF File Offset: 0x000278AF
	public void HIJCDQNJMEL(int BGBMIEJJQKC)
	{
		this.GKLLDJLQPMM = BGBMIEJJQKC;
	}

	// Token: 0x060070F0 RID: 28912 RVA: 0x0036C25C File Offset: 0x0036A45C
	public OLLILOPJNHQ PCIILLLHKFP()
	{
		return new OLLILOPJNHQ
		{
			GICJLBDMMEQ = this.GICJLBDMMEQ,
			PELBNKEHOHF = this.PELBNKEHOHF,
			MMHQFDMKQDQ = this.MMHQFDMKQDQ,
			IKDQPKGPPEH = this.IKDQPKGPPEH,
			BIPDHOPHDMK = this.BIPDHOPHDMK,
			QBHHBPBKQDJ = this.QBHHBPBKQDJ,
			DFFQECIDMDO = this.DFFQECIDMDO,
			IGPBFPCKNOG = this.IGPBFPCKNOG,
			JGJEPKHCBGP = this.JGJEPKHCBGP
		};
	}

	// Token: 0x060070F1 RID: 28913 RVA: 0x00029687 File Offset: 0x00027887
	public int KQQLNBOJFFB()
	{
		return this.IEDKDIJGNNO;
	}

	// Token: 0x060070F2 RID: 28914 RVA: 0x0036C2E8 File Offset: 0x0036A4E8
	public float LCHPMFFIFLL(float GPFIDEJEMEG, float GNBLMJIGCOD)
	{
		if (base.enabled && this.GICJLBDMMEQ)
		{
			float num = GNBLMJIGCOD;
			Vector2 vector = new Vector2(this.JGJEPKHCBGP - this.DFFQECIDMDO, this.MMHQFDMKQDQ - this.BIPDHOPHDMK);
			if (this.IGPBFPCKNOG && this.QBHHBPBKQDJ && GNBLMJIGCOD * base.GPONHFNLHCN.PGHJQNJLJKG.aspect * 2f > vector.x)
			{
				num = vector.x / base.GPONHFNLHCN.PGHJQNJLJKG.aspect * 0.5f;
			}
			if (this.PELBNKEHOHF && this.IKDQPKGPPEH && num * 2f > vector.y)
			{
				num = vector.y * 0.5f;
			}
			return num;
		}
		return GNBLMJIGCOD;
	}

	// Token: 0x060070F3 RID: 28915 RVA: 0x0002968F File Offset: 0x0002788F
	protected virtual void OIIEHOGHOCQ()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.CQCBELCFQBK(this);
		base.GPONHFNLHCN.QNDGKBBGHNK(this);
	}

	// Token: 0x060070F4 RID: 28916 RVA: 0x00029687 File Offset: 0x00027887
	public int OODILMONJFE()
	{
		return this.IEDKDIJGNNO;
	}

	// Token: 0x060070F5 RID: 28917 RVA: 0x0002968F File Offset: 0x0002788F
	protected override void OnDestroy()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.CQCBELCFQBK(this);
		base.GPONHFNLHCN.QNDGKBBGHNK(this);
	}

	// Token: 0x060070F6 RID: 28918 RVA: 0x0036C3B0 File Offset: 0x0036A5B0
	public void DEBIEHMNQBM(OLLILOPJNHQ BGBMIEJJQKC)
	{
		this.GICJLBDMMEQ = BGBMIEJJQKC.GICJLBDMMEQ;
		this.PELBNKEHOHF = BGBMIEJJQKC.PELBNKEHOHF;
		this.MMHQFDMKQDQ = BGBMIEJJQKC.MMHQFDMKQDQ;
		this.IKDQPKGPPEH = BGBMIEJJQKC.IKDQPKGPPEH;
		this.BIPDHOPHDMK = BGBMIEJJQKC.BIPDHOPHDMK;
		this.QBHHBPBKQDJ = BGBMIEJJQKC.QBHHBPBKQDJ;
		this.DFFQECIDMDO = BGBMIEJJQKC.DFFQECIDMDO;
		this.IGPBFPCKNOG = BGBMIEJJQKC.IGPBFPCKNOG;
		this.JGJEPKHCBGP = BGBMIEJJQKC.JGJEPKHCBGP;
	}

	// Token: 0x060070F7 RID: 28919 RVA: 0x0036C25C File Offset: 0x0036A45C
	public OLLILOPJNHQ DBJIIPOIOMN()
	{
		return new OLLILOPJNHQ
		{
			GICJLBDMMEQ = this.GICJLBDMMEQ,
			PELBNKEHOHF = this.PELBNKEHOHF,
			MMHQFDMKQDQ = this.MMHQFDMKQDQ,
			IKDQPKGPPEH = this.IKDQPKGPPEH,
			BIPDHOPHDMK = this.BIPDHOPHDMK,
			QBHHBPBKQDJ = this.QBHHBPBKQDJ,
			DFFQECIDMDO = this.DFFQECIDMDO,
			IGPBFPCKNOG = this.IGPBFPCKNOG,
			JGJEPKHCBGP = this.JGJEPKHCBGP
		};
	}

	// Token: 0x060070F8 RID: 28920 RVA: 0x0036C3B0 File Offset: 0x0036A5B0
	public void INCCLKLEFLO(OLLILOPJNHQ BGBMIEJJQKC)
	{
		this.GICJLBDMMEQ = BGBMIEJJQKC.GICJLBDMMEQ;
		this.PELBNKEHOHF = BGBMIEJJQKC.PELBNKEHOHF;
		this.MMHQFDMKQDQ = BGBMIEJJQKC.MMHQFDMKQDQ;
		this.IKDQPKGPPEH = BGBMIEJJQKC.IKDQPKGPPEH;
		this.BIPDHOPHDMK = BGBMIEJJQKC.BIPDHOPHDMK;
		this.QBHHBPBKQDJ = BGBMIEJJQKC.QBHHBPBKQDJ;
		this.DFFQECIDMDO = BGBMIEJJQKC.DFFQECIDMDO;
		this.IGPBFPCKNOG = BGBMIEJJQKC.IGPBFPCKNOG;
		this.JGJEPKHCBGP = BGBMIEJJQKC.JGJEPKHCBGP;
	}

	// Token: 0x060070F9 RID: 28921 RVA: 0x0036C434 File Offset: 0x0036A634
	public float NQBNHFJEFPI(float GPFIDEJEMEG, float GNBLMJIGCOD)
	{
		if (base.enabled && this.GICJLBDMMEQ)
		{
			float num = GNBLMJIGCOD;
			Vector2 vector = new Vector2(this.JGJEPKHCBGP - this.DFFQECIDMDO, this.MMHQFDMKQDQ - this.BIPDHOPHDMK);
			if (this.IGPBFPCKNOG && this.QBHHBPBKQDJ && GNBLMJIGCOD * base.GPONHFNLHCN.PGHJQNJLJKG.aspect * 139f > vector.x)
			{
				num = vector.x / base.GPONHFNLHCN.PGHJQNJLJKG.aspect * 459f;
			}
			if (this.PELBNKEHOHF && this.IKDQPKGPPEH && num * 1385f > vector.y)
			{
				num = vector.y * 118f;
			}
			return num;
		}
		return GNBLMJIGCOD;
	}

	// Token: 0x060070FA RID: 28922 RVA: 0x000296B8 File Offset: 0x000278B8
	protected virtual void DHBEOHDMFDO()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.CQCBELCFQBK(this);
		base.GPONHFNLHCN.CONFHHMNMDH(this);
	}

	// Token: 0x060070FB RID: 28923 RVA: 0x0036C25C File Offset: 0x0036A45C
	public OLLILOPJNHQ FQGQMBFFHNC()
	{
		return new OLLILOPJNHQ
		{
			GICJLBDMMEQ = this.GICJLBDMMEQ,
			PELBNKEHOHF = this.PELBNKEHOHF,
			MMHQFDMKQDQ = this.MMHQFDMKQDQ,
			IKDQPKGPPEH = this.IKDQPKGPPEH,
			BIPDHOPHDMK = this.BIPDHOPHDMK,
			QBHHBPBKQDJ = this.QBHHBPBKQDJ,
			DFFQECIDMDO = this.DFFQECIDMDO,
			IGPBFPCKNOG = this.IGPBFPCKNOG,
			JGJEPKHCBGP = this.JGJEPKHCBGP
		};
	}

	// Token: 0x060070FC RID: 28924 RVA: 0x0036C25C File Offset: 0x0036A45C
	public OLLILOPJNHQ KHDDKNMQKQL()
	{
		return new OLLILOPJNHQ
		{
			GICJLBDMMEQ = this.GICJLBDMMEQ,
			PELBNKEHOHF = this.PELBNKEHOHF,
			MMHQFDMKQDQ = this.MMHQFDMKQDQ,
			IKDQPKGPPEH = this.IKDQPKGPPEH,
			BIPDHOPHDMK = this.BIPDHOPHDMK,
			QBHHBPBKQDJ = this.QBHHBPBKQDJ,
			DFFQECIDMDO = this.DFFQECIDMDO,
			IGPBFPCKNOG = this.IGPBFPCKNOG,
			JGJEPKHCBGP = this.JGJEPKHCBGP
		};
	}

	// Token: 0x060070FE RID: 28926 RVA: 0x0036C57C File Offset: 0x0036A77C
	public float BCIHNGOCMDL(float GPFIDEJEMEG, float GNBLMJIGCOD)
	{
		if (base.enabled && this.GICJLBDMMEQ)
		{
			float num = GNBLMJIGCOD;
			Vector2 vector = new Vector2(this.JGJEPKHCBGP - this.DFFQECIDMDO, this.MMHQFDMKQDQ - this.BIPDHOPHDMK);
			if (this.IGPBFPCKNOG && this.QBHHBPBKQDJ && GNBLMJIGCOD * base.GPONHFNLHCN.PGHJQNJLJKG.aspect * 1642f > vector.x)
			{
				num = vector.x / base.GPONHFNLHCN.PGHJQNJLJKG.aspect * 578f;
			}
			if (this.PELBNKEHOHF && this.IKDQPKGPPEH && num * 622f > vector.y)
			{
				num = vector.y * 1528f;
			}
			return num;
		}
		return GNBLMJIGCOD;
	}

	// Token: 0x060070FF RID: 28927 RVA: 0x0002967F File Offset: 0x0002787F
	public int GKKPNLOKFFI()
	{
		return this.GKLLDJLQPMM;
	}

	// Token: 0x06007100 RID: 28928 RVA: 0x000296AF File Offset: 0x000278AF
	public void ODOLHJFGGFH(int BGBMIEJJQKC)
	{
		this.GKLLDJLQPMM = BGBMIEJJQKC;
	}

	// Token: 0x06007101 RID: 28929 RVA: 0x0002968F File Offset: 0x0002788F
	protected virtual void GCPCLEJDGLN()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.CQCBELCFQBK(this);
		base.GPONHFNLHCN.QNDGKBBGHNK(this);
	}

	// Token: 0x06007102 RID: 28930 RVA: 0x0002967F File Offset: 0x0002787F
	public int HHLQJJDQFBO()
	{
		return this.GKLLDJLQPMM;
	}

	// Token: 0x06007104 RID: 28932 RVA: 0x000296AF File Offset: 0x000278AF
	public void PKPDPICQKGL(int BGBMIEJJQKC)
	{
		this.GKLLDJLQPMM = BGBMIEJJQKC;
	}

	// Token: 0x06007105 RID: 28933 RVA: 0x000296B8 File Offset: 0x000278B8
	protected virtual void ONKEDLLOMCE()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.CQCBELCFQBK(this);
		base.GPONHFNLHCN.CONFHHMNMDH(this);
	}

	// Token: 0x06007106 RID: 28934 RVA: 0x0002967F File Offset: 0x0002787F
	public int DKEGPMGMGGM()
	{
		return this.GKLLDJLQPMM;
	}

	// Token: 0x06007107 RID: 28935 RVA: 0x00029687 File Offset: 0x00027887
	public int DNPBPLGODPB()
	{
		return this.IEDKDIJGNNO;
	}

	// Token: 0x06007108 RID: 28936 RVA: 0x0002968F File Offset: 0x0002788F
	protected virtual void INPFOLLJMQN()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.CQCBELCFQBK(this);
		base.GPONHFNLHCN.QNDGKBBGHNK(this);
	}

	// Token: 0x06007109 RID: 28937 RVA: 0x000296B8 File Offset: 0x000278B8
	protected virtual void JIFPOIEIQKI()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.CQCBELCFQBK(this);
		base.GPONHFNLHCN.CONFHHMNMDH(this);
	}

	// Token: 0x0600710A RID: 28938 RVA: 0x0002967F File Offset: 0x0002787F
	public int LBFLGDKCMHG()
	{
		return this.GKLLDJLQPMM;
	}

	// Token: 0x0600710B RID: 28939 RVA: 0x000296E4 File Offset: 0x000278E4
	protected virtual void BCEKGNDIIOE()
	{
		base.Awake();
		base.GPONHFNLHCN.JKNBMCKEBOF(this);
		base.GPONHFNLHCN.CIDMBQQGPNM(this);
	}

	// Token: 0x0600710C RID: 28940 RVA: 0x0036C644 File Offset: 0x0036A844
	public float EGGKKMEQFMF(float GPFIDEJEMEG, float GNBLMJIGCOD)
	{
		if (base.enabled && this.GICJLBDMMEQ)
		{
			float num = GNBLMJIGCOD;
			Vector2 vector = new Vector2(this.JGJEPKHCBGP - this.DFFQECIDMDO, this.MMHQFDMKQDQ - this.BIPDHOPHDMK);
			if (this.IGPBFPCKNOG && this.QBHHBPBKQDJ && GNBLMJIGCOD * base.GPONHFNLHCN.PGHJQNJLJKG.aspect * 1746f > vector.x)
			{
				num = vector.x / base.GPONHFNLHCN.PGHJQNJLJKG.aspect * 490f;
			}
			if (this.PELBNKEHOHF && this.IKDQPKGPPEH && num * 1825f > vector.y)
			{
				num = vector.y * 69f;
			}
			return num;
		}
		return GNBLMJIGCOD;
	}

	// Token: 0x0600710D RID: 28941 RVA: 0x0002968F File Offset: 0x0002788F
	protected virtual void NNEMLECOOIM()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.CQCBELCFQBK(this);
		base.GPONHFNLHCN.QNDGKBBGHNK(this);
	}

	// Token: 0x170003E9 RID: 1001
	// (get) Token: 0x0600711C RID: 28956 RVA: 0x00029687 File Offset: 0x00027887
	// (set) Token: 0x0600710E RID: 28942 RVA: 0x00029704 File Offset: 0x00027904
	public int DPGOQJMLMNF
	{
		get
		{
			return this.IEDKDIJGNNO;
		}
		set
		{
			this.IEDKDIJGNNO = value;
		}
	}

	// Token: 0x0600710F RID: 28943 RVA: 0x00029704 File Offset: 0x00027904
	public void LNJOCGDDQPC(int BGBMIEJJQKC)
	{
		this.IEDKDIJGNNO = BGBMIEJJQKC;
	}

	// Token: 0x06007110 RID: 28944 RVA: 0x00029704 File Offset: 0x00027904
	public void QKNLIPPKIEG(int BGBMIEJJQKC)
	{
		this.IEDKDIJGNNO = BGBMIEJJQKC;
	}

	// Token: 0x06007111 RID: 28945 RVA: 0x0036C70C File Offset: 0x0036A90C
	public float NFIHCMIILLC(float GPFIDEJEMEG, float GNBLMJIGCOD)
	{
		if (base.enabled && this.GICJLBDMMEQ)
		{
			float num = GNBLMJIGCOD;
			Vector2 vector = new Vector2(this.JGJEPKHCBGP - this.DFFQECIDMDO, this.MMHQFDMKQDQ - this.BIPDHOPHDMK);
			if (this.IGPBFPCKNOG && this.QBHHBPBKQDJ && GNBLMJIGCOD * base.GPONHFNLHCN.PGHJQNJLJKG.aspect * 826f > vector.x)
			{
				num = vector.x / base.GPONHFNLHCN.PGHJQNJLJKG.aspect * 895f;
			}
			if (this.PELBNKEHOHF && this.IKDQPKGPPEH && num * 1779f > vector.y)
			{
				num = vector.y * 1340f;
			}
			return num;
		}
		return GNBLMJIGCOD;
	}

	// Token: 0x170003EA RID: 1002
	// (get) Token: 0x06007132 RID: 28978 RVA: 0x0002967F File Offset: 0x0002787F
	// (set) Token: 0x06007112 RID: 28946 RVA: 0x000296AF File Offset: 0x000278AF
	public int OOKGEICHBQO
	{
		get
		{
			return this.GKLLDJLQPMM;
		}
		set
		{
			this.GKLLDJLQPMM = value;
		}
	}

	// Token: 0x170003E8 RID: 1000
	// (get) Token: 0x06007113 RID: 28947 RVA: 0x0036C25C File Offset: 0x0036A45C
	// (set) Token: 0x06007115 RID: 28949 RVA: 0x0036C3B0 File Offset: 0x0036A5B0
	public OLLILOPJNHQ PKFCCBOMHJG
	{
		get
		{
			return new OLLILOPJNHQ
			{
				GICJLBDMMEQ = this.GICJLBDMMEQ,
				PELBNKEHOHF = this.PELBNKEHOHF,
				MMHQFDMKQDQ = this.MMHQFDMKQDQ,
				IKDQPKGPPEH = this.IKDQPKGPPEH,
				BIPDHOPHDMK = this.BIPDHOPHDMK,
				QBHHBPBKQDJ = this.QBHHBPBKQDJ,
				DFFQECIDMDO = this.DFFQECIDMDO,
				IGPBFPCKNOG = this.IGPBFPCKNOG,
				JGJEPKHCBGP = this.JGJEPKHCBGP
			};
		}
		set
		{
			this.GICJLBDMMEQ = value.GICJLBDMMEQ;
			this.PELBNKEHOHF = value.PELBNKEHOHF;
			this.MMHQFDMKQDQ = value.MMHQFDMKQDQ;
			this.IKDQPKGPPEH = value.IKDQPKGPPEH;
			this.BIPDHOPHDMK = value.BIPDHOPHDMK;
			this.QBHHBPBKQDJ = value.QBHHBPBKQDJ;
			this.DFFQECIDMDO = value.DFFQECIDMDO;
			this.IGPBFPCKNOG = value.IGPBFPCKNOG;
			this.JGJEPKHCBGP = value.JGJEPKHCBGP;
		}
	}

	// Token: 0x06007114 RID: 28948 RVA: 0x000296E4 File Offset: 0x000278E4
	protected virtual void NPEJDHMIFDJ()
	{
		base.Awake();
		base.GPONHFNLHCN.JKNBMCKEBOF(this);
		base.GPONHFNLHCN.CIDMBQQGPNM(this);
	}

	// Token: 0x06007116 RID: 28950 RVA: 0x0036C7D4 File Offset: 0x0036A9D4
	public float QJJNNOLBHDC(float GPFIDEJEMEG, float GNBLMJIGCOD)
	{
		if (base.enabled && this.GICJLBDMMEQ)
		{
			float num = GNBLMJIGCOD;
			Vector2 vector = new Vector2(this.JGJEPKHCBGP - this.DFFQECIDMDO, this.MMHQFDMKQDQ - this.BIPDHOPHDMK);
			if (this.IGPBFPCKNOG && this.QBHHBPBKQDJ && GNBLMJIGCOD * base.GPONHFNLHCN.PGHJQNJLJKG.aspect * 543f > vector.x)
			{
				num = vector.x / base.GPONHFNLHCN.PGHJQNJLJKG.aspect * 1655f;
			}
			if (this.PELBNKEHOHF && this.IKDQPKGPPEH && num * 1461f > vector.y)
			{
				num = vector.y * 1888f;
			}
			return num;
		}
		return GNBLMJIGCOD;
	}

	// Token: 0x06007117 RID: 28951 RVA: 0x0036C25C File Offset: 0x0036A45C
	public OLLILOPJNHQ QDNQCGMNNOJ()
	{
		return new OLLILOPJNHQ
		{
			GICJLBDMMEQ = this.GICJLBDMMEQ,
			PELBNKEHOHF = this.PELBNKEHOHF,
			MMHQFDMKQDQ = this.MMHQFDMKQDQ,
			IKDQPKGPPEH = this.IKDQPKGPPEH,
			BIPDHOPHDMK = this.BIPDHOPHDMK,
			QBHHBPBKQDJ = this.QBHHBPBKQDJ,
			DFFQECIDMDO = this.DFFQECIDMDO,
			IGPBFPCKNOG = this.IGPBFPCKNOG,
			JGJEPKHCBGP = this.JGJEPKHCBGP
		};
	}

	// Token: 0x06007118 RID: 28952 RVA: 0x000296AF File Offset: 0x000278AF
	public void BDMODMHJKGM(int BGBMIEJJQKC)
	{
		this.GKLLDJLQPMM = BGBMIEJJQKC;
	}

	// Token: 0x06007119 RID: 28953 RVA: 0x000296E4 File Offset: 0x000278E4
	protected override void Awake()
	{
		base.Awake();
		base.GPONHFNLHCN.JKNBMCKEBOF(this);
		base.GPONHFNLHCN.CIDMBQQGPNM(this);
	}

	// Token: 0x0600711A RID: 28954 RVA: 0x0036C89C File Offset: 0x0036AA9C
	public Vector3 HCLNLBGPLKB(float GPFIDEJEMEG, Vector3 HELGNNDIDCI)
	{
		if (base.enabled && this.GICJLBDMMEQ)
		{
			this.DFBPNMPBQGB = true;
			base.GPONHFNLHCN.GBLMKLCEOJD = true;
			base.GPONHFNLHCN.IKMGDQCOMMP = true;
			this.GEDMLDGKJNC = true;
			base.GPONHFNLHCN.GQEBOLFGLDE = true;
			base.GPONHFNLHCN.BCPMLPJKKDJ = true;
			float num = this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) + this.FKGNBCKJPQO(HELGNNDIDCI);
			float num2 = this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) + this.JNBBJCLFFBB(HELGNNDIDCI);
			float num3 = base.GPONHFNLHCN.FOOEEHDJBQN().x * 443f;
			float num4 = base.GPONHFNLHCN.PGKODNCDNJQ.y * 764f;
			float num5 = (!this.QJKEILOBDKG) ? 232f : (base.GPONHFNLHCN.FOOEEHDJBQN().x * this.QHLFLPJEOJQ);
			float num6 = (!this.QJKEILOBDKG) ? 1404f : (base.GPONHFNLHCN.FOOEEHDJBQN().y * this.QHLFLPJEOJQ);
			if (this.QBHHBPBKQDJ && num - num3 < this.DFFQECIDMDO + num5)
			{
				if (this.QJKEILOBDKG)
				{
					if (this.FKGNBCKJPQO(HELGNNDIDCI) <= 1676f)
					{
						num = Mathf.SmoothDamp(Mathf.Max(this.DFFQECIDMDO + num3, this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM)), Mathf.Max(this.DFFQECIDMDO + num3, num), ref this.NFKHMNIEFJP, (this.DFFQECIDMDO + num3 - this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) + num5) / num5 * this.KFOBQELOFIC);
					}
					else
					{
						num = Mathf.Max(this.DFFQECIDMDO + num3, num);
					}
				}
				else if (!this.QJKEILOBDKG)
				{
					num = this.DFFQECIDMDO + num3;
				}
				this.DFBPNMPBQGB = false;
				base.GPONHFNLHCN.GBLMKLCEOJD = true;
			}
			if (this.IGPBFPCKNOG && num + num3 > this.JGJEPKHCBGP - num5)
			{
				if (this.QJKEILOBDKG)
				{
					if (this.FKGNBCKJPQO(HELGNNDIDCI) >= 1125f)
					{
						num = Mathf.SmoothDamp(Mathf.Min(this.JGJEPKHCBGP - num3, this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM)), Mathf.Min(this.JGJEPKHCBGP - num3, num), ref this.NFKHMNIEFJP, (this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) - (this.JGJEPKHCBGP - num3) + num5) / num5 * this.KFOBQELOFIC);
					}
					else
					{
						num = Mathf.Min(this.JGJEPKHCBGP - num3, num);
					}
				}
				else if (!this.QJKEILOBDKG)
				{
					num = this.JGJEPKHCBGP - num3;
				}
				this.DFBPNMPBQGB = true;
				base.GPONHFNLHCN.IKMGDQCOMMP = false;
			}
			if (this.IKDQPKGPPEH && num2 - num4 < this.BIPDHOPHDMK + num6)
			{
				if (this.QJKEILOBDKG)
				{
					if (this.JNBBJCLFFBB(HELGNNDIDCI) <= 410f)
					{
						num2 = Mathf.SmoothDamp(Mathf.Max(this.BIPDHOPHDMK + num4, this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM)), Mathf.Max(this.BIPDHOPHDMK + num4, num2), ref this.NPDGNBJPDCP, (this.BIPDHOPHDMK + num4 + num6 - this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM)) / num5 * this.KFOBQELOFIC);
					}
					else
					{
						num2 = Mathf.Max(this.BIPDHOPHDMK + num4, num2);
					}
				}
				else if (!this.QJKEILOBDKG)
				{
					num2 = this.BIPDHOPHDMK + num4;
				}
				this.GEDMLDGKJNC = true;
				base.GPONHFNLHCN.BCPMLPJKKDJ = true;
			}
			if (this.PELBNKEHOHF && num2 + num4 > this.MMHQFDMKQDQ - num6)
			{
				if (this.QJKEILOBDKG)
				{
					if (this.JNBBJCLFFBB(HELGNNDIDCI) >= 1773f)
					{
						num2 = Mathf.SmoothDamp(Mathf.Min(this.MMHQFDMKQDQ - num4, this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM)), Mathf.Min(this.MMHQFDMKQDQ - num4, num2), ref this.NPDGNBJPDCP, (this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) - (this.MMHQFDMKQDQ - num4) + num6) / num5 * this.KFOBQELOFIC);
					}
					else
					{
						num2 = Mathf.Min(this.MMHQFDMKQDQ - num4, num2);
					}
				}
				else if (!this.QJKEILOBDKG)
				{
					num2 = this.MMHQFDMKQDQ - num4;
				}
				this.GEDMLDGKJNC = false;
				base.GPONHFNLHCN.GQEBOLFGLDE = false;
			}
			return this.QMEMFMDBHLI(num - this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), num2 - this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM));
		}
		return HELGNNDIDCI;
	}

	// Token: 0x0600711B RID: 28955 RVA: 0x0036C3B0 File Offset: 0x0036A5B0
	public void INPOFBCKGNK(OLLILOPJNHQ BGBMIEJJQKC)
	{
		this.GICJLBDMMEQ = BGBMIEJJQKC.GICJLBDMMEQ;
		this.PELBNKEHOHF = BGBMIEJJQKC.PELBNKEHOHF;
		this.MMHQFDMKQDQ = BGBMIEJJQKC.MMHQFDMKQDQ;
		this.IKDQPKGPPEH = BGBMIEJJQKC.IKDQPKGPPEH;
		this.BIPDHOPHDMK = BGBMIEJJQKC.BIPDHOPHDMK;
		this.QBHHBPBKQDJ = BGBMIEJJQKC.QBHHBPBKQDJ;
		this.DFFQECIDMDO = BGBMIEJJQKC.DFFQECIDMDO;
		this.IGPBFPCKNOG = BGBMIEJJQKC.IGPBFPCKNOG;
		this.JGJEPKHCBGP = BGBMIEJJQKC.JGJEPKHCBGP;
	}

	// Token: 0x0600711D RID: 28957 RVA: 0x0036CD84 File Offset: 0x0036AF84
	public Vector3 FQCMJHDBDKJ(float GPFIDEJEMEG, Vector3 HELGNNDIDCI)
	{
		if (base.enabled && this.GICJLBDMMEQ)
		{
			this.DFBPNMPBQGB = false;
			base.GPONHFNLHCN.GBLMKLCEOJD = true;
			base.GPONHFNLHCN.IKMGDQCOMMP = false;
			this.GEDMLDGKJNC = true;
			base.GPONHFNLHCN.GQEBOLFGLDE = true;
			base.GPONHFNLHCN.BCPMLPJKKDJ = false;
			float num = this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) + this.FKGNBCKJPQO(HELGNNDIDCI);
			float num2 = this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) + this.JNBBJCLFFBB(HELGNNDIDCI);
			float num3 = base.GPONHFNLHCN.FOOEEHDJBQN().x * 757f;
			float num4 = base.GPONHFNLHCN.FOOEEHDJBQN().y * 1330f;
			float num5 = (!this.QJKEILOBDKG) ? 1829f : (base.GPONHFNLHCN.FOOEEHDJBQN().x * this.QHLFLPJEOJQ);
			float num6 = (!this.QJKEILOBDKG) ? 1026f : (base.GPONHFNLHCN.FOOEEHDJBQN().y * this.QHLFLPJEOJQ);
			if (this.QBHHBPBKQDJ && num - num3 < this.DFFQECIDMDO + num5)
			{
				if (this.QJKEILOBDKG)
				{
					if (this.FKGNBCKJPQO(HELGNNDIDCI) <= 1758f)
					{
						num = Mathf.SmoothDamp(Mathf.Max(this.DFFQECIDMDO + num3, this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM)), Mathf.Max(this.DFFQECIDMDO + num3, num), ref this.NFKHMNIEFJP, (this.DFFQECIDMDO + num3 - this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) + num5) / num5 * this.KFOBQELOFIC);
					}
					else
					{
						num = Mathf.Max(this.DFFQECIDMDO + num3, num);
					}
				}
				else if (!this.QJKEILOBDKG)
				{
					num = this.DFFQECIDMDO + num3;
				}
				this.DFBPNMPBQGB = true;
				base.GPONHFNLHCN.GBLMKLCEOJD = false;
			}
			if (this.IGPBFPCKNOG && num + num3 > this.JGJEPKHCBGP - num5)
			{
				if (this.QJKEILOBDKG)
				{
					if (this.FKGNBCKJPQO(HELGNNDIDCI) >= 130f)
					{
						num = Mathf.SmoothDamp(Mathf.Min(this.JGJEPKHCBGP - num3, this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM)), Mathf.Min(this.JGJEPKHCBGP - num3, num), ref this.NFKHMNIEFJP, (this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) - (this.JGJEPKHCBGP - num3) + num5) / num5 * this.KFOBQELOFIC);
					}
					else
					{
						num = Mathf.Min(this.JGJEPKHCBGP - num3, num);
					}
				}
				else if (!this.QJKEILOBDKG)
				{
					num = this.JGJEPKHCBGP - num3;
				}
				this.DFBPNMPBQGB = false;
				base.GPONHFNLHCN.IKMGDQCOMMP = false;
			}
			if (this.IKDQPKGPPEH && num2 - num4 < this.BIPDHOPHDMK + num6)
			{
				if (this.QJKEILOBDKG)
				{
					if (this.JNBBJCLFFBB(HELGNNDIDCI) <= 1658f)
					{
						num2 = Mathf.SmoothDamp(Mathf.Max(this.BIPDHOPHDMK + num4, this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM)), Mathf.Max(this.BIPDHOPHDMK + num4, num2), ref this.NPDGNBJPDCP, (this.BIPDHOPHDMK + num4 + num6 - this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM)) / num5 * this.KFOBQELOFIC);
					}
					else
					{
						num2 = Mathf.Max(this.BIPDHOPHDMK + num4, num2);
					}
				}
				else if (!this.QJKEILOBDKG)
				{
					num2 = this.BIPDHOPHDMK + num4;
				}
				this.GEDMLDGKJNC = true;
				base.GPONHFNLHCN.BCPMLPJKKDJ = false;
			}
			if (this.PELBNKEHOHF && num2 + num4 > this.MMHQFDMKQDQ - num6)
			{
				if (this.QJKEILOBDKG)
				{
					if (this.JNBBJCLFFBB(HELGNNDIDCI) >= 1965f)
					{
						num2 = Mathf.SmoothDamp(Mathf.Min(this.MMHQFDMKQDQ - num4, this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM)), Mathf.Min(this.MMHQFDMKQDQ - num4, num2), ref this.NPDGNBJPDCP, (this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) - (this.MMHQFDMKQDQ - num4) + num6) / num5 * this.KFOBQELOFIC);
					}
					else
					{
						num2 = Mathf.Min(this.MMHQFDMKQDQ - num4, num2);
					}
				}
				else if (!this.QJKEILOBDKG)
				{
					num2 = this.MMHQFDMKQDQ - num4;
				}
				this.GEDMLDGKJNC = false;
				base.GPONHFNLHCN.GQEBOLFGLDE = true;
			}
			return this.QMEMFMDBHLI(num - this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), num2 - this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM));
		}
		return HELGNNDIDCI;
	}

	// Token: 0x0600711E RID: 28958 RVA: 0x000296AF File Offset: 0x000278AF
	public void BHDHOGQPDPC(int BGBMIEJJQKC)
	{
		this.GKLLDJLQPMM = BGBMIEJJQKC;
	}

	// Token: 0x0600711F RID: 28959 RVA: 0x00029687 File Offset: 0x00027887
	public int EEFFJFGGBFB()
	{
		return this.IEDKDIJGNNO;
	}

	// Token: 0x06007120 RID: 28960 RVA: 0x000296E4 File Offset: 0x000278E4
	protected virtual void CGDEBJQKGMO()
	{
		base.Awake();
		base.GPONHFNLHCN.JKNBMCKEBOF(this);
		base.GPONHFNLHCN.CIDMBQQGPNM(this);
	}

	// Token: 0x06007121 RID: 28961 RVA: 0x0036D26C File Offset: 0x0036B46C
	public Vector3 MKKGHGDNEOK(float GPFIDEJEMEG, Vector3 HELGNNDIDCI)
	{
		if (base.enabled && this.GICJLBDMMEQ)
		{
			this.DFBPNMPBQGB = false;
			base.GPONHFNLHCN.GBLMKLCEOJD = false;
			base.GPONHFNLHCN.IKMGDQCOMMP = false;
			this.GEDMLDGKJNC = false;
			base.GPONHFNLHCN.GQEBOLFGLDE = false;
			base.GPONHFNLHCN.BCPMLPJKKDJ = false;
			float num = this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) + this.FKGNBCKJPQO(HELGNNDIDCI);
			float num2 = this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) + this.JNBBJCLFFBB(HELGNNDIDCI);
			float num3 = base.GPONHFNLHCN.PGKODNCDNJQ.x * 0.5f;
			float num4 = base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f;
			float num5 = (!this.QJKEILOBDKG) ? 0f : (base.GPONHFNLHCN.PGKODNCDNJQ.x * this.QHLFLPJEOJQ);
			float num6 = (!this.QJKEILOBDKG) ? 0f : (base.GPONHFNLHCN.PGKODNCDNJQ.y * this.QHLFLPJEOJQ);
			if (this.QBHHBPBKQDJ && num - num3 < this.DFFQECIDMDO + num5)
			{
				if (this.QJKEILOBDKG)
				{
					if (this.FKGNBCKJPQO(HELGNNDIDCI) <= 0f)
					{
						num = Mathf.SmoothDamp(Mathf.Max(this.DFFQECIDMDO + num3, this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM)), Mathf.Max(this.DFFQECIDMDO + num3, num), ref this.NFKHMNIEFJP, (this.DFFQECIDMDO + num3 - this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) + num5) / num5 * this.KFOBQELOFIC);
					}
					else
					{
						num = Mathf.Max(this.DFFQECIDMDO + num3, num);
					}
				}
				else if (!this.QJKEILOBDKG)
				{
					num = this.DFFQECIDMDO + num3;
				}
				this.DFBPNMPBQGB = true;
				base.GPONHFNLHCN.GBLMKLCEOJD = true;
			}
			if (this.IGPBFPCKNOG && num + num3 > this.JGJEPKHCBGP - num5)
			{
				if (this.QJKEILOBDKG)
				{
					if (this.FKGNBCKJPQO(HELGNNDIDCI) >= 0f)
					{
						num = Mathf.SmoothDamp(Mathf.Min(this.JGJEPKHCBGP - num3, this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM)), Mathf.Min(this.JGJEPKHCBGP - num3, num), ref this.NFKHMNIEFJP, (this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) - (this.JGJEPKHCBGP - num3) + num5) / num5 * this.KFOBQELOFIC);
					}
					else
					{
						num = Mathf.Min(this.JGJEPKHCBGP - num3, num);
					}
				}
				else if (!this.QJKEILOBDKG)
				{
					num = this.JGJEPKHCBGP - num3;
				}
				this.DFBPNMPBQGB = true;
				base.GPONHFNLHCN.IKMGDQCOMMP = true;
			}
			if (this.IKDQPKGPPEH && num2 - num4 < this.BIPDHOPHDMK + num6)
			{
				if (this.QJKEILOBDKG)
				{
					if (this.JNBBJCLFFBB(HELGNNDIDCI) <= 0f)
					{
						num2 = Mathf.SmoothDamp(Mathf.Max(this.BIPDHOPHDMK + num4, this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM)), Mathf.Max(this.BIPDHOPHDMK + num4, num2), ref this.NPDGNBJPDCP, (this.BIPDHOPHDMK + num4 + num6 - this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM)) / num5 * this.KFOBQELOFIC);
					}
					else
					{
						num2 = Mathf.Max(this.BIPDHOPHDMK + num4, num2);
					}
				}
				else if (!this.QJKEILOBDKG)
				{
					num2 = this.BIPDHOPHDMK + num4;
				}
				this.GEDMLDGKJNC = true;
				base.GPONHFNLHCN.BCPMLPJKKDJ = true;
			}
			if (this.PELBNKEHOHF && num2 + num4 > this.MMHQFDMKQDQ - num6)
			{
				if (this.QJKEILOBDKG)
				{
					if (this.JNBBJCLFFBB(HELGNNDIDCI) >= 0f)
					{
						num2 = Mathf.SmoothDamp(Mathf.Min(this.MMHQFDMKQDQ - num4, this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM)), Mathf.Min(this.MMHQFDMKQDQ - num4, num2), ref this.NPDGNBJPDCP, (this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) - (this.MMHQFDMKQDQ - num4) + num6) / num5 * this.KFOBQELOFIC);
					}
					else
					{
						num2 = Mathf.Min(this.MMHQFDMKQDQ - num4, num2);
					}
				}
				else if (!this.QJKEILOBDKG)
				{
					num2 = this.MMHQFDMKQDQ - num4;
				}
				this.GEDMLDGKJNC = true;
				base.GPONHFNLHCN.GQEBOLFGLDE = true;
			}
			return this.QMEMFMDBHLI(num - this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), num2 - this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM));
		}
		return HELGNNDIDCI;
	}

	// Token: 0x06007122 RID: 28962 RVA: 0x0002970D File Offset: 0x0002790D
	protected virtual void HLHPCLEMCKI()
	{
		base.Awake();
		base.GPONHFNLHCN.JKNBMCKEBOF(this);
		base.GPONHFNLHCN.NODLKQNBMFD(this);
	}

	// Token: 0x06007123 RID: 28963 RVA: 0x000296E4 File Offset: 0x000278E4
	protected virtual void EPGFPKPJNHF()
	{
		base.Awake();
		base.GPONHFNLHCN.JKNBMCKEBOF(this);
		base.GPONHFNLHCN.CIDMBQQGPNM(this);
	}

	// Token: 0x06007124 RID: 28964 RVA: 0x00029704 File Offset: 0x00027904
	public void DJEIFGHOBNK(int BGBMIEJJQKC)
	{
		this.IEDKDIJGNNO = BGBMIEJJQKC;
	}

	// Token: 0x06007125 RID: 28965 RVA: 0x0002968F File Offset: 0x0002788F
	protected virtual void HGFCQIKLPDO()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.CQCBELCFQBK(this);
		base.GPONHFNLHCN.QNDGKBBGHNK(this);
	}

	// Token: 0x06007126 RID: 28966 RVA: 0x000296AF File Offset: 0x000278AF
	public void FKDOJNKCOJG(int BGBMIEJJQKC)
	{
		this.GKLLDJLQPMM = BGBMIEJJQKC;
	}

	// Token: 0x06007127 RID: 28967 RVA: 0x00029704 File Offset: 0x00027904
	public void CFNGNNEMMPC(int BGBMIEJJQKC)
	{
		this.IEDKDIJGNNO = BGBMIEJJQKC;
	}

	// Token: 0x06007128 RID: 28968 RVA: 0x0036D754 File Offset: 0x0036B954
	public Vector3 NIFHDJJLEMN(float GPFIDEJEMEG, Vector3 HELGNNDIDCI)
	{
		if (base.enabled && this.GICJLBDMMEQ)
		{
			this.DFBPNMPBQGB = false;
			base.GPONHFNLHCN.GBLMKLCEOJD = true;
			base.GPONHFNLHCN.IKMGDQCOMMP = false;
			this.GEDMLDGKJNC = false;
			base.GPONHFNLHCN.GQEBOLFGLDE = true;
			base.GPONHFNLHCN.BCPMLPJKKDJ = false;
			float num = this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) + this.FKGNBCKJPQO(HELGNNDIDCI);
			float num2 = this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) + this.JNBBJCLFFBB(HELGNNDIDCI);
			float num3 = base.GPONHFNLHCN.PGKODNCDNJQ.x * 274f;
			float num4 = base.GPONHFNLHCN.PGKODNCDNJQ.y * 407f;
			float num5 = (!this.QJKEILOBDKG) ? 1334f : (base.GPONHFNLHCN.FOOEEHDJBQN().x * this.QHLFLPJEOJQ);
			float num6 = (!this.QJKEILOBDKG) ? 123f : (base.GPONHFNLHCN.FOOEEHDJBQN().y * this.QHLFLPJEOJQ);
			if (this.QBHHBPBKQDJ && num - num3 < this.DFFQECIDMDO + num5)
			{
				if (this.QJKEILOBDKG)
				{
					if (this.FKGNBCKJPQO(HELGNNDIDCI) <= 30f)
					{
						num = Mathf.SmoothDamp(Mathf.Max(this.DFFQECIDMDO + num3, this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM)), Mathf.Max(this.DFFQECIDMDO + num3, num), ref this.NFKHMNIEFJP, (this.DFFQECIDMDO + num3 - this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) + num5) / num5 * this.KFOBQELOFIC);
					}
					else
					{
						num = Mathf.Max(this.DFFQECIDMDO + num3, num);
					}
				}
				else if (!this.QJKEILOBDKG)
				{
					num = this.DFFQECIDMDO + num3;
				}
				this.DFBPNMPBQGB = true;
				base.GPONHFNLHCN.GBLMKLCEOJD = false;
			}
			if (this.IGPBFPCKNOG && num + num3 > this.JGJEPKHCBGP - num5)
			{
				if (this.QJKEILOBDKG)
				{
					if (this.FKGNBCKJPQO(HELGNNDIDCI) >= 210f)
					{
						num = Mathf.SmoothDamp(Mathf.Min(this.JGJEPKHCBGP - num3, this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM)), Mathf.Min(this.JGJEPKHCBGP - num3, num), ref this.NFKHMNIEFJP, (this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) - (this.JGJEPKHCBGP - num3) + num5) / num5 * this.KFOBQELOFIC);
					}
					else
					{
						num = Mathf.Min(this.JGJEPKHCBGP - num3, num);
					}
				}
				else if (!this.QJKEILOBDKG)
				{
					num = this.JGJEPKHCBGP - num3;
				}
				this.DFBPNMPBQGB = true;
				base.GPONHFNLHCN.IKMGDQCOMMP = false;
			}
			if (this.IKDQPKGPPEH && num2 - num4 < this.BIPDHOPHDMK + num6)
			{
				if (this.QJKEILOBDKG)
				{
					if (this.JNBBJCLFFBB(HELGNNDIDCI) <= 677f)
					{
						num2 = Mathf.SmoothDamp(Mathf.Max(this.BIPDHOPHDMK + num4, this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM)), Mathf.Max(this.BIPDHOPHDMK + num4, num2), ref this.NPDGNBJPDCP, (this.BIPDHOPHDMK + num4 + num6 - this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM)) / num5 * this.KFOBQELOFIC);
					}
					else
					{
						num2 = Mathf.Max(this.BIPDHOPHDMK + num4, num2);
					}
				}
				else if (!this.QJKEILOBDKG)
				{
					num2 = this.BIPDHOPHDMK + num4;
				}
				this.GEDMLDGKJNC = false;
				base.GPONHFNLHCN.BCPMLPJKKDJ = true;
			}
			if (this.PELBNKEHOHF && num2 + num4 > this.MMHQFDMKQDQ - num6)
			{
				if (this.QJKEILOBDKG)
				{
					if (this.JNBBJCLFFBB(HELGNNDIDCI) >= 776f)
					{
						num2 = Mathf.SmoothDamp(Mathf.Min(this.MMHQFDMKQDQ - num4, this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM)), Mathf.Min(this.MMHQFDMKQDQ - num4, num2), ref this.NPDGNBJPDCP, (this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) - (this.MMHQFDMKQDQ - num4) + num6) / num5 * this.KFOBQELOFIC);
					}
					else
					{
						num2 = Mathf.Min(this.MMHQFDMKQDQ - num4, num2);
					}
				}
				else if (!this.QJKEILOBDKG)
				{
					num2 = this.MMHQFDMKQDQ - num4;
				}
				this.GEDMLDGKJNC = false;
				base.GPONHFNLHCN.GQEBOLFGLDE = true;
			}
			return this.QMEMFMDBHLI(num - this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), num2 - this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM));
		}
		return HELGNNDIDCI;
	}

	// Token: 0x06007129 RID: 28969 RVA: 0x000296AF File Offset: 0x000278AF
	public void HIJFKONKHID(int BGBMIEJJQKC)
	{
		this.GKLLDJLQPMM = BGBMIEJJQKC;
	}

	// Token: 0x0600712A RID: 28970 RVA: 0x0002968F File Offset: 0x0002788F
	protected virtual void DQPLIHHGNKM()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.CQCBELCFQBK(this);
		base.GPONHFNLHCN.QNDGKBBGHNK(this);
	}

	// Token: 0x0600712B RID: 28971 RVA: 0x000296E4 File Offset: 0x000278E4
	protected virtual void HPMKHDFJMNQ()
	{
		base.Awake();
		base.GPONHFNLHCN.JKNBMCKEBOF(this);
		base.GPONHFNLHCN.CIDMBQQGPNM(this);
	}

	// Token: 0x0600712C RID: 28972 RVA: 0x0036C3B0 File Offset: 0x0036A5B0
	public void CLIOPONMDDQ(OLLILOPJNHQ BGBMIEJJQKC)
	{
		this.GICJLBDMMEQ = BGBMIEJJQKC.GICJLBDMMEQ;
		this.PELBNKEHOHF = BGBMIEJJQKC.PELBNKEHOHF;
		this.MMHQFDMKQDQ = BGBMIEJJQKC.MMHQFDMKQDQ;
		this.IKDQPKGPPEH = BGBMIEJJQKC.IKDQPKGPPEH;
		this.BIPDHOPHDMK = BGBMIEJJQKC.BIPDHOPHDMK;
		this.QBHHBPBKQDJ = BGBMIEJJQKC.QBHHBPBKQDJ;
		this.DFFQECIDMDO = BGBMIEJJQKC.DFFQECIDMDO;
		this.IGPBFPCKNOG = BGBMIEJJQKC.IGPBFPCKNOG;
		this.JGJEPKHCBGP = BGBMIEJJQKC.JGJEPKHCBGP;
	}

	// Token: 0x0600712D RID: 28973 RVA: 0x0002967F File Offset: 0x0002787F
	public int HKOBLQKDNGP()
	{
		return this.GKLLDJLQPMM;
	}

	// Token: 0x0600712E RID: 28974 RVA: 0x000296AF File Offset: 0x000278AF
	public void ILKMGLINFQM(int BGBMIEJJQKC)
	{
		this.GKLLDJLQPMM = BGBMIEJJQKC;
	}

	// Token: 0x0600712F RID: 28975 RVA: 0x0002970D File Offset: 0x0002790D
	protected virtual void OHNCEMNBBPF()
	{
		base.Awake();
		base.GPONHFNLHCN.JKNBMCKEBOF(this);
		base.GPONHFNLHCN.NODLKQNBMFD(this);
	}

	// Token: 0x06007130 RID: 28976 RVA: 0x00029687 File Offset: 0x00027887
	public int DEMOKIIGLPH()
	{
		return this.IEDKDIJGNNO;
	}

	// Token: 0x06007131 RID: 28977 RVA: 0x000296AF File Offset: 0x000278AF
	public void GOIEDHIOPBI(int BGBMIEJJQKC)
	{
		this.GKLLDJLQPMM = BGBMIEJJQKC;
	}

	// Token: 0x06007133 RID: 28979 RVA: 0x00029704 File Offset: 0x00027904
	public void HLDNIMIILII(int BGBMIEJJQKC)
	{
		this.IEDKDIJGNNO = BGBMIEJJQKC;
	}

	// Token: 0x06007134 RID: 28980 RVA: 0x00029704 File Offset: 0x00027904
	public void FQGFBLJHBPO(int BGBMIEJJQKC)
	{
		this.IEDKDIJGNNO = BGBMIEJJQKC;
	}

	// Token: 0x06007135 RID: 28981 RVA: 0x0036C3B0 File Offset: 0x0036A5B0
	public void FPOHKDFOGKB(OLLILOPJNHQ BGBMIEJJQKC)
	{
		this.GICJLBDMMEQ = BGBMIEJJQKC.GICJLBDMMEQ;
		this.PELBNKEHOHF = BGBMIEJJQKC.PELBNKEHOHF;
		this.MMHQFDMKQDQ = BGBMIEJJQKC.MMHQFDMKQDQ;
		this.IKDQPKGPPEH = BGBMIEJJQKC.IKDQPKGPPEH;
		this.BIPDHOPHDMK = BGBMIEJJQKC.BIPDHOPHDMK;
		this.QBHHBPBKQDJ = BGBMIEJJQKC.QBHHBPBKQDJ;
		this.DFFQECIDMDO = BGBMIEJJQKC.DFFQECIDMDO;
		this.IGPBFPCKNOG = BGBMIEJJQKC.IGPBFPCKNOG;
		this.JGJEPKHCBGP = BGBMIEJJQKC.JGJEPKHCBGP;
	}

	// Token: 0x04001816 RID: 6166
	public static string OPGNGFNJDDP = "Numeric Boundaries";

	// Token: 0x04001817 RID: 6167
	public Action NFKPHODMHLK;

	// Token: 0x04001818 RID: 6168
	public Action EBHHEFPJIKL;

	// Token: 0x04001819 RID: 6169
	public bool GICJLBDMMEQ = true;

	// Token: 0x0400181A RID: 6170
	public bool PELBNKEHOHF;

	// Token: 0x0400181B RID: 6171
	public float MMHQFDMKQDQ = 10f;

	// Token: 0x0400181C RID: 6172
	public float MJJNGHFJEOI;

	// Token: 0x0400181D RID: 6173
	public bool IKDQPKGPPEH = true;

	// Token: 0x0400181E RID: 6174
	public float BIPDHOPHDMK = -10f;

	// Token: 0x0400181F RID: 6175
	public float CBHMJNDMNOE;

	// Token: 0x04001820 RID: 6176
	public bool QBHHBPBKQDJ;

	// Token: 0x04001821 RID: 6177
	public float DFFQECIDMDO = -10f;

	// Token: 0x04001822 RID: 6178
	public float CLGBNOOJKQK;

	// Token: 0x04001823 RID: 6179
	public bool IGPBFPCKNOG;

	// Token: 0x04001824 RID: 6180
	public float JGJEPKHCBGP = 10f;

	// Token: 0x04001825 RID: 6181
	public float CJJLGEHJIBE;

	// Token: 0x04001826 RID: 6182
	public bool DFBPNMPBQGB;

	// Token: 0x04001827 RID: 6183
	public bool GEDMLDGKJNC;

	// Token: 0x04001828 RID: 6184
	public Coroutine DHBCIOLBKGH;

	// Token: 0x04001829 RID: 6185
	public Coroutine JKGKIMMBJOQ;

	// Token: 0x0400182A RID: 6186
	public Coroutine BGDCLFNFMLK;

	// Token: 0x0400182B RID: 6187
	public Coroutine GOOHBPLJQIF;

	// Token: 0x0400182C RID: 6188
	public LELCIPBNCCB MMKHBFGFDQO;

	// Token: 0x0400182D RID: 6189
	public Coroutine JJLDKIHQJGG;

	// Token: 0x0400182E RID: 6190
	public bool IOQOOBMCCCC;

	// Token: 0x0400182F RID: 6191
	public bool HIOIMFMJMJJ;

	// Token: 0x04001830 RID: 6192
	public bool QJKEILOBDKG = true;

	// Token: 0x04001831 RID: 6193
	[Range(0f, 4f)]
	public float KFOBQELOFIC = 0.5f;

	// Token: 0x04001832 RID: 6194
	[Range(0f, 0.5f)]
	public float QHLFLPJEOJQ = 0.1f;

	// Token: 0x04001833 RID: 6195
	private float NFKHMNIEFJP;

	// Token: 0x04001834 RID: 6196
	private float NPDGNBJPDCP;

	// Token: 0x04001835 RID: 6197
	private int IEDKDIJGNNO = 4000;

	// Token: 0x04001836 RID: 6198
	private int GKLLDJLQPMM = 2000;
}
