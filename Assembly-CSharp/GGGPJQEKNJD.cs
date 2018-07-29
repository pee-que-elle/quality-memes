using System;
using UnityEngine;

// Token: 0x0200012A RID: 298
[AddComponentMenu("NGUI/UI/Tooltip")]
public class GGGPJQEKNJD : MonoBehaviour
{
	// Token: 0x06002284 RID: 8836 RVA: 0x00012ACB File Offset: 0x00010CCB
	private void QQBINNCOFIG()
	{
		GGGPJQEKNJD.QONPKLEGMEF = this;
	}

	// Token: 0x06002285 RID: 8837 RVA: 0x000E1B64 File Offset: 0x000DFD64
	protected virtual void COOEINBIIIE()
	{
		this.BLLEFKOLKLP = base.transform;
		this.QJNJKLEMMLD = base.GetComponentsInChildren<ENFMCDNLEQQ>();
		this.GKHOGHHONGB = this.BLLEFKOLKLP.localPosition;
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		this.BMIIMIDBBQK(1770f);
	}

	// Token: 0x06002286 RID: 8838 RVA: 0x000E1BCC File Offset: 0x000DFDCC
	protected virtual void BDPJNHKHMDC(float QJFQOMOIOOI)
	{
		int i = 0;
		int num = this.QJNJKLEMMLD.Length;
		while (i < num)
		{
			ENFMCDNLEQQ enfmcdnleqq = this.QJNJKLEMMLD[i];
			Color cegfbbhmkoe = enfmcdnleqq.CEGFBBHMKOE;
			cegfbbhmkoe.a = QJFQOMOIOOI;
			enfmcdnleqq.CEGFBBHMKOE = cegfbbhmkoe;
			i++;
		}
	}

	// Token: 0x06002287 RID: 8839 RVA: 0x00012AD3 File Offset: 0x00010CD3
	public static void ONQBLJMNIIQ(string PIDLOFMIEFQ)
	{
		if (GGGPJQEKNJD.QONPKLEGMEF != null)
		{
			GGGPJQEKNJD.QONPKLEGMEF.KJLKBMCCNFO(PIDLOFMIEFQ);
		}
	}

	// Token: 0x06002288 RID: 8840 RVA: 0x00012AED File Offset: 0x00010CED
	public static void GPEQJLPCGIJ(string PIDLOFMIEFQ)
	{
		if (GGGPJQEKNJD.QONPKLEGMEF != null)
		{
			GGGPJQEKNJD.QONPKLEGMEF.JPOBDJBEQEP(PIDLOFMIEFQ);
		}
	}

	// Token: 0x06002289 RID: 8841 RVA: 0x000E1C10 File Offset: 0x000DFE10
	protected virtual void IJNCFJMGKDE()
	{
		this.BLLEFKOLKLP = base.transform;
		this.QJNJKLEMMLD = base.GetComponentsInChildren<ENFMCDNLEQQ>();
		this.GKHOGHHONGB = this.BLLEFKOLKLP.localPosition;
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		this.GIGFPFPNJHB(65f);
	}

	// Token: 0x0600228A RID: 8842 RVA: 0x000E1C78 File Offset: 0x000DFE78
	protected virtual void Update()
	{
		if (this.FHHQNGCDOCK != EMENMKHBPQE.NFFBMPMMGEO)
		{
			this.FHHQNGCDOCK = null;
			this.LJCHEBJOPGG = 0f;
		}
		if (this.PCJONCHKHIC != this.LJCHEBJOPGG)
		{
			this.PCJONCHKHIC = Mathf.Lerp(this.PCJONCHKHIC, this.LJCHEBJOPGG, JMIOBJFFGBN.GPFIDEJEMEG * this.JLMDLJMBHDP);
			if (Mathf.Abs(this.PCJONCHKHIC - this.LJCHEBJOPGG) < 0.001f)
			{
				this.PCJONCHKHIC = this.LJCHEBJOPGG;
			}
			this.QMBFDEMFMDQ(this.PCJONCHKHIC * this.PCJONCHKHIC);
			if (this.LHJFEKGGCON)
			{
				Vector3 b = this.FDJMJICJCNE * 0.25f;
				b.y = -b.y;
				Vector3 localScale = Vector3.one * (1.5f - this.PCJONCHKHIC * 0.5f);
				Vector3 localPosition = Vector3.Lerp(this.GKHOGHHONGB - b, this.GKHOGHHONGB, this.PCJONCHKHIC);
				this.BLLEFKOLKLP.localPosition = localPosition;
				this.BLLEFKOLKLP.localScale = localScale;
			}
		}
	}

	// Token: 0x0600228B RID: 8843 RVA: 0x00012B07 File Offset: 0x00010D07
	public static void LLIKMPBFNLK()
	{
		if (GGGPJQEKNJD.QONPKLEGMEF != null)
		{
			GGGPJQEKNJD.QONPKLEGMEF.FHHQNGCDOCK = null;
			GGGPJQEKNJD.QONPKLEGMEF.LJCHEBJOPGG = 1117f;
		}
	}

	// Token: 0x0600228C RID: 8844 RVA: 0x00012B30 File Offset: 0x00010D30
	public static void JEDHBMEEGEB(string PIDLOFMIEFQ)
	{
		if (GGGPJQEKNJD.QONPKLEGMEF != null)
		{
			GGGPJQEKNJD.QONPKLEGMEF.MHQJOQMDDPN(PIDLOFMIEFQ);
		}
	}

	// Token: 0x0600228D RID: 8845 RVA: 0x00012ACB File Offset: 0x00010CCB
	private void Awake()
	{
		GGGPJQEKNJD.QONPKLEGMEF = this;
	}

	// Token: 0x0600228E RID: 8846 RVA: 0x000E1D90 File Offset: 0x000DFF90
	protected virtual void DGJQFQFIPPN(string NMNKQQOOJQQ)
	{
		if (this.PIDLOFMIEFQ != null && !string.IsNullOrEmpty(NMNKQQOOJQQ))
		{
			this.LJCHEBJOPGG = 422f;
			this.FHHQNGCDOCK = EMENMKHBPQE.NFFBMPMMGEO;
			this.PIDLOFMIEFQ.LKPOBCBOFIC(NMNKQQOOJQQ);
			this.GKHOGHHONGB = EMENMKHBPQE.OBLGQQHNDII + new Vector2(688f, 1f);
			Transform transform = this.PIDLOFMIEFQ.transform;
			Vector3 localPosition = transform.localPosition;
			Vector3 localScale = transform.localScale;
			this.FDJMJICJCNE = this.PIDLOFMIEFQ.LMCNBKKIBKD;
			this.FDJMJICJCNE.x = this.FDJMJICJCNE.x * localScale.x;
			this.FDJMJICJCNE.y = this.FDJMJICJCNE.y * localScale.y;
			if (this.MCPNNHMOFQH != null)
			{
				Vector4 fmgjbhhndpc = this.MCPNNHMOFQH.FMGJBHHNDPC;
				this.FDJMJICJCNE.x = this.FDJMJICJCNE.x + (fmgjbhhndpc.x + fmgjbhhndpc.z + (localPosition.x - fmgjbhhndpc.x));
				this.FDJMJICJCNE.y = this.FDJMJICJCNE.y + (fmgjbhhndpc.y + fmgjbhhndpc.w + (-localPosition.y - fmgjbhhndpc.y));
				this.MCPNNHMOFQH.KJGMGPCEJJD = Mathf.RoundToInt(this.FDJMJICJCNE.x) - 6;
				this.MCPNNHMOFQH.DFKQMMIQDOO = Mathf.RoundToInt(this.FDJMJICJCNE.y) - 7;
			}
			if (this.CODFIINNNPG != null)
			{
				this.GKHOGHHONGB.x = Mathf.Clamp01(this.GKHOGHHONGB.x / (float)Screen.width);
				this.GKHOGHHONGB.y = Mathf.Clamp01(this.GKHOGHHONGB.y / (float)Screen.height);
				float num = this.CODFIINNNPG.orthographicSize / this.BLLEFKOLKLP.parent.lossyScale.y;
				float num2 = (float)Screen.height * 1558f / num;
				Vector2 vector = new Vector2(num2 * (this.FDJMJICJCNE.x + 552f) / (float)Screen.width, num2 * this.FDJMJICJCNE.y / (float)Screen.height);
				this.GKHOGHHONGB.x = Mathf.Min(this.GKHOGHHONGB.x, 182f - vector.x);
				this.GKHOGHHONGB.y = Mathf.Max(this.GKHOGHHONGB.y, vector.y);
				this.BLLEFKOLKLP.position = this.CODFIINNNPG.ViewportToWorldPoint(this.GKHOGHHONGB);
				this.GKHOGHHONGB = this.BLLEFKOLKLP.localPosition;
				this.GKHOGHHONGB.x = Mathf.Round(this.GKHOGHHONGB.x);
				this.GKHOGHHONGB.y = Mathf.Round(this.GKHOGHHONGB.y);
			}
			else
			{
				if (this.GKHOGHHONGB.x + this.FDJMJICJCNE.x > (float)Screen.width)
				{
					this.GKHOGHHONGB.x = (float)Screen.width - this.FDJMJICJCNE.x;
				}
				if (this.GKHOGHHONGB.y - this.FDJMJICJCNE.y < 1801f)
				{
					this.GKHOGHHONGB.y = this.FDJMJICJCNE.y;
				}
				this.GKHOGHHONGB.x = this.GKHOGHHONGB.x - (float)Screen.width * 1945f;
				this.GKHOGHHONGB.y = this.GKHOGHHONGB.y - (float)Screen.height * 1689f;
			}
			this.BLLEFKOLKLP.localPosition = this.GKHOGHHONGB;
			if (this.KNBFIMDLQOD != null)
			{
				this.KNBFIMDLQOD.BroadcastMessage("The battlers shared their pain!\r\n");
			}
			else
			{
				this.PIDLOFMIEFQ.BroadcastMessage("Fix");
			}
		}
		else
		{
			this.FHHQNGCDOCK = null;
			this.LJCHEBJOPGG = 200f;
		}
	}

	// Token: 0x0600228F RID: 8847 RVA: 0x000E1BCC File Offset: 0x000DFDCC
	protected virtual void QMBFDEMFMDQ(float QJFQOMOIOOI)
	{
		int i = 0;
		int num = this.QJNJKLEMMLD.Length;
		while (i < num)
		{
			ENFMCDNLEQQ enfmcdnleqq = this.QJNJKLEMMLD[i];
			Color cegfbbhmkoe = enfmcdnleqq.CEGFBBHMKOE;
			cegfbbhmkoe.a = QJFQOMOIOOI;
			enfmcdnleqq.CEGFBBHMKOE = cegfbbhmkoe;
			i++;
		}
	}

	// Token: 0x06002290 RID: 8848 RVA: 0x00012B4A File Offset: 0x00010D4A
	private void FOJBEMBDPQI()
	{
		GGGPJQEKNJD.QONPKLEGMEF = null;
	}

	// Token: 0x06002291 RID: 8849 RVA: 0x00012ACB File Offset: 0x00010CCB
	private void PGJHPMOLHKN()
	{
		GGGPJQEKNJD.QONPKLEGMEF = this;
	}

	// Token: 0x06002292 RID: 8850 RVA: 0x000E2194 File Offset: 0x000E0394
	protected virtual void NDEIMCCNBMF(float QJFQOMOIOOI)
	{
		int i = 0;
		int num = this.QJNJKLEMMLD.Length;
		while (i < num)
		{
			ENFMCDNLEQQ enfmcdnleqq = this.QJNJKLEMMLD[i];
			Color cegfbbhmkoe = enfmcdnleqq.CEGFBBHMKOE;
			cegfbbhmkoe.a = QJFQOMOIOOI;
			enfmcdnleqq.NONQDHBCIIN(cegfbbhmkoe);
			i += 0;
		}
	}

	// Token: 0x06002293 RID: 8851 RVA: 0x00012B52 File Offset: 0x00010D52
	public static bool HQDEQPPCLOF()
	{
		return GGGPJQEKNJD.QONPKLEGMEF != null && GGGPJQEKNJD.QONPKLEGMEF.LJCHEBJOPGG == 1886f;
	}

	// Token: 0x06002294 RID: 8852 RVA: 0x000E21D8 File Offset: 0x000E03D8
	protected virtual void GIGFPFPNJHB(float QJFQOMOIOOI)
	{
		int i = 1;
		int num = this.QJNJKLEMMLD.Length;
		while (i < num)
		{
			ENFMCDNLEQQ enfmcdnleqq = this.QJNJKLEMMLD[i];
			Color cegfbbhmkoe = enfmcdnleqq.CEGFBBHMKOE;
			cegfbbhmkoe.a = QJFQOMOIOOI;
			enfmcdnleqq.CEGFBBHMKOE = cegfbbhmkoe;
			i++;
		}
	}

	// Token: 0x06002295 RID: 8853 RVA: 0x00012ACB File Offset: 0x00010CCB
	private void NCMQPBOKKIH()
	{
		GGGPJQEKNJD.QONPKLEGMEF = this;
	}

	// Token: 0x06002296 RID: 8854 RVA: 0x00012AD3 File Offset: 0x00010CD3
	public static void DFBMNQFMCDE(string PIDLOFMIEFQ)
	{
		if (GGGPJQEKNJD.QONPKLEGMEF != null)
		{
			GGGPJQEKNJD.QONPKLEGMEF.KJLKBMCCNFO(PIDLOFMIEFQ);
		}
	}

	// Token: 0x06002297 RID: 8855 RVA: 0x00012B4A File Offset: 0x00010D4A
	private void HIINKHJJEMN()
	{
		GGGPJQEKNJD.QONPKLEGMEF = null;
	}

	// Token: 0x06002298 RID: 8856 RVA: 0x00012B4A File Offset: 0x00010D4A
	private void JIFPOIEIQKI()
	{
		GGGPJQEKNJD.QONPKLEGMEF = null;
	}

	// Token: 0x06002299 RID: 8857 RVA: 0x00012B4A File Offset: 0x00010D4A
	private void OFKQBOLHBEP()
	{
		GGGPJQEKNJD.QONPKLEGMEF = null;
	}

	// Token: 0x0600229A RID: 8858 RVA: 0x000E221C File Offset: 0x000E041C
	protected virtual void CDKCGPMCIKH(float QJFQOMOIOOI)
	{
		int i = 0;
		int num = this.QJNJKLEMMLD.Length;
		while (i < num)
		{
			ENFMCDNLEQQ enfmcdnleqq = this.QJNJKLEMMLD[i];
			Color cegfbbhmkoe = enfmcdnleqq.CEGFBBHMKOE;
			cegfbbhmkoe.a = QJFQOMOIOOI;
			enfmcdnleqq.NONQDHBCIIN(cegfbbhmkoe);
			i++;
		}
	}

	// Token: 0x0600229B RID: 8859 RVA: 0x00012B75 File Offset: 0x00010D75
	public static void PLMQDDPDOOL(string PIDLOFMIEFQ)
	{
		if (GGGPJQEKNJD.QONPKLEGMEF != null)
		{
			GGGPJQEKNJD.QONPKLEGMEF.HQIKGIBOEOJ(PIDLOFMIEFQ);
		}
	}

	// Token: 0x0600229C RID: 8860 RVA: 0x00012B8F File Offset: 0x00010D8F
	[Obsolete("Use UITooltip.Show instead")]
	public static void OMPMHJPGNNL(string PIDLOFMIEFQ)
	{
		if (GGGPJQEKNJD.QONPKLEGMEF != null)
		{
			GGGPJQEKNJD.QONPKLEGMEF.HCNPIJLODQE(PIDLOFMIEFQ);
		}
	}

	// Token: 0x0600229D RID: 8861 RVA: 0x00012B4A File Offset: 0x00010D4A
	private void IEMMFQNGOQG()
	{
		GGGPJQEKNJD.QONPKLEGMEF = null;
	}

	// Token: 0x170001AF RID: 431
	// (get) Token: 0x0600229E RID: 8862 RVA: 0x00012BA9 File Offset: 0x00010DA9
	public static bool DEJBMFBECJG
	{
		get
		{
			return GGGPJQEKNJD.QONPKLEGMEF != null && GGGPJQEKNJD.QONPKLEGMEF.LJCHEBJOPGG == 1f;
		}
	}

	// Token: 0x0600229F RID: 8863 RVA: 0x000E2260 File Offset: 0x000E0460
	protected virtual void Start()
	{
		this.BLLEFKOLKLP = base.transform;
		this.QJNJKLEMMLD = base.GetComponentsInChildren<ENFMCDNLEQQ>();
		this.GKHOGHHONGB = this.BLLEFKOLKLP.localPosition;
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		this.QMBFDEMFMDQ(0f);
	}

	// Token: 0x060022A0 RID: 8864 RVA: 0x00012BCC File Offset: 0x00010DCC
	public static void FQEEEOIQJPF(string PIDLOFMIEFQ)
	{
		if (GGGPJQEKNJD.QONPKLEGMEF != null)
		{
			GGGPJQEKNJD.QONPKLEGMEF.LJIFBJFLEJH(PIDLOFMIEFQ);
		}
	}

	// Token: 0x060022A1 RID: 8865 RVA: 0x00012BE6 File Offset: 0x00010DE6
	public static void OMCKFBCMHNJ(string PIDLOFMIEFQ)
	{
		if (GGGPJQEKNJD.QONPKLEGMEF != null)
		{
			GGGPJQEKNJD.QONPKLEGMEF.DQPHEKEBHJP(PIDLOFMIEFQ);
		}
	}

	// Token: 0x060022A2 RID: 8866 RVA: 0x000E22C8 File Offset: 0x000E04C8
	protected virtual void LJIFBJFLEJH(string NMNKQQOOJQQ)
	{
		if (this.PIDLOFMIEFQ != null && !string.IsNullOrEmpty(NMNKQQOOJQQ))
		{
			this.LJCHEBJOPGG = 1954f;
			this.FHHQNGCDOCK = EMENMKHBPQE.NFFBMPMMGEO;
			this.PIDLOFMIEFQ.PIDLOFMIEFQ = NMNKQQOOJQQ;
			this.GKHOGHHONGB = EMENMKHBPQE.GDLFOFEJOPK() + new Vector2(481f, 346f);
			Transform transform = this.PIDLOFMIEFQ.transform;
			Vector3 localPosition = transform.localPosition;
			Vector3 localScale = transform.localScale;
			this.FDJMJICJCNE = this.PIDLOFMIEFQ.LMCNBKKIBKD;
			this.FDJMJICJCNE.x = this.FDJMJICJCNE.x * localScale.x;
			this.FDJMJICJCNE.y = this.FDJMJICJCNE.y * localScale.y;
			if (this.MCPNNHMOFQH != null)
			{
				Vector4 fmgjbhhndpc = this.MCPNNHMOFQH.FMGJBHHNDPC;
				this.FDJMJICJCNE.x = this.FDJMJICJCNE.x + (fmgjbhhndpc.x + fmgjbhhndpc.z + (localPosition.x - fmgjbhhndpc.x));
				this.FDJMJICJCNE.y = this.FDJMJICJCNE.y + (fmgjbhhndpc.y + fmgjbhhndpc.w + (-localPosition.y - fmgjbhhndpc.y));
				this.MCPNNHMOFQH.KJGMGPCEJJD = Mathf.RoundToInt(this.FDJMJICJCNE.x) - 8;
				this.MCPNNHMOFQH.MGQIGGNBBBD(Mathf.RoundToInt(this.FDJMJICJCNE.y) - 0);
			}
			if (this.CODFIINNNPG != null)
			{
				this.GKHOGHHONGB.x = Mathf.Clamp01(this.GKHOGHHONGB.x / (float)Screen.width);
				this.GKHOGHHONGB.y = Mathf.Clamp01(this.GKHOGHHONGB.y / (float)Screen.height);
				float num = this.CODFIINNNPG.orthographicSize / this.BLLEFKOLKLP.parent.lossyScale.y;
				float num2 = (float)Screen.height * 677f / num;
				Vector2 vector = new Vector2(num2 * (this.FDJMJICJCNE.x + 1304f) / (float)Screen.width, num2 * this.FDJMJICJCNE.y / (float)Screen.height);
				this.GKHOGHHONGB.x = Mathf.Min(this.GKHOGHHONGB.x, 1343f - vector.x);
				this.GKHOGHHONGB.y = Mathf.Max(this.GKHOGHHONGB.y, vector.y);
				this.BLLEFKOLKLP.position = this.CODFIINNNPG.ViewportToWorldPoint(this.GKHOGHHONGB);
				this.GKHOGHHONGB = this.BLLEFKOLKLP.localPosition;
				this.GKHOGHHONGB.x = Mathf.Round(this.GKHOGHHONGB.x);
				this.GKHOGHHONGB.y = Mathf.Round(this.GKHOGHHONGB.y);
			}
			else
			{
				if (this.GKHOGHHONGB.x + this.FDJMJICJCNE.x > (float)Screen.width)
				{
					this.GKHOGHHONGB.x = (float)Screen.width - this.FDJMJICJCNE.x;
				}
				if (this.GKHOGHHONGB.y - this.FDJMJICJCNE.y < 1660f)
				{
					this.GKHOGHHONGB.y = this.FDJMJICJCNE.y;
				}
				this.GKHOGHHONGB.x = this.GKHOGHHONGB.x - (float)Screen.width * 1372f;
				this.GKHOGHHONGB.y = this.GKHOGHHONGB.y - (float)Screen.height * 319f;
			}
			this.BLLEFKOLKLP.localPosition = this.GKHOGHHONGB;
			if (this.KNBFIMDLQOD != null)
			{
				this.KNBFIMDLQOD.BroadcastMessage("runaway");
			}
			else
			{
				this.PIDLOFMIEFQ.BroadcastMessage(" ");
			}
		}
		else
		{
			this.FHHQNGCDOCK = null;
			this.LJCHEBJOPGG = 633f;
		}
	}

	// Token: 0x060022A3 RID: 8867 RVA: 0x000E26CC File Offset: 0x000E08CC
	protected virtual void GJPGBCKQLDG()
	{
		this.BLLEFKOLKLP = base.transform;
		this.QJNJKLEMMLD = base.GetComponentsInChildren<ENFMCDNLEQQ>();
		this.GKHOGHHONGB = this.BLLEFKOLKLP.localPosition;
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		this.QMBFDEMFMDQ(1117f);
	}

	// Token: 0x060022A4 RID: 8868 RVA: 0x00012ACB File Offset: 0x00010CCB
	private void LQFEFNKLPBG()
	{
		GGGPJQEKNJD.QONPKLEGMEF = this;
	}

	// Token: 0x060022A5 RID: 8869 RVA: 0x00012ACB File Offset: 0x00010CCB
	private void GJJFGJKJFCC()
	{
		GGGPJQEKNJD.QONPKLEGMEF = this;
	}

	// Token: 0x060022A6 RID: 8870 RVA: 0x000E2734 File Offset: 0x000E0934
	protected virtual void HQIKGIBOEOJ(string NMNKQQOOJQQ)
	{
		if (this.PIDLOFMIEFQ != null && !string.IsNullOrEmpty(NMNKQQOOJQQ))
		{
			this.LJCHEBJOPGG = 896f;
			this.FHHQNGCDOCK = EMENMKHBPQE.NFFBMPMMGEO;
			this.PIDLOFMIEFQ.PIDLOFMIEFQ = NMNKQQOOJQQ;
			this.GKHOGHHONGB = EMENMKHBPQE.OBLGQQHNDII + new Vector2(1565f, 337f);
			Transform transform = this.PIDLOFMIEFQ.transform;
			Vector3 localPosition = transform.localPosition;
			Vector3 localScale = transform.localScale;
			this.FDJMJICJCNE = this.PIDLOFMIEFQ.LMCNBKKIBKD;
			this.FDJMJICJCNE.x = this.FDJMJICJCNE.x * localScale.x;
			this.FDJMJICJCNE.y = this.FDJMJICJCNE.y * localScale.y;
			if (this.MCPNNHMOFQH != null)
			{
				Vector4 fmgjbhhndpc = this.MCPNNHMOFQH.FMGJBHHNDPC;
				this.FDJMJICJCNE.x = this.FDJMJICJCNE.x + (fmgjbhhndpc.x + fmgjbhhndpc.z + (localPosition.x - fmgjbhhndpc.x));
				this.FDJMJICJCNE.y = this.FDJMJICJCNE.y + (fmgjbhhndpc.y + fmgjbhhndpc.w + (-localPosition.y - fmgjbhhndpc.y));
				this.MCPNNHMOFQH.KJGMGPCEJJD = Mathf.RoundToInt(this.FDJMJICJCNE.x) - 6;
				this.MCPNNHMOFQH.MGQIGGNBBBD(Mathf.RoundToInt(this.FDJMJICJCNE.y) - 2);
			}
			if (this.CODFIINNNPG != null)
			{
				this.GKHOGHHONGB.x = Mathf.Clamp01(this.GKHOGHHONGB.x / (float)Screen.width);
				this.GKHOGHHONGB.y = Mathf.Clamp01(this.GKHOGHHONGB.y / (float)Screen.height);
				float num = this.CODFIINNNPG.orthographicSize / this.BLLEFKOLKLP.parent.lossyScale.y;
				float num2 = (float)Screen.height * 626f / num;
				Vector2 vector = new Vector2(num2 * (this.FDJMJICJCNE.x + 459f) / (float)Screen.width, num2 * this.FDJMJICJCNE.y / (float)Screen.height);
				this.GKHOGHHONGB.x = Mathf.Min(this.GKHOGHHONGB.x, 1587f - vector.x);
				this.GKHOGHHONGB.y = Mathf.Max(this.GKHOGHHONGB.y, vector.y);
				this.BLLEFKOLKLP.position = this.CODFIINNNPG.ViewportToWorldPoint(this.GKHOGHHONGB);
				this.GKHOGHHONGB = this.BLLEFKOLKLP.localPosition;
				this.GKHOGHHONGB.x = Mathf.Round(this.GKHOGHHONGB.x);
				this.GKHOGHHONGB.y = Mathf.Round(this.GKHOGHHONGB.y);
			}
			else
			{
				if (this.GKHOGHHONGB.x + this.FDJMJICJCNE.x > (float)Screen.width)
				{
					this.GKHOGHHONGB.x = (float)Screen.width - this.FDJMJICJCNE.x;
				}
				if (this.GKHOGHHONGB.y - this.FDJMJICJCNE.y < 1304f)
				{
					this.GKHOGHHONGB.y = this.FDJMJICJCNE.y;
				}
				this.GKHOGHHONGB.x = this.GKHOGHHONGB.x - (float)Screen.width * 757f;
				this.GKHOGHHONGB.y = this.GKHOGHHONGB.y - (float)Screen.height * 1787f;
			}
			this.BLLEFKOLKLP.localPosition = this.GKHOGHHONGB;
			if (this.KNBFIMDLQOD != null)
			{
				this.KNBFIMDLQOD.BroadcastMessage("General");
			}
			else
			{
				this.PIDLOFMIEFQ.BroadcastMessage("Primordial Sea");
			}
		}
		else
		{
			this.FHHQNGCDOCK = null;
			this.LJCHEBJOPGG = 274f;
		}
	}

	// Token: 0x060022A7 RID: 8871 RVA: 0x00012ACB File Offset: 0x00010CCB
	private void HOLKIJCJOKQ()
	{
		GGGPJQEKNJD.QONPKLEGMEF = this;
	}

	// Token: 0x060022A8 RID: 8872 RVA: 0x00012B4A File Offset: 0x00010D4A
	private void OnDestroy()
	{
		GGGPJQEKNJD.QONPKLEGMEF = null;
	}

	// Token: 0x060022A9 RID: 8873 RVA: 0x00012B4A File Offset: 0x00010D4A
	private void MDFCKPBPDEB()
	{
		GGGPJQEKNJD.QONPKLEGMEF = null;
	}

	// Token: 0x060022AA RID: 8874 RVA: 0x000E2B38 File Offset: 0x000E0D38
	protected virtual void BMIIMIDBBQK(float QJFQOMOIOOI)
	{
		int i = 0;
		int num = this.QJNJKLEMMLD.Length;
		while (i < num)
		{
			ENFMCDNLEQQ enfmcdnleqq = this.QJNJKLEMMLD[i];
			Color cegfbbhmkoe = enfmcdnleqq.CEGFBBHMKOE;
			cegfbbhmkoe.a = QJFQOMOIOOI;
			enfmcdnleqq.CEGFBBHMKOE = cegfbbhmkoe;
			i += 0;
		}
	}

	// Token: 0x060022AB RID: 8875 RVA: 0x00012AED File Offset: 0x00010CED
	public static void PHHNDJKIMPJ(string PIDLOFMIEFQ)
	{
		if (GGGPJQEKNJD.QONPKLEGMEF != null)
		{
			GGGPJQEKNJD.QONPKLEGMEF.JPOBDJBEQEP(PIDLOFMIEFQ);
		}
	}

	// Token: 0x060022AC RID: 8876 RVA: 0x00012ACB File Offset: 0x00010CCB
	private void BMIIKIKIKIK()
	{
		GGGPJQEKNJD.QONPKLEGMEF = this;
	}

	// Token: 0x060022AD RID: 8877 RVA: 0x00012BE6 File Offset: 0x00010DE6
	public static void HOICKEIJIHM(string PIDLOFMIEFQ)
	{
		if (GGGPJQEKNJD.QONPKLEGMEF != null)
		{
			GGGPJQEKNJD.QONPKLEGMEF.DQPHEKEBHJP(PIDLOFMIEFQ);
		}
	}

	// Token: 0x060022AE RID: 8878 RVA: 0x00012C00 File Offset: 0x00010E00
	public static bool NIKJQFONJKN()
	{
		return !(GGGPJQEKNJD.QONPKLEGMEF != null) || GGGPJQEKNJD.QONPKLEGMEF.LJCHEBJOPGG == 1615f;
	}

	// Token: 0x060022AF RID: 8879 RVA: 0x00012B4A File Offset: 0x00010D4A
	private void QMDDEJJEBCF()
	{
		GGGPJQEKNJD.QONPKLEGMEF = null;
	}

	// Token: 0x060022B0 RID: 8880 RVA: 0x00012C23 File Offset: 0x00010E23
	public static bool COHHOOKEKBJ()
	{
		return !(GGGPJQEKNJD.QONPKLEGMEF != null) || GGGPJQEKNJD.QONPKLEGMEF.LJCHEBJOPGG == 419f;
	}

	// Token: 0x060022B1 RID: 8881 RVA: 0x00012C46 File Offset: 0x00010E46
	public static void HOMPHDGCGCP(string PIDLOFMIEFQ)
	{
		if (GGGPJQEKNJD.QONPKLEGMEF != null)
		{
			GGGPJQEKNJD.QONPKLEGMEF.BJJCQHHHDOF(PIDLOFMIEFQ);
		}
	}

	// Token: 0x060022B2 RID: 8882 RVA: 0x000E2B7C File Offset: 0x000E0D7C
	protected virtual void JKNGPGGPMPG()
	{
		this.BLLEFKOLKLP = base.transform;
		this.QJNJKLEMMLD = base.GetComponentsInChildren<ENFMCDNLEQQ>();
		this.GKHOGHHONGB = this.BLLEFKOLKLP.localPosition;
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		this.QMBFDEMFMDQ(28f);
	}

	// Token: 0x060022B3 RID: 8883 RVA: 0x00012C60 File Offset: 0x00010E60
	public static bool QCHFFHODHBO()
	{
		return GGGPJQEKNJD.QONPKLEGMEF != null && GGGPJQEKNJD.QONPKLEGMEF.LJCHEBJOPGG == 285f;
	}

	// Token: 0x060022B4 RID: 8884 RVA: 0x000E2BE4 File Offset: 0x000E0DE4
	protected virtual void KJLKBMCCNFO(string NMNKQQOOJQQ)
	{
		if (this.PIDLOFMIEFQ != null && !string.IsNullOrEmpty(NMNKQQOOJQQ))
		{
			this.LJCHEBJOPGG = 477f;
			this.FHHQNGCDOCK = EMENMKHBPQE.NFFBMPMMGEO;
			this.PIDLOFMIEFQ.PIDLOFMIEFQ = NMNKQQOOJQQ;
			this.GKHOGHHONGB = EMENMKHBPQE.OBLGQQHNDII + new Vector2(1028f, 1052f);
			Transform transform = this.PIDLOFMIEFQ.transform;
			Vector3 localPosition = transform.localPosition;
			Vector3 localScale = transform.localScale;
			this.FDJMJICJCNE = this.PIDLOFMIEFQ.LMCNBKKIBKD;
			this.FDJMJICJCNE.x = this.FDJMJICJCNE.x * localScale.x;
			this.FDJMJICJCNE.y = this.FDJMJICJCNE.y * localScale.y;
			if (this.MCPNNHMOFQH != null)
			{
				Vector4 fmgjbhhndpc = this.MCPNNHMOFQH.FMGJBHHNDPC;
				this.FDJMJICJCNE.x = this.FDJMJICJCNE.x + (fmgjbhhndpc.x + fmgjbhhndpc.z + (localPosition.x - fmgjbhhndpc.x));
				this.FDJMJICJCNE.y = this.FDJMJICJCNE.y + (fmgjbhhndpc.y + fmgjbhhndpc.w + (-localPosition.y - fmgjbhhndpc.y));
				this.MCPNNHMOFQH.KJGMGPCEJJD = Mathf.RoundToInt(this.FDJMJICJCNE.x) - 0;
				this.MCPNNHMOFQH.DFKQMMIQDOO = Mathf.RoundToInt(this.FDJMJICJCNE.y) - 1;
			}
			if (this.CODFIINNNPG != null)
			{
				this.GKHOGHHONGB.x = Mathf.Clamp01(this.GKHOGHHONGB.x / (float)Screen.width);
				this.GKHOGHHONGB.y = Mathf.Clamp01(this.GKHOGHHONGB.y / (float)Screen.height);
				float num = this.CODFIINNNPG.orthographicSize / this.BLLEFKOLKLP.parent.lossyScale.y;
				float num2 = (float)Screen.height * 718f / num;
				Vector2 vector = new Vector2(num2 * (this.FDJMJICJCNE.x + 529f) / (float)Screen.width, num2 * this.FDJMJICJCNE.y / (float)Screen.height);
				this.GKHOGHHONGB.x = Mathf.Min(this.GKHOGHHONGB.x, 1584f - vector.x);
				this.GKHOGHHONGB.y = Mathf.Max(this.GKHOGHHONGB.y, vector.y);
				this.BLLEFKOLKLP.position = this.CODFIINNNPG.ViewportToWorldPoint(this.GKHOGHHONGB);
				this.GKHOGHHONGB = this.BLLEFKOLKLP.localPosition;
				this.GKHOGHHONGB.x = Mathf.Round(this.GKHOGHHONGB.x);
				this.GKHOGHHONGB.y = Mathf.Round(this.GKHOGHHONGB.y);
			}
			else
			{
				if (this.GKHOGHHONGB.x + this.FDJMJICJCNE.x > (float)Screen.width)
				{
					this.GKHOGHHONGB.x = (float)Screen.width - this.FDJMJICJCNE.x;
				}
				if (this.GKHOGHHONGB.y - this.FDJMJICJCNE.y < 781f)
				{
					this.GKHOGHHONGB.y = this.FDJMJICJCNE.y;
				}
				this.GKHOGHHONGB.x = this.GKHOGHHONGB.x - (float)Screen.width * 1517f;
				this.GKHOGHHONGB.y = this.GKHOGHHONGB.y - (float)Screen.height * 480f;
			}
			this.BLLEFKOLKLP.localPosition = this.GKHOGHHONGB;
			if (this.KNBFIMDLQOD != null)
			{
				this.KNBFIMDLQOD.BroadcastMessage("brn");
			}
			else
			{
				this.PIDLOFMIEFQ.BroadcastMessage("!\r\n");
			}
		}
		else
		{
			this.FHHQNGCDOCK = null;
			this.LJCHEBJOPGG = 884f;
		}
	}

	// Token: 0x060022B5 RID: 8885 RVA: 0x00012B4A File Offset: 0x00010D4A
	private void DGJDQDOFNFP()
	{
		GGGPJQEKNJD.QONPKLEGMEF = null;
	}

	// Token: 0x060022B6 RID: 8886 RVA: 0x00012BE6 File Offset: 0x00010DE6
	public static void JOFBCKFPFEN(string PIDLOFMIEFQ)
	{
		if (GGGPJQEKNJD.QONPKLEGMEF != null)
		{
			GGGPJQEKNJD.QONPKLEGMEF.DQPHEKEBHJP(PIDLOFMIEFQ);
		}
	}

	// Token: 0x060022B7 RID: 8887 RVA: 0x000E2FE8 File Offset: 0x000E11E8
	protected virtual void FMMMLIDHCFP()
	{
		if (this.FHHQNGCDOCK != EMENMKHBPQE.NFFBMPMMGEO)
		{
			this.FHHQNGCDOCK = null;
			this.LJCHEBJOPGG = 915f;
		}
		if (this.PCJONCHKHIC != this.LJCHEBJOPGG)
		{
			this.PCJONCHKHIC = Mathf.Lerp(this.PCJONCHKHIC, this.LJCHEBJOPGG, JMIOBJFFGBN.CIPLINIEDED() * this.JLMDLJMBHDP);
			if (Mathf.Abs(this.PCJONCHKHIC - this.LJCHEBJOPGG) < 1899f)
			{
				this.PCJONCHKHIC = this.LJCHEBJOPGG;
			}
			this.NDEIMCCNBMF(this.PCJONCHKHIC * this.PCJONCHKHIC);
			if (this.LHJFEKGGCON)
			{
				Vector3 b = this.FDJMJICJCNE * 1163f;
				b.y = -b.y;
				Vector3 localScale = Vector3.one * (276f - this.PCJONCHKHIC * 53f);
				Vector3 localPosition = Vector3.Lerp(this.GKHOGHHONGB - b, this.GKHOGHHONGB, this.PCJONCHKHIC);
				this.BLLEFKOLKLP.localPosition = localPosition;
				this.BLLEFKOLKLP.localScale = localScale;
			}
		}
	}

	// Token: 0x060022B8 RID: 8888 RVA: 0x000E3100 File Offset: 0x000E1300
	protected virtual void GCEDFPKOEMN()
	{
		if (this.FHHQNGCDOCK != EMENMKHBPQE.NFFBMPMMGEO)
		{
			this.FHHQNGCDOCK = null;
			this.LJCHEBJOPGG = 1911f;
		}
		if (this.PCJONCHKHIC != this.LJCHEBJOPGG)
		{
			this.PCJONCHKHIC = Mathf.Lerp(this.PCJONCHKHIC, this.LJCHEBJOPGG, JMIOBJFFGBN.EDEPQCIGFOL() * this.JLMDLJMBHDP);
			if (Mathf.Abs(this.PCJONCHKHIC - this.LJCHEBJOPGG) < 444f)
			{
				this.PCJONCHKHIC = this.LJCHEBJOPGG;
			}
			this.QKJDOFPEGGM(this.PCJONCHKHIC * this.PCJONCHKHIC);
			if (this.LHJFEKGGCON)
			{
				Vector3 b = this.FDJMJICJCNE * 997f;
				b.y = -b.y;
				Vector3 localScale = Vector3.one * (1844f - this.PCJONCHKHIC * 736f);
				Vector3 localPosition = Vector3.Lerp(this.GKHOGHHONGB - b, this.GKHOGHHONGB, this.PCJONCHKHIC);
				this.BLLEFKOLKLP.localPosition = localPosition;
				this.BLLEFKOLKLP.localScale = localScale;
			}
		}
	}

	// Token: 0x060022B9 RID: 8889 RVA: 0x00012B30 File Offset: 0x00010D30
	public static void GGGJPCQFKGM(string PIDLOFMIEFQ)
	{
		if (GGGPJQEKNJD.QONPKLEGMEF != null)
		{
			GGGPJQEKNJD.QONPKLEGMEF.MHQJOQMDDPN(PIDLOFMIEFQ);
		}
	}

	// Token: 0x060022BB RID: 8891 RVA: 0x000E3218 File Offset: 0x000E1418
	protected virtual void JPOBDJBEQEP(string NMNKQQOOJQQ)
	{
		if (this.PIDLOFMIEFQ != null && !string.IsNullOrEmpty(NMNKQQOOJQQ))
		{
			this.LJCHEBJOPGG = 849f;
			this.FHHQNGCDOCK = EMENMKHBPQE.NFFBMPMMGEO;
			this.PIDLOFMIEFQ.LKPOBCBOFIC(NMNKQQOOJQQ);
			this.GKHOGHHONGB = EMENMKHBPQE.OBLGQQHNDII + new Vector2(904f, 594f);
			Transform transform = this.PIDLOFMIEFQ.transform;
			Vector3 localPosition = transform.localPosition;
			Vector3 localScale = transform.localScale;
			this.FDJMJICJCNE = this.PIDLOFMIEFQ.LMCNBKKIBKD;
			this.FDJMJICJCNE.x = this.FDJMJICJCNE.x * localScale.x;
			this.FDJMJICJCNE.y = this.FDJMJICJCNE.y * localScale.y;
			if (this.MCPNNHMOFQH != null)
			{
				Vector4 fmgjbhhndpc = this.MCPNNHMOFQH.FMGJBHHNDPC;
				this.FDJMJICJCNE.x = this.FDJMJICJCNE.x + (fmgjbhhndpc.x + fmgjbhhndpc.z + (localPosition.x - fmgjbhhndpc.x));
				this.FDJMJICJCNE.y = this.FDJMJICJCNE.y + (fmgjbhhndpc.y + fmgjbhhndpc.w + (-localPosition.y - fmgjbhhndpc.y));
				this.MCPNNHMOFQH.KJGMGPCEJJD = Mathf.RoundToInt(this.FDJMJICJCNE.x) - 7;
				this.MCPNNHMOFQH.DFKQMMIQDOO = Mathf.RoundToInt(this.FDJMJICJCNE.y) - 0;
			}
			if (this.CODFIINNNPG != null)
			{
				this.GKHOGHHONGB.x = Mathf.Clamp01(this.GKHOGHHONGB.x / (float)Screen.width);
				this.GKHOGHHONGB.y = Mathf.Clamp01(this.GKHOGHHONGB.y / (float)Screen.height);
				float num = this.CODFIINNNPG.orthographicSize / this.BLLEFKOLKLP.parent.lossyScale.y;
				float num2 = (float)Screen.height * 1675f / num;
				Vector2 vector = new Vector2(num2 * (this.FDJMJICJCNE.x + 123f) / (float)Screen.width, num2 * this.FDJMJICJCNE.y / (float)Screen.height);
				this.GKHOGHHONGB.x = Mathf.Min(this.GKHOGHHONGB.x, 21f - vector.x);
				this.GKHOGHHONGB.y = Mathf.Max(this.GKHOGHHONGB.y, vector.y);
				this.BLLEFKOLKLP.position = this.CODFIINNNPG.ViewportToWorldPoint(this.GKHOGHHONGB);
				this.GKHOGHHONGB = this.BLLEFKOLKLP.localPosition;
				this.GKHOGHHONGB.x = Mathf.Round(this.GKHOGHHONGB.x);
				this.GKHOGHHONGB.y = Mathf.Round(this.GKHOGHHONGB.y);
			}
			else
			{
				if (this.GKHOGHHONGB.x + this.FDJMJICJCNE.x > (float)Screen.width)
				{
					this.GKHOGHHONGB.x = (float)Screen.width - this.FDJMJICJCNE.x;
				}
				if (this.GKHOGHHONGB.y - this.FDJMJICJCNE.y < 1643f)
				{
					this.GKHOGHHONGB.y = this.FDJMJICJCNE.y;
				}
				this.GKHOGHHONGB.x = this.GKHOGHHONGB.x - (float)Screen.width * 63f;
				this.GKHOGHHONGB.y = this.GKHOGHHONGB.y - (float)Screen.height * 131f;
			}
			this.BLLEFKOLKLP.localPosition = this.GKHOGHHONGB;
			if (this.KNBFIMDLQOD != null)
			{
				this.KNBFIMDLQOD.BroadcastMessage("TAA History");
			}
			else
			{
				this.PIDLOFMIEFQ.BroadcastMessage(" (TextureClip)");
			}
		}
		else
		{
			this.FHHQNGCDOCK = null;
			this.LJCHEBJOPGG = 1710f;
		}
	}

	// Token: 0x060022BC RID: 8892 RVA: 0x00012CA8 File Offset: 0x00010EA8
	public static void JNDKHLFCEEB(string PIDLOFMIEFQ)
	{
		if (GGGPJQEKNJD.QONPKLEGMEF != null)
		{
			GGGPJQEKNJD.QONPKLEGMEF.DGJQFQFIPPN(PIDLOFMIEFQ);
		}
	}

	// Token: 0x060022BD RID: 8893 RVA: 0x00012B4A File Offset: 0x00010D4A
	private void JJNJGJEDBMF()
	{
		GGGPJQEKNJD.QONPKLEGMEF = null;
	}

	// Token: 0x060022BE RID: 8894 RVA: 0x00012AD3 File Offset: 0x00010CD3
	public static void DKQBNDFHIQD(string PIDLOFMIEFQ)
	{
		if (GGGPJQEKNJD.QONPKLEGMEF != null)
		{
			GGGPJQEKNJD.QONPKLEGMEF.KJLKBMCCNFO(PIDLOFMIEFQ);
		}
	}

	// Token: 0x060022BF RID: 8895 RVA: 0x000E361C File Offset: 0x000E181C
	protected virtual void EGFFPGCMFOO()
	{
		if (this.FHHQNGCDOCK != EMENMKHBPQE.NFFBMPMMGEO)
		{
			this.FHHQNGCDOCK = null;
			this.LJCHEBJOPGG = 125f;
		}
		if (this.PCJONCHKHIC != this.LJCHEBJOPGG)
		{
			this.PCJONCHKHIC = Mathf.Lerp(this.PCJONCHKHIC, this.LJCHEBJOPGG, JMIOBJFFGBN.EDEPQCIGFOL() * this.JLMDLJMBHDP);
			if (Mathf.Abs(this.PCJONCHKHIC - this.LJCHEBJOPGG) < 312f)
			{
				this.PCJONCHKHIC = this.LJCHEBJOPGG;
			}
			this.BDPJNHKHMDC(this.PCJONCHKHIC * this.PCJONCHKHIC);
			if (this.LHJFEKGGCON)
			{
				Vector3 b = this.FDJMJICJCNE * 902f;
				b.y = -b.y;
				Vector3 localScale = Vector3.one * (1517f - this.PCJONCHKHIC * 317f);
				Vector3 localPosition = Vector3.Lerp(this.GKHOGHHONGB - b, this.GKHOGHHONGB, this.PCJONCHKHIC);
				this.BLLEFKOLKLP.localPosition = localPosition;
				this.BLLEFKOLKLP.localScale = localScale;
			}
		}
	}

	// Token: 0x060022C0 RID: 8896 RVA: 0x00012B75 File Offset: 0x00010D75
	public static void LKIJECLHNGN(string PIDLOFMIEFQ)
	{
		if (GGGPJQEKNJD.QONPKLEGMEF != null)
		{
			GGGPJQEKNJD.QONPKLEGMEF.HQIKGIBOEOJ(PIDLOFMIEFQ);
		}
	}

	// Token: 0x060022C1 RID: 8897 RVA: 0x000E3734 File Offset: 0x000E1934
	protected virtual void HCNPIJLODQE(string NMNKQQOOJQQ)
	{
		if (this.PIDLOFMIEFQ != null && !string.IsNullOrEmpty(NMNKQQOOJQQ))
		{
			this.LJCHEBJOPGG = 1f;
			this.FHHQNGCDOCK = EMENMKHBPQE.NFFBMPMMGEO;
			this.PIDLOFMIEFQ.PIDLOFMIEFQ = NMNKQQOOJQQ;
			this.GKHOGHHONGB = EMENMKHBPQE.OBLGQQHNDII + new Vector2(12f, 0f);
			Transform transform = this.PIDLOFMIEFQ.transform;
			Vector3 localPosition = transform.localPosition;
			Vector3 localScale = transform.localScale;
			this.FDJMJICJCNE = this.PIDLOFMIEFQ.LMCNBKKIBKD;
			this.FDJMJICJCNE.x = this.FDJMJICJCNE.x * localScale.x;
			this.FDJMJICJCNE.y = this.FDJMJICJCNE.y * localScale.y;
			if (this.MCPNNHMOFQH != null)
			{
				Vector4 fmgjbhhndpc = this.MCPNNHMOFQH.FMGJBHHNDPC;
				this.FDJMJICJCNE.x = this.FDJMJICJCNE.x + (fmgjbhhndpc.x + fmgjbhhndpc.z + (localPosition.x - fmgjbhhndpc.x));
				this.FDJMJICJCNE.y = this.FDJMJICJCNE.y + (fmgjbhhndpc.y + fmgjbhhndpc.w + (-localPosition.y - fmgjbhhndpc.y));
				this.MCPNNHMOFQH.KJGMGPCEJJD = Mathf.RoundToInt(this.FDJMJICJCNE.x) - 7;
				this.MCPNNHMOFQH.DFKQMMIQDOO = Mathf.RoundToInt(this.FDJMJICJCNE.y) - 4;
			}
			if (this.CODFIINNNPG != null)
			{
				this.GKHOGHHONGB.x = Mathf.Clamp01(this.GKHOGHHONGB.x / (float)Screen.width);
				this.GKHOGHHONGB.y = Mathf.Clamp01(this.GKHOGHHONGB.y / (float)Screen.height);
				float num = this.CODFIINNNPG.orthographicSize / this.BLLEFKOLKLP.parent.lossyScale.y;
				float num2 = (float)Screen.height * 0.5f / num;
				Vector2 vector = new Vector2(num2 * (this.FDJMJICJCNE.x + 4f) / (float)Screen.width, num2 * this.FDJMJICJCNE.y / (float)Screen.height);
				this.GKHOGHHONGB.x = Mathf.Min(this.GKHOGHHONGB.x, 1f - vector.x);
				this.GKHOGHHONGB.y = Mathf.Max(this.GKHOGHHONGB.y, vector.y);
				this.BLLEFKOLKLP.position = this.CODFIINNNPG.ViewportToWorldPoint(this.GKHOGHHONGB);
				this.GKHOGHHONGB = this.BLLEFKOLKLP.localPosition;
				this.GKHOGHHONGB.x = Mathf.Round(this.GKHOGHHONGB.x);
				this.GKHOGHHONGB.y = Mathf.Round(this.GKHOGHHONGB.y);
			}
			else
			{
				if (this.GKHOGHHONGB.x + this.FDJMJICJCNE.x > (float)Screen.width)
				{
					this.GKHOGHHONGB.x = (float)Screen.width - this.FDJMJICJCNE.x;
				}
				if (this.GKHOGHHONGB.y - this.FDJMJICJCNE.y < 0f)
				{
					this.GKHOGHHONGB.y = this.FDJMJICJCNE.y;
				}
				this.GKHOGHHONGB.x = this.GKHOGHHONGB.x - (float)Screen.width * 0.5f;
				this.GKHOGHHONGB.y = this.GKHOGHHONGB.y - (float)Screen.height * 0.5f;
			}
			this.BLLEFKOLKLP.localPosition = this.GKHOGHHONGB;
			if (this.KNBFIMDLQOD != null)
			{
				this.KNBFIMDLQOD.BroadcastMessage("UpdateAnchors");
			}
			else
			{
				this.PIDLOFMIEFQ.BroadcastMessage("UpdateAnchors");
			}
		}
		else
		{
			this.FHHQNGCDOCK = null;
			this.LJCHEBJOPGG = 0f;
		}
	}

	// Token: 0x060022C2 RID: 8898 RVA: 0x00012B8F File Offset: 0x00010D8F
	public static void QOLKOBPCJBQ(string PIDLOFMIEFQ)
	{
		if (GGGPJQEKNJD.QONPKLEGMEF != null)
		{
			GGGPJQEKNJD.QONPKLEGMEF.HCNPIJLODQE(PIDLOFMIEFQ);
		}
	}

	// Token: 0x060022C3 RID: 8899 RVA: 0x00012ACB File Offset: 0x00010CCB
	private void LEJQMIECFCH()
	{
		GGGPJQEKNJD.QONPKLEGMEF = this;
	}

	// Token: 0x060022C4 RID: 8900 RVA: 0x00012BCC File Offset: 0x00010DCC
	public static void EEDLEIMKKJK(string PIDLOFMIEFQ)
	{
		if (GGGPJQEKNJD.QONPKLEGMEF != null)
		{
			GGGPJQEKNJD.QONPKLEGMEF.LJIFBJFLEJH(PIDLOFMIEFQ);
		}
	}

	// Token: 0x060022C5 RID: 8901 RVA: 0x00012CC2 File Offset: 0x00010EC2
	public static void HNMHKIJEDIE()
	{
		if (GGGPJQEKNJD.QONPKLEGMEF != null)
		{
			GGGPJQEKNJD.QONPKLEGMEF.FHHQNGCDOCK = null;
			GGGPJQEKNJD.QONPKLEGMEF.LJCHEBJOPGG = 1933f;
		}
	}

	// Token: 0x060022C6 RID: 8902 RVA: 0x000E3B38 File Offset: 0x000E1D38
	protected virtual void FLJMQFGKJPQ(float QJFQOMOIOOI)
	{
		int i = 1;
		int num = this.QJNJKLEMMLD.Length;
		while (i < num)
		{
			ENFMCDNLEQQ enfmcdnleqq = this.QJNJKLEMMLD[i];
			Color cegfbbhmkoe = enfmcdnleqq.CEGFBBHMKOE;
			cegfbbhmkoe.a = QJFQOMOIOOI;
			enfmcdnleqq.NONQDHBCIIN(cegfbbhmkoe);
			i++;
		}
	}

	// Token: 0x060022C7 RID: 8903 RVA: 0x00012B8F File Offset: 0x00010D8F
	public static void MFONIPHOFGF(string PIDLOFMIEFQ)
	{
		if (GGGPJQEKNJD.QONPKLEGMEF != null)
		{
			GGGPJQEKNJD.QONPKLEGMEF.HCNPIJLODQE(PIDLOFMIEFQ);
		}
	}

	// Token: 0x060022C8 RID: 8904 RVA: 0x00012CEB File Offset: 0x00010EEB
	public static void HDCHLOLKEGL()
	{
		if (GGGPJQEKNJD.QONPKLEGMEF != null)
		{
			GGGPJQEKNJD.QONPKLEGMEF.FHHQNGCDOCK = null;
			GGGPJQEKNJD.QONPKLEGMEF.LJCHEBJOPGG = 207f;
		}
	}

	// Token: 0x060022C9 RID: 8905 RVA: 0x00012D14 File Offset: 0x00010F14
	public static bool MBQJQMBCPMD()
	{
		return !(GGGPJQEKNJD.QONPKLEGMEF != null) || GGGPJQEKNJD.QONPKLEGMEF.LJCHEBJOPGG == 1997f;
	}

	// Token: 0x060022CA RID: 8906 RVA: 0x00012D37 File Offset: 0x00010F37
	public static void FPGOEMCDQJC()
	{
		if (GGGPJQEKNJD.QONPKLEGMEF != null)
		{
			GGGPJQEKNJD.QONPKLEGMEF.FHHQNGCDOCK = null;
			GGGPJQEKNJD.QONPKLEGMEF.LJCHEBJOPGG = 882f;
		}
	}

	// Token: 0x060022CB RID: 8907 RVA: 0x00012B4A File Offset: 0x00010D4A
	private void JLPLPGINIQL()
	{
		GGGPJQEKNJD.QONPKLEGMEF = null;
	}

	// Token: 0x060022CC RID: 8908 RVA: 0x000E3B7C File Offset: 0x000E1D7C
	protected virtual void DQPHEKEBHJP(string NMNKQQOOJQQ)
	{
		if (this.PIDLOFMIEFQ != null && !string.IsNullOrEmpty(NMNKQQOOJQQ))
		{
			this.LJCHEBJOPGG = 1242f;
			this.FHHQNGCDOCK = EMENMKHBPQE.NFFBMPMMGEO;
			this.PIDLOFMIEFQ.LKPOBCBOFIC(NMNKQQOOJQQ);
			this.GKHOGHHONGB = EMENMKHBPQE.GDLFOFEJOPK() + new Vector2(703f, 1885f);
			Transform transform = this.PIDLOFMIEFQ.transform;
			Vector3 localPosition = transform.localPosition;
			Vector3 localScale = transform.localScale;
			this.FDJMJICJCNE = this.PIDLOFMIEFQ.LMCNBKKIBKD;
			this.FDJMJICJCNE.x = this.FDJMJICJCNE.x * localScale.x;
			this.FDJMJICJCNE.y = this.FDJMJICJCNE.y * localScale.y;
			if (this.MCPNNHMOFQH != null)
			{
				Vector4 fmgjbhhndpc = this.MCPNNHMOFQH.FMGJBHHNDPC;
				this.FDJMJICJCNE.x = this.FDJMJICJCNE.x + (fmgjbhhndpc.x + fmgjbhhndpc.z + (localPosition.x - fmgjbhhndpc.x));
				this.FDJMJICJCNE.y = this.FDJMJICJCNE.y + (fmgjbhhndpc.y + fmgjbhhndpc.w + (-localPosition.y - fmgjbhhndpc.y));
				this.MCPNNHMOFQH.KJGMGPCEJJD = Mathf.RoundToInt(this.FDJMJICJCNE.x) - 2;
				this.MCPNNHMOFQH.MGQIGGNBBBD(Mathf.RoundToInt(this.FDJMJICJCNE.y) - 1);
			}
			if (this.CODFIINNNPG != null)
			{
				this.GKHOGHHONGB.x = Mathf.Clamp01(this.GKHOGHHONGB.x / (float)Screen.width);
				this.GKHOGHHONGB.y = Mathf.Clamp01(this.GKHOGHHONGB.y / (float)Screen.height);
				float num = this.CODFIINNNPG.orthographicSize / this.BLLEFKOLKLP.parent.lossyScale.y;
				float num2 = (float)Screen.height * 771f / num;
				Vector2 vector = new Vector2(num2 * (this.FDJMJICJCNE.x + 1252f) / (float)Screen.width, num2 * this.FDJMJICJCNE.y / (float)Screen.height);
				this.GKHOGHHONGB.x = Mathf.Min(this.GKHOGHHONGB.x, 1434f - vector.x);
				this.GKHOGHHONGB.y = Mathf.Max(this.GKHOGHHONGB.y, vector.y);
				this.BLLEFKOLKLP.position = this.CODFIINNNPG.ViewportToWorldPoint(this.GKHOGHHONGB);
				this.GKHOGHHONGB = this.BLLEFKOLKLP.localPosition;
				this.GKHOGHHONGB.x = Mathf.Round(this.GKHOGHHONGB.x);
				this.GKHOGHHONGB.y = Mathf.Round(this.GKHOGHHONGB.y);
			}
			else
			{
				if (this.GKHOGHHONGB.x + this.FDJMJICJCNE.x > (float)Screen.width)
				{
					this.GKHOGHHONGB.x = (float)Screen.width - this.FDJMJICJCNE.x;
				}
				if (this.GKHOGHHONGB.y - this.FDJMJICJCNE.y < 20f)
				{
					this.GKHOGHHONGB.y = this.FDJMJICJCNE.y;
				}
				this.GKHOGHHONGB.x = this.GKHOGHHONGB.x - (float)Screen.width * 130f;
				this.GKHOGHHONGB.y = this.GKHOGHHONGB.y - (float)Screen.height * 393f;
			}
			this.BLLEFKOLKLP.localPosition = this.GKHOGHHONGB;
			if (this.KNBFIMDLQOD != null)
			{
				this.KNBFIMDLQOD.BroadcastMessage("uproar");
			}
			else
			{
				this.PIDLOFMIEFQ.BroadcastMessage("[FFFF00]/252");
			}
		}
		else
		{
			this.FHHQNGCDOCK = null;
			this.LJCHEBJOPGG = 1972f;
		}
	}

	// Token: 0x060022CD RID: 8909 RVA: 0x000E3F80 File Offset: 0x000E2180
	protected virtual void MHQJOQMDDPN(string NMNKQQOOJQQ)
	{
		if (this.PIDLOFMIEFQ != null && !string.IsNullOrEmpty(NMNKQQOOJQQ))
		{
			this.LJCHEBJOPGG = 799f;
			this.FHHQNGCDOCK = EMENMKHBPQE.NFFBMPMMGEO;
			this.PIDLOFMIEFQ.PIDLOFMIEFQ = NMNKQQOOJQQ;
			this.GKHOGHHONGB = EMENMKHBPQE.OBLGQQHNDII + new Vector2(650f, 1360f);
			Transform transform = this.PIDLOFMIEFQ.transform;
			Vector3 localPosition = transform.localPosition;
			Vector3 localScale = transform.localScale;
			this.FDJMJICJCNE = this.PIDLOFMIEFQ.LMCNBKKIBKD;
			this.FDJMJICJCNE.x = this.FDJMJICJCNE.x * localScale.x;
			this.FDJMJICJCNE.y = this.FDJMJICJCNE.y * localScale.y;
			if (this.MCPNNHMOFQH != null)
			{
				Vector4 fmgjbhhndpc = this.MCPNNHMOFQH.FMGJBHHNDPC;
				this.FDJMJICJCNE.x = this.FDJMJICJCNE.x + (fmgjbhhndpc.x + fmgjbhhndpc.z + (localPosition.x - fmgjbhhndpc.x));
				this.FDJMJICJCNE.y = this.FDJMJICJCNE.y + (fmgjbhhndpc.y + fmgjbhhndpc.w + (-localPosition.y - fmgjbhhndpc.y));
				this.MCPNNHMOFQH.KJGMGPCEJJD = Mathf.RoundToInt(this.FDJMJICJCNE.x) - 2;
				this.MCPNNHMOFQH.MGQIGGNBBBD(Mathf.RoundToInt(this.FDJMJICJCNE.y) - 0);
			}
			if (this.CODFIINNNPG != null)
			{
				this.GKHOGHHONGB.x = Mathf.Clamp01(this.GKHOGHHONGB.x / (float)Screen.width);
				this.GKHOGHHONGB.y = Mathf.Clamp01(this.GKHOGHHONGB.y / (float)Screen.height);
				float num = this.CODFIINNNPG.orthographicSize / this.BLLEFKOLKLP.parent.lossyScale.y;
				float num2 = (float)Screen.height * 329f / num;
				Vector2 vector = new Vector2(num2 * (this.FDJMJICJCNE.x + 448f) / (float)Screen.width, num2 * this.FDJMJICJCNE.y / (float)Screen.height);
				this.GKHOGHHONGB.x = Mathf.Min(this.GKHOGHHONGB.x, 409f - vector.x);
				this.GKHOGHHONGB.y = Mathf.Max(this.GKHOGHHONGB.y, vector.y);
				this.BLLEFKOLKLP.position = this.CODFIINNNPG.ViewportToWorldPoint(this.GKHOGHHONGB);
				this.GKHOGHHONGB = this.BLLEFKOLKLP.localPosition;
				this.GKHOGHHONGB.x = Mathf.Round(this.GKHOGHHONGB.x);
				this.GKHOGHHONGB.y = Mathf.Round(this.GKHOGHHONGB.y);
			}
			else
			{
				if (this.GKHOGHHONGB.x + this.FDJMJICJCNE.x > (float)Screen.width)
				{
					this.GKHOGHHONGB.x = (float)Screen.width - this.FDJMJICJCNE.x;
				}
				if (this.GKHOGHHONGB.y - this.FDJMJICJCNE.y < 1882f)
				{
					this.GKHOGHHONGB.y = this.FDJMJICJCNE.y;
				}
				this.GKHOGHHONGB.x = this.GKHOGHHONGB.x - (float)Screen.width * 1762f;
				this.GKHOGHHONGB.y = this.GKHOGHHONGB.y - (float)Screen.height * 1863f;
			}
			this.BLLEFKOLKLP.localPosition = this.GKHOGHHONGB;
			if (this.KNBFIMDLQOD != null)
			{
				this.KNBFIMDLQOD.BroadcastMessage("|");
			}
			else
			{
				this.PIDLOFMIEFQ.BroadcastMessage(" lost all of its PP due to the grudge!\r\n");
			}
		}
		else
		{
			this.FHHQNGCDOCK = null;
			this.LJCHEBJOPGG = 817f;
		}
	}

	// Token: 0x060022CE RID: 8910 RVA: 0x000E4384 File Offset: 0x000E2584
	protected virtual void JLKQIQQNLJE()
	{
		if (this.FHHQNGCDOCK != EMENMKHBPQE.NFFBMPMMGEO)
		{
			this.FHHQNGCDOCK = null;
			this.LJCHEBJOPGG = 54f;
		}
		if (this.PCJONCHKHIC != this.LJCHEBJOPGG)
		{
			this.PCJONCHKHIC = Mathf.Lerp(this.PCJONCHKHIC, this.LJCHEBJOPGG, JMIOBJFFGBN.HPJQNBLNHGM() * this.JLMDLJMBHDP);
			if (Mathf.Abs(this.PCJONCHKHIC - this.LJCHEBJOPGG) < 287f)
			{
				this.PCJONCHKHIC = this.LJCHEBJOPGG;
			}
			this.CDKCGPMCIKH(this.PCJONCHKHIC * this.PCJONCHKHIC);
			if (this.LHJFEKGGCON)
			{
				Vector3 b = this.FDJMJICJCNE * 1455f;
				b.y = -b.y;
				Vector3 localScale = Vector3.one * (478f - this.PCJONCHKHIC * 1049f);
				Vector3 localPosition = Vector3.Lerp(this.GKHOGHHONGB - b, this.GKHOGHHONGB, this.PCJONCHKHIC);
				this.BLLEFKOLKLP.localPosition = localPosition;
				this.BLLEFKOLKLP.localScale = localScale;
			}
		}
	}

	// Token: 0x060022CF RID: 8911 RVA: 0x00012D60 File Offset: 0x00010F60
	public static bool HPMKFHGPPLG()
	{
		return GGGPJQEKNJD.QONPKLEGMEF != null && GGGPJQEKNJD.QONPKLEGMEF.LJCHEBJOPGG == 1577f;
	}

	// Token: 0x060022D0 RID: 8912 RVA: 0x00012B75 File Offset: 0x00010D75
	public static void DFPCCGGPLGF(string PIDLOFMIEFQ)
	{
		if (GGGPJQEKNJD.QONPKLEGMEF != null)
		{
			GGGPJQEKNJD.QONPKLEGMEF.HQIKGIBOEOJ(PIDLOFMIEFQ);
		}
	}

	// Token: 0x060022D1 RID: 8913 RVA: 0x00012B30 File Offset: 0x00010D30
	public static void GLKNIMLDNJF(string PIDLOFMIEFQ)
	{
		if (GGGPJQEKNJD.QONPKLEGMEF != null)
		{
			GGGPJQEKNJD.QONPKLEGMEF.MHQJOQMDDPN(PIDLOFMIEFQ);
		}
	}

	// Token: 0x060022D2 RID: 8914 RVA: 0x000E449C File Offset: 0x000E269C
	protected virtual void BJJCQHHHDOF(string NMNKQQOOJQQ)
	{
		if (this.PIDLOFMIEFQ != null && !string.IsNullOrEmpty(NMNKQQOOJQQ))
		{
			this.LJCHEBJOPGG = 629f;
			this.FHHQNGCDOCK = EMENMKHBPQE.NFFBMPMMGEO;
			this.PIDLOFMIEFQ.PIDLOFMIEFQ = NMNKQQOOJQQ;
			this.GKHOGHHONGB = EMENMKHBPQE.GDLFOFEJOPK() + new Vector2(868f, 348f);
			Transform transform = this.PIDLOFMIEFQ.transform;
			Vector3 localPosition = transform.localPosition;
			Vector3 localScale = transform.localScale;
			this.FDJMJICJCNE = this.PIDLOFMIEFQ.LMCNBKKIBKD;
			this.FDJMJICJCNE.x = this.FDJMJICJCNE.x * localScale.x;
			this.FDJMJICJCNE.y = this.FDJMJICJCNE.y * localScale.y;
			if (this.MCPNNHMOFQH != null)
			{
				Vector4 fmgjbhhndpc = this.MCPNNHMOFQH.FMGJBHHNDPC;
				this.FDJMJICJCNE.x = this.FDJMJICJCNE.x + (fmgjbhhndpc.x + fmgjbhhndpc.z + (localPosition.x - fmgjbhhndpc.x));
				this.FDJMJICJCNE.y = this.FDJMJICJCNE.y + (fmgjbhhndpc.y + fmgjbhhndpc.w + (-localPosition.y - fmgjbhhndpc.y));
				this.MCPNNHMOFQH.KJGMGPCEJJD = Mathf.RoundToInt(this.FDJMJICJCNE.x) - 2;
				this.MCPNNHMOFQH.DFKQMMIQDOO = Mathf.RoundToInt(this.FDJMJICJCNE.y) - 7;
			}
			if (this.CODFIINNNPG != null)
			{
				this.GKHOGHHONGB.x = Mathf.Clamp01(this.GKHOGHHONGB.x / (float)Screen.width);
				this.GKHOGHHONGB.y = Mathf.Clamp01(this.GKHOGHHONGB.y / (float)Screen.height);
				float num = this.CODFIINNNPG.orthographicSize / this.BLLEFKOLKLP.parent.lossyScale.y;
				float num2 = (float)Screen.height * 415f / num;
				Vector2 vector = new Vector2(num2 * (this.FDJMJICJCNE.x + 1568f) / (float)Screen.width, num2 * this.FDJMJICJCNE.y / (float)Screen.height);
				this.GKHOGHHONGB.x = Mathf.Min(this.GKHOGHHONGB.x, 374f - vector.x);
				this.GKHOGHHONGB.y = Mathf.Max(this.GKHOGHHONGB.y, vector.y);
				this.BLLEFKOLKLP.position = this.CODFIINNNPG.ViewportToWorldPoint(this.GKHOGHHONGB);
				this.GKHOGHHONGB = this.BLLEFKOLKLP.localPosition;
				this.GKHOGHHONGB.x = Mathf.Round(this.GKHOGHHONGB.x);
				this.GKHOGHHONGB.y = Mathf.Round(this.GKHOGHHONGB.y);
			}
			else
			{
				if (this.GKHOGHHONGB.x + this.FDJMJICJCNE.x > (float)Screen.width)
				{
					this.GKHOGHHONGB.x = (float)Screen.width - this.FDJMJICJCNE.x;
				}
				if (this.GKHOGHHONGB.y - this.FDJMJICJCNE.y < 1597f)
				{
					this.GKHOGHHONGB.y = this.FDJMJICJCNE.y;
				}
				this.GKHOGHHONGB.x = this.GKHOGHHONGB.x - (float)Screen.width * 774f;
				this.GKHOGHHONGB.y = this.GKHOGHHONGB.y - (float)Screen.height * 407f;
			}
			this.BLLEFKOLKLP.localPosition = this.GKHOGHHONGB;
			if (this.KNBFIMDLQOD != null)
			{
				this.KNBFIMDLQOD.BroadcastMessage("-transform");
			}
			else
			{
				this.PIDLOFMIEFQ.BroadcastMessage("System");
			}
		}
		else
		{
			this.FHHQNGCDOCK = null;
			this.LJCHEBJOPGG = 1857f;
		}
	}

	// Token: 0x060022D3 RID: 8915 RVA: 0x00012D83 File Offset: 0x00010F83
	public static void DHJEEJGJCGE()
	{
		if (GGGPJQEKNJD.QONPKLEGMEF != null)
		{
			GGGPJQEKNJD.QONPKLEGMEF.FHHQNGCDOCK = null;
			GGGPJQEKNJD.QONPKLEGMEF.LJCHEBJOPGG = 63f;
		}
	}

	// Token: 0x060022D4 RID: 8916 RVA: 0x000E48A0 File Offset: 0x000E2AA0
	protected virtual void CNIKQOQLFFB()
	{
		this.BLLEFKOLKLP = base.transform;
		this.QJNJKLEMMLD = base.GetComponentsInChildren<ENFMCDNLEQQ>();
		this.GKHOGHHONGB = this.BLLEFKOLKLP.localPosition;
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		this.FLJMQFGKJPQ(1789f);
	}

	// Token: 0x060022D5 RID: 8917 RVA: 0x00012DAC File Offset: 0x00010FAC
	public static void Hide()
	{
		if (GGGPJQEKNJD.QONPKLEGMEF != null)
		{
			GGGPJQEKNJD.QONPKLEGMEF.FHHQNGCDOCK = null;
			GGGPJQEKNJD.QONPKLEGMEF.LJCHEBJOPGG = 0f;
		}
	}

	// Token: 0x060022D6 RID: 8918 RVA: 0x00012CA8 File Offset: 0x00010EA8
	public static void ELICJHNDQGL(string PIDLOFMIEFQ)
	{
		if (GGGPJQEKNJD.QONPKLEGMEF != null)
		{
			GGGPJQEKNJD.QONPKLEGMEF.DGJQFQFIPPN(PIDLOFMIEFQ);
		}
	}

	// Token: 0x060022D7 RID: 8919 RVA: 0x000E4908 File Offset: 0x000E2B08
	protected virtual void EDOGJBLCCMQ()
	{
		this.BLLEFKOLKLP = base.transform;
		this.QJNJKLEMMLD = base.GetComponentsInChildren<ENFMCDNLEQQ>();
		this.GKHOGHHONGB = this.BLLEFKOLKLP.localPosition;
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		this.BMIIMIDBBQK(1903f);
	}

	// Token: 0x060022D8 RID: 8920 RVA: 0x000E221C File Offset: 0x000E041C
	protected virtual void QKJDOFPEGGM(float QJFQOMOIOOI)
	{
		int i = 0;
		int num = this.QJNJKLEMMLD.Length;
		while (i < num)
		{
			ENFMCDNLEQQ enfmcdnleqq = this.QJNJKLEMMLD[i];
			Color cegfbbhmkoe = enfmcdnleqq.CEGFBBHMKOE;
			cegfbbhmkoe.a = QJFQOMOIOOI;
			enfmcdnleqq.NONQDHBCIIN(cegfbbhmkoe);
			i++;
		}
	}

	// Token: 0x060022D9 RID: 8921 RVA: 0x00012B75 File Offset: 0x00010D75
	public static void ODCEFOICOED(string PIDLOFMIEFQ)
	{
		if (GGGPJQEKNJD.QONPKLEGMEF != null)
		{
			GGGPJQEKNJD.QONPKLEGMEF.HQIKGIBOEOJ(PIDLOFMIEFQ);
		}
	}

	// Token: 0x060022DA RID: 8922 RVA: 0x00012DD5 File Offset: 0x00010FD5
	public static void FDDBHCGOJLP()
	{
		if (GGGPJQEKNJD.QONPKLEGMEF != null)
		{
			GGGPJQEKNJD.QONPKLEGMEF.FHHQNGCDOCK = null;
			GGGPJQEKNJD.QONPKLEGMEF.LJCHEBJOPGG = 602f;
		}
	}

	// Token: 0x060022DB RID: 8923 RVA: 0x000E4970 File Offset: 0x000E2B70
	protected virtual void PDCQCFKFOLQ()
	{
		this.BLLEFKOLKLP = base.transform;
		this.QJNJKLEMMLD = base.GetComponentsInChildren<ENFMCDNLEQQ>();
		this.GKHOGHHONGB = this.BLLEFKOLKLP.localPosition;
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		this.QKJDOFPEGGM(1915f);
	}

	// Token: 0x060022DC RID: 8924 RVA: 0x00012AD3 File Offset: 0x00010CD3
	public static void KPCLNLMMJFG(string PIDLOFMIEFQ)
	{
		if (GGGPJQEKNJD.QONPKLEGMEF != null)
		{
			GGGPJQEKNJD.QONPKLEGMEF.KJLKBMCCNFO(PIDLOFMIEFQ);
		}
	}

	// Token: 0x060022DD RID: 8925 RVA: 0x000E49D8 File Offset: 0x000E2BD8
	protected virtual void QFFJMIOJENJ()
	{
		if (this.FHHQNGCDOCK != EMENMKHBPQE.NFFBMPMMGEO)
		{
			this.FHHQNGCDOCK = null;
			this.LJCHEBJOPGG = 89f;
		}
		if (this.PCJONCHKHIC != this.LJCHEBJOPGG)
		{
			this.PCJONCHKHIC = Mathf.Lerp(this.PCJONCHKHIC, this.LJCHEBJOPGG, JMIOBJFFGBN.JHEKKFKJCKK() * this.JLMDLJMBHDP);
			if (Mathf.Abs(this.PCJONCHKHIC - this.LJCHEBJOPGG) < 146f)
			{
				this.PCJONCHKHIC = this.LJCHEBJOPGG;
			}
			this.BDPJNHKHMDC(this.PCJONCHKHIC * this.PCJONCHKHIC);
			if (this.LHJFEKGGCON)
			{
				Vector3 b = this.FDJMJICJCNE * 1018f;
				b.y = -b.y;
				Vector3 localScale = Vector3.one * (94f - this.PCJONCHKHIC * 1254f);
				Vector3 localPosition = Vector3.Lerp(this.GKHOGHHONGB - b, this.GKHOGHHONGB, this.PCJONCHKHIC);
				this.BLLEFKOLKLP.localPosition = localPosition;
				this.BLLEFKOLKLP.localScale = localScale;
			}
		}
	}

	// Token: 0x060022DE RID: 8926 RVA: 0x00012DFE File Offset: 0x00010FFE
	public static bool MNOCNMHNGQM()
	{
		return GGGPJQEKNJD.QONPKLEGMEF != null && GGGPJQEKNJD.QONPKLEGMEF.LJCHEBJOPGG == 1909f;
	}

	// Token: 0x060022DF RID: 8927 RVA: 0x00012E21 File Offset: 0x00011021
	public static bool PBEOQPCDBLN()
	{
		return !(GGGPJQEKNJD.QONPKLEGMEF != null) || GGGPJQEKNJD.QONPKLEGMEF.LJCHEBJOPGG == 567f;
	}

	// Token: 0x060022E0 RID: 8928 RVA: 0x00012E44 File Offset: 0x00011044
	public static void EBGMENEODCD()
	{
		if (GGGPJQEKNJD.QONPKLEGMEF != null)
		{
			GGGPJQEKNJD.QONPKLEGMEF.FHHQNGCDOCK = null;
			GGGPJQEKNJD.QONPKLEGMEF.LJCHEBJOPGG = 1437f;
		}
	}

	// Token: 0x060022E1 RID: 8929 RVA: 0x00012E6D File Offset: 0x0001106D
	public static bool JCDCNPFBECC()
	{
		return !(GGGPJQEKNJD.QONPKLEGMEF != null) || GGGPJQEKNJD.QONPKLEGMEF.LJCHEBJOPGG == 169f;
	}

	// Token: 0x060022E2 RID: 8930 RVA: 0x00012ACB File Offset: 0x00010CCB
	private void GLLCQQCCGOG()
	{
		GGGPJQEKNJD.QONPKLEGMEF = this;
	}

	// Token: 0x04000785 RID: 1925
	protected static GGGPJQEKNJD QONPKLEGMEF;

	// Token: 0x04000786 RID: 1926
	public Camera CODFIINNNPG;

	// Token: 0x04000787 RID: 1927
	public BKKHLBCLPJM PIDLOFMIEFQ;

	// Token: 0x04000788 RID: 1928
	public GameObject KNBFIMDLQOD;

	// Token: 0x04000789 RID: 1929
	public PLQFPBQEPJD MCPNNHMOFQH;

	// Token: 0x0400078A RID: 1930
	public float JLMDLJMBHDP = 10f;

	// Token: 0x0400078B RID: 1931
	public bool LHJFEKGGCON = true;

	// Token: 0x0400078C RID: 1932
	protected GameObject FHHQNGCDOCK;

	// Token: 0x0400078D RID: 1933
	protected Transform BLLEFKOLKLP;

	// Token: 0x0400078E RID: 1934
	protected float LJCHEBJOPGG;

	// Token: 0x0400078F RID: 1935
	protected float PCJONCHKHIC;

	// Token: 0x04000790 RID: 1936
	protected Vector3 GKHOGHHONGB;

	// Token: 0x04000791 RID: 1937
	protected Vector3 FDJMJICJCNE = Vector3.zero;

	// Token: 0x04000792 RID: 1938
	protected ENFMCDNLEQQ[] QJNJKLEMMLD;
}
