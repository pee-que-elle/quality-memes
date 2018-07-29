using System;
using UnityEngine;

// Token: 0x020000D4 RID: 212
[AddComponentMenu("NGUI/Tween/Tween Color")]
public class NCNDQDBPNQN : UITweener
{
	// Token: 0x0600191E RID: 6430 RVA: 0x0000D5FC File Offset: 0x0000B7FC
	public virtual void IGDGPKBIONB()
	{
		this.CGHQEHCBQHB = this.FIDCEOEFBDK();
	}

	// Token: 0x0600191F RID: 6431 RVA: 0x0000D60A File Offset: 0x0000B80A
	[ContextMenu("Assume value of 'To'")]
	private void IQPDLQCEQHJ()
	{
		this.BGBMIEJJQKC = this.BKMCCCGOGOM;
	}

	// Token: 0x06001920 RID: 6432 RVA: 0x0000D618 File Offset: 0x0000B818
	private void EEIBINLLKFN()
	{
		this.PLLQOHPCBOP(this.CGHQEHCBQHB);
	}

	// Token: 0x06001921 RID: 6433 RVA: 0x0000D626 File Offset: 0x0000B826
	protected virtual void DKBPNMEGMQM(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.PLLQOHPCBOP(Color.Lerp(this.CGHQEHCBQHB, this.BKMCCCGOGOM, PJDGFDBEOOJ));
	}

	// Token: 0x06001922 RID: 6434 RVA: 0x0000D640 File Offset: 0x0000B840
	private void LQHQKILBBHP()
	{
		this.MBKMJBBDCHL(this.CGHQEHCBQHB);
	}

	// Token: 0x06001923 RID: 6435 RVA: 0x0000D64E File Offset: 0x0000B84E
	[ContextMenu("Set 'To' to current value")]
	public override void SetEndToCurrentValue()
	{
		this.BKMCCCGOGOM = this.BGBMIEJJQKC;
	}

	// Token: 0x06001924 RID: 6436 RVA: 0x0000D65C File Offset: 0x0000B85C
	protected virtual void LGLLPJOKCJG(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.EJBFHKJNELQ(Color.Lerp(this.CGHQEHCBQHB, this.BKMCCCGOGOM, PJDGFDBEOOJ));
	}

	// Token: 0x06001925 RID: 6437 RVA: 0x0000D676 File Offset: 0x0000B876
	public virtual void HKGNOIKIHKM()
	{
		this.BKMCCCGOGOM = this.FIDCEOEFBDK();
	}

	// Token: 0x06001926 RID: 6438 RVA: 0x000ADA24 File Offset: 0x000ABC24
	public void EJBFHKJNELQ(Color BGBMIEJJQKC)
	{
		if (!this.BJJNMHBPFNL)
		{
			this.INEDIQKKJHQ();
		}
		if (this.DLQMOLJPEMO != null)
		{
			this.DLQMOLJPEMO.CEGFBBHMKOE = BGBMIEJJQKC;
		}
		else if (this.OEFCJHKBJJG != null)
		{
			this.OEFCJHKBJJG.color = BGBMIEJJQKC;
		}
		else if (this.ENNQHIBCIMC != null)
		{
			this.ENNQHIBCIMC.color = BGBMIEJJQKC;
		}
		else if (this.JKQLHGBIPQE != null)
		{
			this.JKQLHGBIPQE.color = BGBMIEJJQKC;
			this.JKQLHGBIPQE.enabled = (BGBMIEJJQKC.r + BGBMIEJJQKC.g + BGBMIEJJQKC.b > 965f);
		}
	}

	// Token: 0x06001927 RID: 6439 RVA: 0x000ADAD8 File Offset: 0x000ABCD8
	public static NCNDQDBPNQN KJJQQBDHLJE(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Color CEGFBBHMKOE)
	{
		NCNDQDBPNQN ncndqdbpnqn = UITweener.Begin<NCNDQDBPNQN>(CGHIENBIHCO, CPKNEQGKQPQ, 1057f);
		ncndqdbpnqn.CGHQEHCBQHB = ncndqdbpnqn.BGBMIEJJQKC;
		ncndqdbpnqn.BKMCCCGOGOM = CEGFBBHMKOE;
		if (CPKNEQGKQPQ <= 1124f)
		{
			ncndqdbpnqn.Sample(113f, true);
			ncndqdbpnqn.enabled = false;
		}
		return ncndqdbpnqn;
	}

	// Token: 0x06001928 RID: 6440 RVA: 0x0000D640 File Offset: 0x0000B840
	private void DDFQNPKPNFB()
	{
		this.MBKMJBBDCHL(this.CGHQEHCBQHB);
	}

	// Token: 0x06001929 RID: 6441 RVA: 0x0000D684 File Offset: 0x0000B884
	public void FPMLDMGKOKD(Color BGBMIEJJQKC)
	{
		this.GFEBHPLLBHO(BGBMIEJJQKC);
	}

	// Token: 0x170000CE RID: 206
	// (get) Token: 0x06001948 RID: 6472 RVA: 0x0000D721 File Offset: 0x0000B921
	// (set) Token: 0x0600192A RID: 6442 RVA: 0x0000D68D File Offset: 0x0000B88D
	[Obsolete("Use 'value' instead")]
	public Color CEGFBBHMKOE
	{
		get
		{
			return this.BGBMIEJJQKC;
		}
		set
		{
			this.BGBMIEJJQKC = value;
		}
	}

	// Token: 0x0600192B RID: 6443 RVA: 0x0000D676 File Offset: 0x0000B876
	public virtual void JFEHEINJDOI()
	{
		this.BKMCCCGOGOM = this.FIDCEOEFBDK();
	}

	// Token: 0x0600192C RID: 6444 RVA: 0x000ADB24 File Offset: 0x000ABD24
	public void MBKMJBBDCHL(Color BGBMIEJJQKC)
	{
		if (!this.BJJNMHBPFNL)
		{
			this.INEDIQKKJHQ();
		}
		if (this.DLQMOLJPEMO != null)
		{
			this.DLQMOLJPEMO.CEGFBBHMKOE = BGBMIEJJQKC;
		}
		else if (this.OEFCJHKBJJG != null)
		{
			this.OEFCJHKBJJG.color = BGBMIEJJQKC;
		}
		else if (this.ENNQHIBCIMC != null)
		{
			this.ENNQHIBCIMC.color = BGBMIEJJQKC;
		}
		else if (this.JKQLHGBIPQE != null)
		{
			this.JKQLHGBIPQE.color = BGBMIEJJQKC;
			this.JKQLHGBIPQE.enabled = (BGBMIEJJQKC.r + BGBMIEJJQKC.g + BGBMIEJJQKC.b > 1687f);
		}
	}

	// Token: 0x0600192D RID: 6445 RVA: 0x000ADBD8 File Offset: 0x000ABDD8
	public static NCNDQDBPNQN IOELIBBIPGB(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Color CEGFBBHMKOE)
	{
		NCNDQDBPNQN ncndqdbpnqn = UITweener.Begin<NCNDQDBPNQN>(CGHIENBIHCO, CPKNEQGKQPQ, 50f);
		ncndqdbpnqn.CGHQEHCBQHB = ncndqdbpnqn.LNJGPEKQEMI();
		ncndqdbpnqn.BKMCCCGOGOM = CEGFBBHMKOE;
		if (CPKNEQGKQPQ <= 1729f)
		{
			ncndqdbpnqn.Sample(125f, false);
			ncndqdbpnqn.enabled = false;
		}
		return ncndqdbpnqn;
	}

	// Token: 0x0600192F RID: 6447 RVA: 0x000ADC24 File Offset: 0x000ABE24
	private void CKGPJDKOMLH()
	{
		this.BJJNMHBPFNL = true;
		this.DLQMOLJPEMO = base.GetComponent<ENFMCDNLEQQ>();
		if (this.DLQMOLJPEMO != null)
		{
			return;
		}
		this.ENNQHIBCIMC = base.GetComponent<SpriteRenderer>();
		if (this.ENNQHIBCIMC != null)
		{
			return;
		}
		Renderer component = base.GetComponent<Renderer>();
		if (component != null)
		{
			this.OEFCJHKBJJG = component.material;
			return;
		}
		this.JKQLHGBIPQE = base.GetComponent<Light>();
		if (this.JKQLHGBIPQE == null)
		{
			this.DLQMOLJPEMO = base.GetComponentInChildren<ENFMCDNLEQQ>();
		}
	}

	// Token: 0x170000CF RID: 207
	// (get) Token: 0x06001930 RID: 6448 RVA: 0x000ADCB4 File Offset: 0x000ABEB4
	// (set) Token: 0x0600193C RID: 6460 RVA: 0x000ADEDC File Offset: 0x000AC0DC
	public Color BGBMIEJJQKC
	{
		get
		{
			if (!this.BJJNMHBPFNL)
			{
				this.MDKEQEPIOEF();
			}
			if (this.DLQMOLJPEMO != null)
			{
				return this.DLQMOLJPEMO.CEGFBBHMKOE;
			}
			if (this.OEFCJHKBJJG != null)
			{
				return this.OEFCJHKBJJG.color;
			}
			if (this.ENNQHIBCIMC != null)
			{
				return this.ENNQHIBCIMC.color;
			}
			if (this.JKQLHGBIPQE != null)
			{
				return this.JKQLHGBIPQE.color;
			}
			return Color.black;
		}
		set
		{
			if (!this.BJJNMHBPFNL)
			{
				this.MDKEQEPIOEF();
			}
			if (this.DLQMOLJPEMO != null)
			{
				this.DLQMOLJPEMO.CEGFBBHMKOE = value;
			}
			else if (this.OEFCJHKBJJG != null)
			{
				this.OEFCJHKBJJG.color = value;
			}
			else if (this.ENNQHIBCIMC != null)
			{
				this.ENNQHIBCIMC.color = value;
			}
			else if (this.JKQLHGBIPQE != null)
			{
				this.JKQLHGBIPQE.color = value;
				this.JKQLHGBIPQE.enabled = (value.r + value.g + value.b > 0.01f);
			}
		}
	}

	// Token: 0x06001931 RID: 6449 RVA: 0x0000D6B4 File Offset: 0x0000B8B4
	public void BOPEKJMOQNG(Color BGBMIEJJQKC)
	{
		this.NCBFKNGMKPB(BGBMIEJJQKC);
	}

	// Token: 0x06001932 RID: 6450 RVA: 0x0000D6BD File Offset: 0x0000B8BD
	[ContextMenu("Set 'From' to current value")]
	public override void SetStartToCurrentValue()
	{
		this.CGHQEHCBQHB = this.BGBMIEJJQKC;
	}

	// Token: 0x06001933 RID: 6451 RVA: 0x000ADD3C File Offset: 0x000ABF3C
	public Color FIDCEOEFBDK()
	{
		if (!this.BJJNMHBPFNL)
		{
			this.CKGPJDKOMLH();
		}
		if (this.DLQMOLJPEMO != null)
		{
			return this.DLQMOLJPEMO.CEGFBBHMKOE;
		}
		if (this.OEFCJHKBJJG != null)
		{
			return this.OEFCJHKBJJG.color;
		}
		if (this.ENNQHIBCIMC != null)
		{
			return this.ENNQHIBCIMC.color;
		}
		if (this.JKQLHGBIPQE != null)
		{
			return this.JKQLHGBIPQE.color;
		}
		return Color.black;
	}

	// Token: 0x06001934 RID: 6452 RVA: 0x000ADDC4 File Offset: 0x000ABFC4
	public Color LGNFPGFPBII()
	{
		if (!this.BJJNMHBPFNL)
		{
			this.CCIMLKPPCMP();
		}
		if (this.DLQMOLJPEMO != null)
		{
			return this.DLQMOLJPEMO.CEGFBBHMKOE;
		}
		if (this.OEFCJHKBJJG != null)
		{
			return this.OEFCJHKBJJG.color;
		}
		if (this.ENNQHIBCIMC != null)
		{
			return this.ENNQHIBCIMC.color;
		}
		if (this.JKQLHGBIPQE != null)
		{
			return this.JKQLHGBIPQE.color;
		}
		return Color.black;
	}

	// Token: 0x06001935 RID: 6453 RVA: 0x0000D6CB File Offset: 0x0000B8CB
	[ContextMenu("Assume value of 'From'")]
	private void MOKOMDGBDHD()
	{
		this.BGBMIEJJQKC = this.CGHQEHCBQHB;
	}

	// Token: 0x06001936 RID: 6454 RVA: 0x000ADCB4 File Offset: 0x000ABEB4
	public Color LDPDKOQLDDJ()
	{
		if (!this.BJJNMHBPFNL)
		{
			this.MDKEQEPIOEF();
		}
		if (this.DLQMOLJPEMO != null)
		{
			return this.DLQMOLJPEMO.CEGFBBHMKOE;
		}
		if (this.OEFCJHKBJJG != null)
		{
			return this.OEFCJHKBJJG.color;
		}
		if (this.ENNQHIBCIMC != null)
		{
			return this.ENNQHIBCIMC.color;
		}
		if (this.JKQLHGBIPQE != null)
		{
			return this.JKQLHGBIPQE.color;
		}
		return Color.black;
	}

	// Token: 0x06001937 RID: 6455 RVA: 0x000ADE4C File Offset: 0x000AC04C
	private void CCIMLKPPCMP()
	{
		this.BJJNMHBPFNL = false;
		this.DLQMOLJPEMO = base.GetComponent<ENFMCDNLEQQ>();
		if (this.DLQMOLJPEMO != null)
		{
			return;
		}
		this.ENNQHIBCIMC = base.GetComponent<SpriteRenderer>();
		if (this.ENNQHIBCIMC != null)
		{
			return;
		}
		Renderer component = base.GetComponent<Renderer>();
		if (component != null)
		{
			this.OEFCJHKBJJG = component.material;
			return;
		}
		this.JKQLHGBIPQE = base.GetComponent<Light>();
		if (this.JKQLHGBIPQE == null)
		{
			this.DLQMOLJPEMO = base.GetComponentInChildren<ENFMCDNLEQQ>();
		}
	}

	// Token: 0x06001938 RID: 6456 RVA: 0x000ADE4C File Offset: 0x000AC04C
	private void KLEGKCFNHBM()
	{
		this.BJJNMHBPFNL = false;
		this.DLQMOLJPEMO = base.GetComponent<ENFMCDNLEQQ>();
		if (this.DLQMOLJPEMO != null)
		{
			return;
		}
		this.ENNQHIBCIMC = base.GetComponent<SpriteRenderer>();
		if (this.ENNQHIBCIMC != null)
		{
			return;
		}
		Renderer component = base.GetComponent<Renderer>();
		if (component != null)
		{
			this.OEFCJHKBJJG = component.material;
			return;
		}
		this.JKQLHGBIPQE = base.GetComponent<Light>();
		if (this.JKQLHGBIPQE == null)
		{
			this.DLQMOLJPEMO = base.GetComponentInChildren<ENFMCDNLEQQ>();
		}
	}

	// Token: 0x06001939 RID: 6457 RVA: 0x0000D640 File Offset: 0x0000B840
	private void LCFMIIJNOIF()
	{
		this.MBKMJBBDCHL(this.CGHQEHCBQHB);
	}

	// Token: 0x0600193A RID: 6458 RVA: 0x0000D5FC File Offset: 0x0000B7FC
	public virtual void NPDKICCNHJP()
	{
		this.CGHQEHCBQHB = this.FIDCEOEFBDK();
	}

	// Token: 0x0600193B RID: 6459 RVA: 0x0000D6D9 File Offset: 0x0000B8D9
	private void PCJODQLGMKM()
	{
		this.NCBFKNGMKPB(this.BKMCCCGOGOM);
	}

	// Token: 0x0600193D RID: 6461 RVA: 0x0000D65C File Offset: 0x0000B85C
	protected virtual void GLCDMLHOQGQ(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.EJBFHKJNELQ(Color.Lerp(this.CGHQEHCBQHB, this.BKMCCCGOGOM, PJDGFDBEOOJ));
	}

	// Token: 0x0600193E RID: 6462 RVA: 0x000ADC24 File Offset: 0x000ABE24
	private void GCGLQMHGLJG()
	{
		this.BJJNMHBPFNL = true;
		this.DLQMOLJPEMO = base.GetComponent<ENFMCDNLEQQ>();
		if (this.DLQMOLJPEMO != null)
		{
			return;
		}
		this.ENNQHIBCIMC = base.GetComponent<SpriteRenderer>();
		if (this.ENNQHIBCIMC != null)
		{
			return;
		}
		Renderer component = base.GetComponent<Renderer>();
		if (component != null)
		{
			this.OEFCJHKBJJG = component.material;
			return;
		}
		this.JKQLHGBIPQE = base.GetComponent<Light>();
		if (this.JKQLHGBIPQE == null)
		{
			this.DLQMOLJPEMO = base.GetComponentInChildren<ENFMCDNLEQQ>();
		}
	}

	// Token: 0x0600193F RID: 6463 RVA: 0x000ADF90 File Offset: 0x000AC190
	public void KPEFQHMGEJC(Color BGBMIEJJQKC)
	{
		if (!this.BJJNMHBPFNL)
		{
			this.GCGLQMHGLJG();
		}
		if (this.DLQMOLJPEMO != null)
		{
			this.DLQMOLJPEMO.NONQDHBCIIN(BGBMIEJJQKC);
		}
		else if (this.OEFCJHKBJJG != null)
		{
			this.OEFCJHKBJJG.color = BGBMIEJJQKC;
		}
		else if (this.ENNQHIBCIMC != null)
		{
			this.ENNQHIBCIMC.color = BGBMIEJJQKC;
		}
		else if (this.JKQLHGBIPQE != null)
		{
			this.JKQLHGBIPQE.color = BGBMIEJJQKC;
			this.JKQLHGBIPQE.enabled = (BGBMIEJJQKC.r + BGBMIEJJQKC.g + BGBMIEJJQKC.b > 1574f);
		}
	}

	// Token: 0x06001940 RID: 6464 RVA: 0x000AE044 File Offset: 0x000AC244
	public void GFEBHPLLBHO(Color BGBMIEJJQKC)
	{
		if (!this.BJJNMHBPFNL)
		{
			this.CKGPJDKOMLH();
		}
		if (this.DLQMOLJPEMO != null)
		{
			this.DLQMOLJPEMO.CEGFBBHMKOE = BGBMIEJJQKC;
		}
		else if (this.OEFCJHKBJJG != null)
		{
			this.OEFCJHKBJJG.color = BGBMIEJJQKC;
		}
		else if (this.ENNQHIBCIMC != null)
		{
			this.ENNQHIBCIMC.color = BGBMIEJJQKC;
		}
		else if (this.JKQLHGBIPQE != null)
		{
			this.JKQLHGBIPQE.color = BGBMIEJJQKC;
			this.JKQLHGBIPQE.enabled = (BGBMIEJJQKC.r + BGBMIEJJQKC.g + BGBMIEJJQKC.b > 1749f);
		}
	}

	// Token: 0x06001941 RID: 6465 RVA: 0x0000D6E7 File Offset: 0x0000B8E7
	public void DLHHMBCDPIQ(Color BGBMIEJJQKC)
	{
		this.EJBFHKJNELQ(BGBMIEJJQKC);
	}

	// Token: 0x06001942 RID: 6466 RVA: 0x0000D6F0 File Offset: 0x0000B8F0
	protected override void OnUpdate(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.BGBMIEJJQKC = Color.Lerp(this.CGHQEHCBQHB, this.BKMCCCGOGOM, PJDGFDBEOOJ);
	}

	// Token: 0x06001943 RID: 6467 RVA: 0x0000D70A File Offset: 0x0000B90A
	public void BDOFCNNCFEG(Color BGBMIEJJQKC)
	{
		this.MBKMJBBDCHL(BGBMIEJJQKC);
	}

	// Token: 0x06001944 RID: 6468 RVA: 0x000ADD3C File Offset: 0x000ABF3C
	public Color LNJGPEKQEMI()
	{
		if (!this.BJJNMHBPFNL)
		{
			this.CKGPJDKOMLH();
		}
		if (this.DLQMOLJPEMO != null)
		{
			return this.DLQMOLJPEMO.CEGFBBHMKOE;
		}
		if (this.OEFCJHKBJJG != null)
		{
			return this.OEFCJHKBJJG.color;
		}
		if (this.ENNQHIBCIMC != null)
		{
			return this.ENNQHIBCIMC.color;
		}
		if (this.JKQLHGBIPQE != null)
		{
			return this.JKQLHGBIPQE.color;
		}
		return Color.black;
	}

	// Token: 0x06001945 RID: 6469 RVA: 0x000AE0F8 File Offset: 0x000AC2F8
	public void KIGFOKPIBHK(Color BGBMIEJJQKC)
	{
		if (!this.BJJNMHBPFNL)
		{
			this.MDKEQEPIOEF();
		}
		if (this.DLQMOLJPEMO != null)
		{
			this.DLQMOLJPEMO.CEGFBBHMKOE = BGBMIEJJQKC;
		}
		else if (this.OEFCJHKBJJG != null)
		{
			this.OEFCJHKBJJG.color = BGBMIEJJQKC;
		}
		else if (this.ENNQHIBCIMC != null)
		{
			this.ENNQHIBCIMC.color = BGBMIEJJQKC;
		}
		else if (this.JKQLHGBIPQE != null)
		{
			this.JKQLHGBIPQE.color = BGBMIEJJQKC;
			this.JKQLHGBIPQE.enabled = (BGBMIEJJQKC.r + BGBMIEJJQKC.g + BGBMIEJJQKC.b > 854f);
		}
	}

	// Token: 0x06001946 RID: 6470 RVA: 0x000AE1AC File Offset: 0x000AC3AC
	public static NCNDQDBPNQN FEBFHOPOJQN(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Color CEGFBBHMKOE)
	{
		NCNDQDBPNQN ncndqdbpnqn = UITweener.Begin<NCNDQDBPNQN>(CGHIENBIHCO, CPKNEQGKQPQ, 998f);
		ncndqdbpnqn.CGHQEHCBQHB = ncndqdbpnqn.LGNFPGFPBII();
		ncndqdbpnqn.BKMCCCGOGOM = CEGFBBHMKOE;
		if (CPKNEQGKQPQ <= 1815f)
		{
			ncndqdbpnqn.Sample(535f, true);
			ncndqdbpnqn.enabled = true;
		}
		return ncndqdbpnqn;
	}

	// Token: 0x06001947 RID: 6471 RVA: 0x0000D713 File Offset: 0x0000B913
	private void MEFFOGNODMH()
	{
		this.MBKMJBBDCHL(this.BKMCCCGOGOM);
	}

	// Token: 0x06001949 RID: 6473 RVA: 0x0000D68D File Offset: 0x0000B88D
	public void DNKFGLMFOKD(Color BGBMIEJJQKC)
	{
		this.BGBMIEJJQKC = BGBMIEJJQKC;
	}

	// Token: 0x0600194A RID: 6474 RVA: 0x000AE1F8 File Offset: 0x000AC3F8
	public static NCNDQDBPNQN FJCEGFKJLCL(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Color CEGFBBHMKOE)
	{
		NCNDQDBPNQN ncndqdbpnqn = UITweener.Begin<NCNDQDBPNQN>(CGHIENBIHCO, CPKNEQGKQPQ, 0f);
		ncndqdbpnqn.CGHQEHCBQHB = ncndqdbpnqn.BGBMIEJJQKC;
		ncndqdbpnqn.BKMCCCGOGOM = CEGFBBHMKOE;
		if (CPKNEQGKQPQ <= 0f)
		{
			ncndqdbpnqn.Sample(1f, true);
			ncndqdbpnqn.enabled = false;
		}
		return ncndqdbpnqn;
	}

	// Token: 0x0600194B RID: 6475 RVA: 0x000ADE4C File Offset: 0x000AC04C
	private void INEDIQKKJHQ()
	{
		this.BJJNMHBPFNL = false;
		this.DLQMOLJPEMO = base.GetComponent<ENFMCDNLEQQ>();
		if (this.DLQMOLJPEMO != null)
		{
			return;
		}
		this.ENNQHIBCIMC = base.GetComponent<SpriteRenderer>();
		if (this.ENNQHIBCIMC != null)
		{
			return;
		}
		Renderer component = base.GetComponent<Renderer>();
		if (component != null)
		{
			this.OEFCJHKBJJG = component.material;
			return;
		}
		this.JKQLHGBIPQE = base.GetComponent<Light>();
		if (this.JKQLHGBIPQE == null)
		{
			this.DLQMOLJPEMO = base.GetComponentInChildren<ENFMCDNLEQQ>();
		}
	}

	// Token: 0x0600194C RID: 6476 RVA: 0x0000D729 File Offset: 0x0000B929
	public Color OQIQNIGDOFE()
	{
		return this.FIDCEOEFBDK();
	}

	// Token: 0x0600194D RID: 6477 RVA: 0x000AE244 File Offset: 0x000AC444
	public static NCNDQDBPNQN OBCNHPELFJK(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Color CEGFBBHMKOE)
	{
		NCNDQDBPNQN ncndqdbpnqn = UITweener.Begin<NCNDQDBPNQN>(CGHIENBIHCO, CPKNEQGKQPQ, 1030f);
		ncndqdbpnqn.CGHQEHCBQHB = ncndqdbpnqn.LNJGPEKQEMI();
		ncndqdbpnqn.BKMCCCGOGOM = CEGFBBHMKOE;
		if (CPKNEQGKQPQ <= 878f)
		{
			ncndqdbpnqn.Sample(636f, false);
			ncndqdbpnqn.enabled = false;
		}
		return ncndqdbpnqn;
	}

	// Token: 0x0600194E RID: 6478 RVA: 0x000AE290 File Offset: 0x000AC490
	public static NCNDQDBPNQN EOKHEPPPQDD(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Color CEGFBBHMKOE)
	{
		NCNDQDBPNQN ncndqdbpnqn = UITweener.Begin<NCNDQDBPNQN>(CGHIENBIHCO, CPKNEQGKQPQ, 556f);
		ncndqdbpnqn.CGHQEHCBQHB = ncndqdbpnqn.LNJGPEKQEMI();
		ncndqdbpnqn.BKMCCCGOGOM = CEGFBBHMKOE;
		if (CPKNEQGKQPQ <= 812f)
		{
			ncndqdbpnqn.Sample(1500f, false);
			ncndqdbpnqn.enabled = true;
		}
		return ncndqdbpnqn;
	}

	// Token: 0x0600194F RID: 6479 RVA: 0x0000D731 File Offset: 0x0000B931
	public virtual void EJCLFGKMBEB()
	{
		this.CGHQEHCBQHB = this.LNJGPEKQEMI();
	}

	// Token: 0x06001950 RID: 6480 RVA: 0x000ADC24 File Offset: 0x000ABE24
	private void MDKEQEPIOEF()
	{
		this.BJJNMHBPFNL = true;
		this.DLQMOLJPEMO = base.GetComponent<ENFMCDNLEQQ>();
		if (this.DLQMOLJPEMO != null)
		{
			return;
		}
		this.ENNQHIBCIMC = base.GetComponent<SpriteRenderer>();
		if (this.ENNQHIBCIMC != null)
		{
			return;
		}
		Renderer component = base.GetComponent<Renderer>();
		if (component != null)
		{
			this.OEFCJHKBJJG = component.material;
			return;
		}
		this.JKQLHGBIPQE = base.GetComponent<Light>();
		if (this.JKQLHGBIPQE == null)
		{
			this.DLQMOLJPEMO = base.GetComponentInChildren<ENFMCDNLEQQ>();
		}
	}

	// Token: 0x06001951 RID: 6481 RVA: 0x0000D73F File Offset: 0x0000B93F
	public virtual void EQGCGMJNJPE()
	{
		this.BKMCCCGOGOM = this.LNJGPEKQEMI();
	}

	// Token: 0x06001952 RID: 6482 RVA: 0x000AE2DC File Offset: 0x000AC4DC
	public void NCBFKNGMKPB(Color BGBMIEJJQKC)
	{
		if (!this.BJJNMHBPFNL)
		{
			this.KLEGKCFNHBM();
		}
		if (this.DLQMOLJPEMO != null)
		{
			this.DLQMOLJPEMO.CEGFBBHMKOE = BGBMIEJJQKC;
		}
		else if (this.OEFCJHKBJJG != null)
		{
			this.OEFCJHKBJJG.color = BGBMIEJJQKC;
		}
		else if (this.ENNQHIBCIMC != null)
		{
			this.ENNQHIBCIMC.color = BGBMIEJJQKC;
		}
		else if (this.JKQLHGBIPQE != null)
		{
			this.JKQLHGBIPQE.color = BGBMIEJJQKC;
			this.JKQLHGBIPQE.enabled = (BGBMIEJJQKC.r + BGBMIEJJQKC.g + BGBMIEJJQKC.b > 411f);
		}
	}

	// Token: 0x06001953 RID: 6483 RVA: 0x000AE390 File Offset: 0x000AC590
	public void PLLQOHPCBOP(Color BGBMIEJJQKC)
	{
		if (!this.BJJNMHBPFNL)
		{
			this.GCGLQMHGLJG();
		}
		if (this.DLQMOLJPEMO != null)
		{
			this.DLQMOLJPEMO.NONQDHBCIIN(BGBMIEJJQKC);
		}
		else if (this.OEFCJHKBJJG != null)
		{
			this.OEFCJHKBJJG.color = BGBMIEJJQKC;
		}
		else if (this.ENNQHIBCIMC != null)
		{
			this.ENNQHIBCIMC.color = BGBMIEJJQKC;
		}
		else if (this.JKQLHGBIPQE != null)
		{
			this.JKQLHGBIPQE.color = BGBMIEJJQKC;
			this.JKQLHGBIPQE.enabled = (BGBMIEJJQKC.r + BGBMIEJJQKC.g + BGBMIEJJQKC.b > 826f);
		}
	}

	// Token: 0x04000513 RID: 1299
	public Color CGHQEHCBQHB = Color.white;

	// Token: 0x04000514 RID: 1300
	public Color BKMCCCGOGOM = Color.white;

	// Token: 0x04000515 RID: 1301
	private bool BJJNMHBPFNL;

	// Token: 0x04000516 RID: 1302
	private ENFMCDNLEQQ DLQMOLJPEMO;

	// Token: 0x04000517 RID: 1303
	private Material OEFCJHKBJJG;

	// Token: 0x04000518 RID: 1304
	private Light JKQLHGBIPQE;

	// Token: 0x04000519 RID: 1305
	private SpriteRenderer ENNQHIBCIMC;
}
