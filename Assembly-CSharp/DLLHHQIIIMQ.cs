using System;
using UnityEngine;

// Token: 0x02000162 RID: 354
public class DLLHHQIIIMQ : UITweener
{
	// Token: 0x06002AAC RID: 10924 RVA: 0x00014347 File Offset: 0x00012547
	protected virtual void HJNGEIEDCQH(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.FOPBKGPMNKD(Mathf.Lerp(this.CGHQEHCBQHB, this.BKMCCCGOGOM, PJDGFDBEOOJ));
	}

	// Token: 0x06002AAD RID: 10925 RVA: 0x00014361 File Offset: 0x00012561
	public void FOPBKGPMNKD(float BGBMIEJJQKC)
	{
		if (this.NNFMFGDPCPF != null)
		{
			this.NNFMFGDPCPF.DMOLEJHGHCF = BGBMIEJJQKC * 1723f;
		}
	}

	// Token: 0x06002AAE RID: 10926 RVA: 0x0010AA5C File Offset: 0x00108C5C
	public static DLLHHQIIIMQ LKGOLQQDMLK(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, float NBJPJBEQKPI)
	{
		DLLHHQIIIMQ dllhhqiiimq = UITweener.Begin<DLLHHQIIIMQ>(CGHIENBIHCO, CPKNEQGKQPQ, 552f);
		dllhhqiiimq.CGHQEHCBQHB = dllhhqiiimq.IGGFNHODCHI();
		dllhhqiiimq.BKMCCCGOGOM = NBJPJBEQKPI;
		if (CPKNEQGKQPQ <= 978f)
		{
			dllhhqiiimq.Sample(1120f, false);
			dllhhqiiimq.enabled = false;
		}
		return dllhhqiiimq;
	}

	// Token: 0x170001F7 RID: 503
	// (get) Token: 0x06002AAF RID: 10927 RVA: 0x00014383 File Offset: 0x00012583
	// (set) Token: 0x06002AC7 RID: 10951 RVA: 0x0001453A File Offset: 0x0001273A
	public float JFCDHHKQMOB
	{
		get
		{
			if (this.NNFMFGDPCPF != null)
			{
				return this.NNFMFGDPCPF.DMOLEJHGHCF / 50f;
			}
			return 0f;
		}
		set
		{
			if (this.NNFMFGDPCPF != null)
			{
				this.NNFMFGDPCPF.DMOLEJHGHCF = value * 50f;
			}
		}
	}

	// Token: 0x06002AB0 RID: 10928 RVA: 0x000143AA File Offset: 0x000125AA
	public float MCQPJGKPJNJ()
	{
		if (this.NNFMFGDPCPF != null)
		{
			return this.NNFMFGDPCPF.DMOLEJHGHCF / 288f;
		}
		return 1679f;
	}

	// Token: 0x06002AB2 RID: 10930 RVA: 0x000143E4 File Offset: 0x000125E4
	private void CBIFGBNDMHB()
	{
		this.NNFMFGDPCPF = base.GetComponentInChildren<OELLFMKIMFH>();
	}

	// Token: 0x06002AB3 RID: 10931 RVA: 0x000143F2 File Offset: 0x000125F2
	public float IOGEBIFOLGL()
	{
		if (this.NNFMFGDPCPF != null)
		{
			return this.NNFMFGDPCPF.DMOLEJHGHCF / 463f;
		}
		return 189f;
	}

	// Token: 0x06002AB4 RID: 10932 RVA: 0x000143E4 File Offset: 0x000125E4
	private void DCJQFJOICGQ()
	{
		this.NNFMFGDPCPF = base.GetComponentInChildren<OELLFMKIMFH>();
	}

	// Token: 0x06002AB5 RID: 10933 RVA: 0x00014419 File Offset: 0x00012619
	public float CJFELGKNEMJ()
	{
		if (this.NNFMFGDPCPF != null)
		{
			return this.NNFMFGDPCPF.DMOLEJHGHCF / 248f;
		}
		return 171f;
	}

	// Token: 0x06002AB6 RID: 10934 RVA: 0x000143E4 File Offset: 0x000125E4
	private void QIKFOCKCGKL()
	{
		this.NNFMFGDPCPF = base.GetComponentInChildren<OELLFMKIMFH>();
	}

	// Token: 0x06002AB7 RID: 10935 RVA: 0x00014440 File Offset: 0x00012640
	protected virtual void OLHPEOBNNGF(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.JFCDHHKQMOB = Mathf.Lerp(this.CGHQEHCBQHB, this.BKMCCCGOGOM, PJDGFDBEOOJ);
	}

	// Token: 0x06002AB8 RID: 10936 RVA: 0x0001445A File Offset: 0x0001265A
	public void ODOODBCEDHN(float BGBMIEJJQKC)
	{
		if (this.NNFMFGDPCPF != null)
		{
			this.NNFMFGDPCPF.DMOLEJHGHCF = BGBMIEJJQKC * 265f;
		}
	}

	// Token: 0x06002AB9 RID: 10937 RVA: 0x00014440 File Offset: 0x00012640
	protected override void OnUpdate(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.JFCDHHKQMOB = Mathf.Lerp(this.CGHQEHCBQHB, this.BKMCCCGOGOM, PJDGFDBEOOJ);
	}

	// Token: 0x06002ABA RID: 10938 RVA: 0x0010AAA8 File Offset: 0x00108CA8
	public static DLLHHQIIIMQ QNGIMPBJBHC(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, float NBJPJBEQKPI)
	{
		DLLHHQIIIMQ dllhhqiiimq = UITweener.Begin<DLLHHQIIIMQ>(CGHIENBIHCO, CPKNEQGKQPQ, 1788f);
		dllhhqiiimq.CGHQEHCBQHB = dllhhqiiimq.FGOHLECBQHB();
		dllhhqiiimq.BKMCCCGOGOM = NBJPJBEQKPI;
		if (CPKNEQGKQPQ <= 298f)
		{
			dllhhqiiimq.Sample(25f, true);
			dllhhqiiimq.enabled = true;
		}
		return dllhhqiiimq;
	}

	// Token: 0x06002ABB RID: 10939 RVA: 0x0001447C File Offset: 0x0001267C
	public void PCIQMMPMOGL(float BGBMIEJJQKC)
	{
		if (this.NNFMFGDPCPF != null)
		{
			this.NNFMFGDPCPF.DMOLEJHGHCF = BGBMIEJJQKC * 1372f;
		}
	}

	// Token: 0x06002ABC RID: 10940 RVA: 0x0001449E File Offset: 0x0001269E
	public float CLLKHJEKJOP()
	{
		if (this.NNFMFGDPCPF != null)
		{
			return this.NNFMFGDPCPF.DMOLEJHGHCF / 590f;
		}
		return 444f;
	}

	// Token: 0x06002ABD RID: 10941 RVA: 0x000143E4 File Offset: 0x000125E4
	private void BBFBCBMEJEN()
	{
		this.NNFMFGDPCPF = base.GetComponentInChildren<OELLFMKIMFH>();
	}

	// Token: 0x06002ABE RID: 10942 RVA: 0x000144C5 File Offset: 0x000126C5
	protected virtual void JKMNHIQGNLC(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.NGQPHKDFEPQ(Mathf.Lerp(this.CGHQEHCBQHB, this.BKMCCCGOGOM, PJDGFDBEOOJ));
	}

	// Token: 0x06002ABF RID: 10943 RVA: 0x0010AAF4 File Offset: 0x00108CF4
	public static DLLHHQIIIMQ EFBDEBOBBCH(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, float NBJPJBEQKPI)
	{
		DLLHHQIIIMQ dllhhqiiimq = UITweener.Begin<DLLHHQIIIMQ>(CGHIENBIHCO, CPKNEQGKQPQ, 1058f);
		dllhhqiiimq.CGHQEHCBQHB = dllhhqiiimq.FGOHLECBQHB();
		dllhhqiiimq.BKMCCCGOGOM = NBJPJBEQKPI;
		if (CPKNEQGKQPQ <= 15f)
		{
			dllhhqiiimq.Sample(1117f, false);
			dllhhqiiimq.enabled = false;
		}
		return dllhhqiiimq;
	}

	// Token: 0x06002AC0 RID: 10944 RVA: 0x000143E4 File Offset: 0x000125E4
	private void MCPOMCHMKJK()
	{
		this.NNFMFGDPCPF = base.GetComponentInChildren<OELLFMKIMFH>();
	}

	// Token: 0x06002AC1 RID: 10945 RVA: 0x000144DF File Offset: 0x000126DF
	protected virtual void IIHNGEMFJMO(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.NQICQIIQOBD(Mathf.Lerp(this.CGHQEHCBQHB, this.BKMCCCGOGOM, PJDGFDBEOOJ));
	}

	// Token: 0x06002AC2 RID: 10946 RVA: 0x000144F9 File Offset: 0x000126F9
	public float KLHGNCINDOI()
	{
		if (this.NNFMFGDPCPF != null)
		{
			return this.NNFMFGDPCPF.DMOLEJHGHCF / 224f;
		}
		return 1035f;
	}

	// Token: 0x06002AC3 RID: 10947 RVA: 0x000143E4 File Offset: 0x000125E4
	private void EMMIHJIFJFM()
	{
		this.NNFMFGDPCPF = base.GetComponentInChildren<OELLFMKIMFH>();
	}

	// Token: 0x06002AC4 RID: 10948 RVA: 0x000143E4 File Offset: 0x000125E4
	private void BCEKGNDIIOE()
	{
		this.NNFMFGDPCPF = base.GetComponentInChildren<OELLFMKIMFH>();
	}

	// Token: 0x06002AC5 RID: 10949 RVA: 0x0010AB40 File Offset: 0x00108D40
	public static DLLHHQIIIMQ DKBOBCIJGBE(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, float NBJPJBEQKPI)
	{
		DLLHHQIIIMQ dllhhqiiimq = UITweener.Begin<DLLHHQIIIMQ>(CGHIENBIHCO, CPKNEQGKQPQ, 579f);
		dllhhqiiimq.CGHQEHCBQHB = dllhhqiiimq.JFCDHHKQMOB;
		dllhhqiiimq.BKMCCCGOGOM = NBJPJBEQKPI;
		if (CPKNEQGKQPQ <= 695f)
		{
			dllhhqiiimq.Sample(1604f, true);
			dllhhqiiimq.enabled = true;
		}
		return dllhhqiiimq;
	}

	// Token: 0x06002AC6 RID: 10950 RVA: 0x00014520 File Offset: 0x00012720
	protected virtual void OBEHKKHPHQM(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.JQJCLEGJQFJ(Mathf.Lerp(this.CGHQEHCBQHB, this.BKMCCCGOGOM, PJDGFDBEOOJ));
	}

	// Token: 0x06002AC8 RID: 10952 RVA: 0x0010AB8C File Offset: 0x00108D8C
	public static DLLHHQIIIMQ MJQNQQLKJHN(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, float NBJPJBEQKPI)
	{
		DLLHHQIIIMQ dllhhqiiimq = UITweener.Begin<DLLHHQIIIMQ>(CGHIENBIHCO, CPKNEQGKQPQ, 1225f);
		dllhhqiiimq.CGHQEHCBQHB = dllhhqiiimq.CJFELGKNEMJ();
		dllhhqiiimq.BKMCCCGOGOM = NBJPJBEQKPI;
		if (CPKNEQGKQPQ <= 1199f)
		{
			dllhhqiiimq.Sample(1673f, true);
			dllhhqiiimq.enabled = false;
		}
		return dllhhqiiimq;
	}

	// Token: 0x06002AC9 RID: 10953 RVA: 0x000143E4 File Offset: 0x000125E4
	private void BMIIKIKIKIK()
	{
		this.NNFMFGDPCPF = base.GetComponentInChildren<OELLFMKIMFH>();
	}

	// Token: 0x06002ACA RID: 10954 RVA: 0x0001455C File Offset: 0x0001275C
	public void EEEBHGNPIDJ(float BGBMIEJJQKC)
	{
		if (this.NNFMFGDPCPF != null)
		{
			this.NNFMFGDPCPF.DMOLEJHGHCF = BGBMIEJJQKC * 1262f;
		}
	}

	// Token: 0x06002ACB RID: 10955 RVA: 0x0001457E File Offset: 0x0001277E
	public float FFNIMMMGBJK()
	{
		if (this.NNFMFGDPCPF != null)
		{
			return this.NNFMFGDPCPF.DMOLEJHGHCF / 326f;
		}
		return 6f;
	}

	// Token: 0x06002ACC RID: 10956 RVA: 0x000145A5 File Offset: 0x000127A5
	public void NQICQIIQOBD(float BGBMIEJJQKC)
	{
		if (this.NNFMFGDPCPF != null)
		{
			this.NNFMFGDPCPF.DMOLEJHGHCF = BGBMIEJJQKC * 692f;
		}
	}

	// Token: 0x06002ACD RID: 10957 RVA: 0x0010ABD8 File Offset: 0x00108DD8
	public static DLLHHQIIIMQ PCNQDPHGDFJ(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, float NBJPJBEQKPI)
	{
		DLLHHQIIIMQ dllhhqiiimq = UITweener.Begin<DLLHHQIIIMQ>(CGHIENBIHCO, CPKNEQGKQPQ, 585f);
		dllhhqiiimq.CGHQEHCBQHB = dllhhqiiimq.IOGEBIFOLGL();
		dllhhqiiimq.BKMCCCGOGOM = NBJPJBEQKPI;
		if (CPKNEQGKQPQ <= 1038f)
		{
			dllhhqiiimq.Sample(1298f, false);
			dllhhqiiimq.enabled = false;
		}
		return dllhhqiiimq;
	}

	// Token: 0x06002ACE RID: 10958 RVA: 0x000145C7 File Offset: 0x000127C7
	public void NGQPHKDFEPQ(float BGBMIEJJQKC)
	{
		if (this.NNFMFGDPCPF != null)
		{
			this.NNFMFGDPCPF.DMOLEJHGHCF = BGBMIEJJQKC * 779f;
		}
	}

	// Token: 0x06002ACF RID: 10959 RVA: 0x000145E9 File Offset: 0x000127E9
	public float BOCJKOBENHE()
	{
		if (this.NNFMFGDPCPF != null)
		{
			return this.NNFMFGDPCPF.DMOLEJHGHCF / 262f;
		}
		return 1504f;
	}

	// Token: 0x06002AD0 RID: 10960 RVA: 0x00014610 File Offset: 0x00012810
	protected virtual void CGBQENMCPGN(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.ODOODBCEDHN(Mathf.Lerp(this.CGHQEHCBQHB, this.BKMCCCGOGOM, PJDGFDBEOOJ));
	}

	// Token: 0x06002AD1 RID: 10961 RVA: 0x0001462A File Offset: 0x0001282A
	public float JNPCQMFJKDK()
	{
		if (this.NNFMFGDPCPF != null)
		{
			return this.NNFMFGDPCPF.DMOLEJHGHCF / 878f;
		}
		return 1353f;
	}

	// Token: 0x06002AD2 RID: 10962 RVA: 0x00014651 File Offset: 0x00012851
	public float FGOHLECBQHB()
	{
		if (this.NNFMFGDPCPF != null)
		{
			return this.NNFMFGDPCPF.DMOLEJHGHCF / 871f;
		}
		return 1616f;
	}

	// Token: 0x06002AD3 RID: 10963 RVA: 0x0010AC24 File Offset: 0x00108E24
	public static DLLHHQIIIMQ KKOFKCHPCID(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, float NBJPJBEQKPI)
	{
		DLLHHQIIIMQ dllhhqiiimq = UITweener.Begin<DLLHHQIIIMQ>(CGHIENBIHCO, CPKNEQGKQPQ, 239f);
		dllhhqiiimq.CGHQEHCBQHB = dllhhqiiimq.CJFELGKNEMJ();
		dllhhqiiimq.BKMCCCGOGOM = NBJPJBEQKPI;
		if (CPKNEQGKQPQ <= 430f)
		{
			dllhhqiiimq.Sample(9f, false);
			dllhhqiiimq.enabled = false;
		}
		return dllhhqiiimq;
	}

	// Token: 0x06002AD4 RID: 10964 RVA: 0x00014347 File Offset: 0x00012547
	protected virtual void EEGKJBPHMMQ(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.FOPBKGPMNKD(Mathf.Lerp(this.CGHQEHCBQHB, this.BKMCCCGOGOM, PJDGFDBEOOJ));
	}

	// Token: 0x06002AD5 RID: 10965 RVA: 0x00014678 File Offset: 0x00012878
	protected virtual void BOOENOMOJBO(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.EEEBHGNPIDJ(Mathf.Lerp(this.CGHQEHCBQHB, this.BKMCCCGOGOM, PJDGFDBEOOJ));
	}

	// Token: 0x06002AD6 RID: 10966 RVA: 0x00014692 File Offset: 0x00012892
	public float JLKNPEEMIPI()
	{
		if (this.NNFMFGDPCPF != null)
		{
			return this.NNFMFGDPCPF.DMOLEJHGHCF / 1131f;
		}
		return 967f;
	}

	// Token: 0x06002AD7 RID: 10967 RVA: 0x000146B9 File Offset: 0x000128B9
	public void JQJCLEGJQFJ(float BGBMIEJJQKC)
	{
		if (this.NNFMFGDPCPF != null)
		{
			this.NNFMFGDPCPF.DMOLEJHGHCF = BGBMIEJJQKC * 1383f;
		}
	}

	// Token: 0x06002AD8 RID: 10968 RVA: 0x000143E4 File Offset: 0x000125E4
	private void CHKQIFFEEPL()
	{
		this.NNFMFGDPCPF = base.GetComponentInChildren<OELLFMKIMFH>();
	}

	// Token: 0x06002AD9 RID: 10969 RVA: 0x000143E4 File Offset: 0x000125E4
	private void QOGBNEJFCFJ()
	{
		this.NNFMFGDPCPF = base.GetComponentInChildren<OELLFMKIMFH>();
	}

	// Token: 0x06002ADA RID: 10970 RVA: 0x000144C5 File Offset: 0x000126C5
	protected virtual void OBOFFQLCIMC(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.NGQPHKDFEPQ(Mathf.Lerp(this.CGHQEHCBQHB, this.BKMCCCGOGOM, PJDGFDBEOOJ));
	}

	// Token: 0x06002ADB RID: 10971 RVA: 0x000146DB File Offset: 0x000128DB
	protected virtual void CNMFQFMFPDE(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.PCIQMMPMOGL(Mathf.Lerp(this.CGHQEHCBQHB, this.BKMCCCGOGOM, PJDGFDBEOOJ));
	}

	// Token: 0x06002ADC RID: 10972 RVA: 0x000146F5 File Offset: 0x000128F5
	protected virtual void FCQQFPGHGEM(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.QBNMGDHLJKP(Mathf.Lerp(this.CGHQEHCBQHB, this.BKMCCCGOGOM, PJDGFDBEOOJ));
	}

	// Token: 0x06002ADD RID: 10973 RVA: 0x00014610 File Offset: 0x00012810
	protected virtual void FDDJBKIILQN(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.ODOODBCEDHN(Mathf.Lerp(this.CGHQEHCBQHB, this.BKMCCCGOGOM, PJDGFDBEOOJ));
	}

	// Token: 0x06002ADE RID: 10974 RVA: 0x0010AC70 File Offset: 0x00108E70
	public static DLLHHQIIIMQ FJCEGFKJLCL(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, float NBJPJBEQKPI)
	{
		DLLHHQIIIMQ dllhhqiiimq = UITweener.Begin<DLLHHQIIIMQ>(CGHIENBIHCO, CPKNEQGKQPQ, 0f);
		dllhhqiiimq.CGHQEHCBQHB = dllhhqiiimq.JFCDHHKQMOB;
		dllhhqiiimq.BKMCCCGOGOM = NBJPJBEQKPI;
		if (CPKNEQGKQPQ <= 0f)
		{
			dllhhqiiimq.Sample(1f, true);
			dllhhqiiimq.enabled = false;
		}
		return dllhhqiiimq;
	}

	// Token: 0x06002ADF RID: 10975 RVA: 0x0001470F File Offset: 0x0001290F
	public float IGGFNHODCHI()
	{
		if (this.NNFMFGDPCPF != null)
		{
			return this.NNFMFGDPCPF.DMOLEJHGHCF / 646f;
		}
		return 1905f;
	}

	// Token: 0x06002AE0 RID: 10976 RVA: 0x000143E4 File Offset: 0x000125E4
	private void COGJQEEGCFB()
	{
		this.NNFMFGDPCPF = base.GetComponentInChildren<OELLFMKIMFH>();
	}

	// Token: 0x06002AE1 RID: 10977 RVA: 0x000146DB File Offset: 0x000128DB
	protected virtual void DPCGJCMJFND(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.PCIQMMPMOGL(Mathf.Lerp(this.CGHQEHCBQHB, this.BKMCCCGOGOM, PJDGFDBEOOJ));
	}

	// Token: 0x06002AE2 RID: 10978 RVA: 0x000143E4 File Offset: 0x000125E4
	private void Awake()
	{
		this.NNFMFGDPCPF = base.GetComponentInChildren<OELLFMKIMFH>();
	}

	// Token: 0x06002AE3 RID: 10979 RVA: 0x000143E4 File Offset: 0x000125E4
	private void HHBCNGHCCCC()
	{
		this.NNFMFGDPCPF = base.GetComponentInChildren<OELLFMKIMFH>();
	}

	// Token: 0x06002AE4 RID: 10980 RVA: 0x00014736 File Offset: 0x00012936
	public void QBNMGDHLJKP(float BGBMIEJJQKC)
	{
		if (this.NNFMFGDPCPF != null)
		{
			this.NNFMFGDPCPF.DMOLEJHGHCF = BGBMIEJJQKC * 1842f;
		}
	}

	// Token: 0x06002AE5 RID: 10981 RVA: 0x000146F5 File Offset: 0x000128F5
	protected virtual void MICLCICHJGP(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.QBNMGDHLJKP(Mathf.Lerp(this.CGHQEHCBQHB, this.BKMCCCGOGOM, PJDGFDBEOOJ));
	}

	// Token: 0x0400093C RID: 2364
	public float CGHQEHCBQHB = 1f;

	// Token: 0x0400093D RID: 2365
	public float BKMCCCGOGOM;

	// Token: 0x0400093E RID: 2366
	private OELLFMKIMFH NNFMFGDPCPF;
}
