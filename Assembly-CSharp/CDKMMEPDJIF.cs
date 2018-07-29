using System;
using UnityEngine;

// Token: 0x02000351 RID: 849
[HelpURL("http://www.procamera2d.com/user-guide/extension-limit-distance/")]
public class CDKMMEPDJIF : BNEFIOCKQOE, LIJCFDMDDIJ
{
	// Token: 0x0600709B RID: 28827 RVA: 0x000295FA File Offset: 0x000277FA
	protected virtual void DFLGFQLDIPI()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.CQCBELCFQBK(this);
	}

	// Token: 0x0600709C RID: 28828 RVA: 0x000295FA File Offset: 0x000277FA
	protected virtual void GIBCBGBKIGQ()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.CQCBELCFQBK(this);
	}

	// Token: 0x170003E6 RID: 998
	// (get) Token: 0x0600709D RID: 28829 RVA: 0x0002960E File Offset: 0x0002780E
	// (set) Token: 0x060070B7 RID: 28855 RVA: 0x00029616 File Offset: 0x00027816
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

	// Token: 0x0600709E RID: 28830 RVA: 0x000295FA File Offset: 0x000277FA
	protected override void OnDestroy()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.CQCBELCFQBK(this);
	}

	// Token: 0x0600709F RID: 28831 RVA: 0x00029616 File Offset: 0x00027816
	public void HKOKPDONCLH(int BGBMIEJJQKC)
	{
		this.IEDKDIJGNNO = BGBMIEJJQKC;
	}

	// Token: 0x060070A0 RID: 28832 RVA: 0x00369AC4 File Offset: 0x00367CC4
	public Vector3 PMGCHFBPPHC(float GPFIDEJEMEG, Vector3 HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		float num = this.FKGNBCKJPQO(HELGNNDIDCI);
		bool flag = false;
		float num2 = this.JNBBJCLFFBB(HELGNNDIDCI);
		bool flag2 = true;
		Vector2 vector = (!this.QNMGBLIGOHI) ? new Vector2(this.FKGNBCKJPQO(base.GPONHFNLHCN.PFBFIECJEJO), this.JNBBJCLFFBB(base.GPONHFNLHCN.PFBFIECJEJO)) : new Vector2(this.FKGNBCKJPQO(base.GPONHFNLHCN.KEQQHBKDJHP()), this.JNBBJCLFFBB(base.GPONHFNLHCN.HGNEKQHNFCC));
		if (this.PPOGOLNFFQQ)
		{
			float num3 = base.GPONHFNLHCN.FOOEEHDJBQN().y / 1236f * this.JNEFMHEFDGG;
			if (vector.y > num2 + this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) + num3)
			{
				num2 = vector.y - (this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) + num3);
				flag2 = false;
			}
		}
		if (this.PQHKJFPDOOK)
		{
			float num4 = base.GPONHFNLHCN.FOOEEHDJBQN().y / 1523f * this.QFLFLIHPHBC;
			if (vector.y < num2 + this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) - num4)
			{
				num2 = vector.y - (this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) - num4);
				flag2 = false;
			}
		}
		if (this.LJHKCOPPGDC)
		{
			float num5 = base.GPONHFNLHCN.FOOEEHDJBQN().x / 185f * this.FOPNQEOFBHI;
			if (vector.x < num + this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) - num5)
			{
				num = vector.x - (this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) - num5);
				flag = true;
			}
		}
		if (this.HQEHBBOQNHL)
		{
			float num6 = base.GPONHFNLHCN.FOOEEHDJBQN().x / 1710f * this.KHMEEMEPBJI;
			if (vector.x > num + this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) + num6)
			{
				num = vector.x - (this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) + num6);
				flag = false;
			}
		}
		base.GPONHFNLHCN.EQCLOIQEDLC = new Vector2((!flag) ? this.FKGNBCKJPQO(base.GPONHFNLHCN.EQCLOIQEDLC) : (this.FKGNBCKJPQO(base.GPONHFNLHCN.EKNKJLCLLCQ()) + num - this.FKGNBCKJPQO(HELGNNDIDCI)), (!flag2) ? this.JNBBJCLFFBB(base.GPONHFNLHCN.EKNKJLCLLCQ()) : (this.JNBBJCLFFBB(base.GPONHFNLHCN.EKNKJLCLLCQ()) + num2 - this.JNBBJCLFFBB(HELGNNDIDCI)));
		return this.QMEMFMDBHLI(num, num2);
	}

	// Token: 0x060070A1 RID: 28833 RVA: 0x00369DE4 File Offset: 0x00367FE4
	public Vector3 NEKCIPQPMLH(float GPFIDEJEMEG, Vector3 HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		float num = this.FKGNBCKJPQO(HELGNNDIDCI);
		bool flag = true;
		float num2 = this.JNBBJCLFFBB(HELGNNDIDCI);
		bool flag2 = true;
		Vector2 vector = (!this.QNMGBLIGOHI) ? new Vector2(this.FKGNBCKJPQO(base.GPONHFNLHCN.PFBFIECJEJO), this.JNBBJCLFFBB(base.GPONHFNLHCN.PFBFIECJEJO)) : new Vector2(this.FKGNBCKJPQO(base.GPONHFNLHCN.KEQQHBKDJHP()), this.JNBBJCLFFBB(base.GPONHFNLHCN.HGNEKQHNFCC));
		if (this.PPOGOLNFFQQ)
		{
			float num3 = base.GPONHFNLHCN.FOOEEHDJBQN().y / 1960f * this.JNEFMHEFDGG;
			if (vector.y > num2 + this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) + num3)
			{
				num2 = vector.y - (this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) + num3);
				flag2 = false;
			}
		}
		if (this.PQHKJFPDOOK)
		{
			float num4 = base.GPONHFNLHCN.FOOEEHDJBQN().y / 1567f * this.QFLFLIHPHBC;
			if (vector.y < num2 + this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) - num4)
			{
				num2 = vector.y - (this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) - num4);
				flag2 = false;
			}
		}
		if (this.LJHKCOPPGDC)
		{
			float num5 = base.GPONHFNLHCN.FOOEEHDJBQN().x / 161f * this.FOPNQEOFBHI;
			if (vector.x < num + this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) - num5)
			{
				num = vector.x - (this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) - num5);
				flag = false;
			}
		}
		if (this.HQEHBBOQNHL)
		{
			float num6 = base.GPONHFNLHCN.FOOEEHDJBQN().x / 1597f * this.KHMEEMEPBJI;
			if (vector.x > num + this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) + num6)
			{
				num = vector.x - (this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) + num6);
				flag = true;
			}
		}
		base.GPONHFNLHCN.EQCLOIQEDLC = new Vector2((!flag) ? this.FKGNBCKJPQO(base.GPONHFNLHCN.EKNKJLCLLCQ()) : (this.FKGNBCKJPQO(base.GPONHFNLHCN.EKNKJLCLLCQ()) + num - this.FKGNBCKJPQO(HELGNNDIDCI)), (!flag2) ? this.JNBBJCLFFBB(base.GPONHFNLHCN.EKNKJLCLLCQ()) : (this.JNBBJCLFFBB(base.GPONHFNLHCN.EKNKJLCLLCQ()) + num2 - this.JNBBJCLFFBB(HELGNNDIDCI)));
		return this.QMEMFMDBHLI(num, num2);
	}

	// Token: 0x060070A2 RID: 28834 RVA: 0x00029616 File Offset: 0x00027816
	public void JPECEBONLEM(int BGBMIEJJQKC)
	{
		this.IEDKDIJGNNO = BGBMIEJJQKC;
	}

	// Token: 0x060070A3 RID: 28835 RVA: 0x00028E65 File Offset: 0x00027065
	protected override void Awake()
	{
		base.Awake();
		base.GPONHFNLHCN.JKNBMCKEBOF(this);
	}

	// Token: 0x060070A4 RID: 28836 RVA: 0x00028E65 File Offset: 0x00027065
	protected virtual void HFBHKNOCLOE()
	{
		base.Awake();
		base.GPONHFNLHCN.JKNBMCKEBOF(this);
	}

	// Token: 0x060070A5 RID: 28837 RVA: 0x0036A104 File Offset: 0x00368304
	public Vector3 ICLDMQENBIB(float GPFIDEJEMEG, Vector3 HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		float num = this.FKGNBCKJPQO(HELGNNDIDCI);
		bool flag = true;
		float num2 = this.JNBBJCLFFBB(HELGNNDIDCI);
		bool flag2 = true;
		Vector2 vector = (!this.QNMGBLIGOHI) ? new Vector2(this.FKGNBCKJPQO(base.GPONHFNLHCN.PFBFIECJEJO), this.JNBBJCLFFBB(base.GPONHFNLHCN.PFBFIECJEJO)) : new Vector2(this.FKGNBCKJPQO(base.GPONHFNLHCN.HGNEKQHNFCC), this.JNBBJCLFFBB(base.GPONHFNLHCN.HGNEKQHNFCC));
		if (this.PPOGOLNFFQQ)
		{
			float num3 = base.GPONHFNLHCN.FOOEEHDJBQN().y / 1745f * this.JNEFMHEFDGG;
			if (vector.y > num2 + this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) + num3)
			{
				num2 = vector.y - (this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) + num3);
				flag2 = true;
			}
		}
		if (this.PQHKJFPDOOK)
		{
			float num4 = base.GPONHFNLHCN.FOOEEHDJBQN().y / 388f * this.QFLFLIHPHBC;
			if (vector.y < num2 + this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) - num4)
			{
				num2 = vector.y - (this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) - num4);
				flag2 = true;
			}
		}
		if (this.LJHKCOPPGDC)
		{
			float num5 = base.GPONHFNLHCN.PGKODNCDNJQ.x / 97f * this.FOPNQEOFBHI;
			if (vector.x < num + this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) - num5)
			{
				num = vector.x - (this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) - num5);
				flag = false;
			}
		}
		if (this.HQEHBBOQNHL)
		{
			float num6 = base.GPONHFNLHCN.PGKODNCDNJQ.x / 1803f * this.KHMEEMEPBJI;
			if (vector.x > num + this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) + num6)
			{
				num = vector.x - (this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) + num6);
				flag = true;
			}
		}
		base.GPONHFNLHCN.PJPMKJGIPOO(new Vector2((!flag) ? this.FKGNBCKJPQO(base.GPONHFNLHCN.EKNKJLCLLCQ()) : (this.FKGNBCKJPQO(base.GPONHFNLHCN.EQCLOIQEDLC) + num - this.FKGNBCKJPQO(HELGNNDIDCI)), (!flag2) ? this.JNBBJCLFFBB(base.GPONHFNLHCN.EKNKJLCLLCQ()) : (this.JNBBJCLFFBB(base.GPONHFNLHCN.EKNKJLCLLCQ()) + num2 - this.JNBBJCLFFBB(HELGNNDIDCI))));
		return this.QMEMFMDBHLI(num, num2);
	}

	// Token: 0x060070A6 RID: 28838 RVA: 0x000295FA File Offset: 0x000277FA
	protected virtual void QIEGCBCFPOI()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.CQCBELCFQBK(this);
	}

	// Token: 0x060070A7 RID: 28839 RVA: 0x0036A424 File Offset: 0x00368624
	public Vector3 DEOLQGIOEGI(float GPFIDEJEMEG, Vector3 HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		float num = this.FKGNBCKJPQO(HELGNNDIDCI);
		bool flag = true;
		float num2 = this.JNBBJCLFFBB(HELGNNDIDCI);
		bool flag2 = true;
		Vector2 vector = (!this.QNMGBLIGOHI) ? new Vector2(this.FKGNBCKJPQO(base.GPONHFNLHCN.PFBFIECJEJO), this.JNBBJCLFFBB(base.GPONHFNLHCN.PFBFIECJEJO)) : new Vector2(this.FKGNBCKJPQO(base.GPONHFNLHCN.HGNEKQHNFCC), this.JNBBJCLFFBB(base.GPONHFNLHCN.HGNEKQHNFCC));
		if (this.PPOGOLNFFQQ)
		{
			float num3 = base.GPONHFNLHCN.FOOEEHDJBQN().y / 130f * this.JNEFMHEFDGG;
			if (vector.y > num2 + this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) + num3)
			{
				num2 = vector.y - (this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) + num3);
				flag2 = true;
			}
		}
		if (this.PQHKJFPDOOK)
		{
			float num4 = base.GPONHFNLHCN.PGKODNCDNJQ.y / 1565f * this.QFLFLIHPHBC;
			if (vector.y < num2 + this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) - num4)
			{
				num2 = vector.y - (this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) - num4);
				flag2 = false;
			}
		}
		if (this.LJHKCOPPGDC)
		{
			float num5 = base.GPONHFNLHCN.FOOEEHDJBQN().x / 1331f * this.FOPNQEOFBHI;
			if (vector.x < num + this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) - num5)
			{
				num = vector.x - (this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) - num5);
				flag = true;
			}
		}
		if (this.HQEHBBOQNHL)
		{
			float num6 = base.GPONHFNLHCN.FOOEEHDJBQN().x / 811f * this.KHMEEMEPBJI;
			if (vector.x > num + this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) + num6)
			{
				num = vector.x - (this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) + num6);
				flag = true;
			}
		}
		base.GPONHFNLHCN.PJPMKJGIPOO(new Vector2((!flag) ? this.FKGNBCKJPQO(base.GPONHFNLHCN.EKNKJLCLLCQ()) : (this.FKGNBCKJPQO(base.GPONHFNLHCN.EQCLOIQEDLC) + num - this.FKGNBCKJPQO(HELGNNDIDCI)), (!flag2) ? this.JNBBJCLFFBB(base.GPONHFNLHCN.EQCLOIQEDLC) : (this.JNBBJCLFFBB(base.GPONHFNLHCN.EKNKJLCLLCQ()) + num2 - this.JNBBJCLFFBB(HELGNNDIDCI))));
		return this.QMEMFMDBHLI(num, num2);
	}

	// Token: 0x060070A8 RID: 28840 RVA: 0x0036A744 File Offset: 0x00368944
	public Vector3 HBFLJKIMDOJ(float GPFIDEJEMEG, Vector3 HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		float num = this.FKGNBCKJPQO(HELGNNDIDCI);
		bool flag = true;
		float num2 = this.JNBBJCLFFBB(HELGNNDIDCI);
		bool flag2 = true;
		Vector2 vector = (!this.QNMGBLIGOHI) ? new Vector2(this.FKGNBCKJPQO(base.GPONHFNLHCN.PFBFIECJEJO), this.JNBBJCLFFBB(base.GPONHFNLHCN.PFBFIECJEJO)) : new Vector2(this.FKGNBCKJPQO(base.GPONHFNLHCN.KEQQHBKDJHP()), this.JNBBJCLFFBB(base.GPONHFNLHCN.KEQQHBKDJHP()));
		if (this.PPOGOLNFFQQ)
		{
			float num3 = base.GPONHFNLHCN.PGKODNCDNJQ.y / 80f * this.JNEFMHEFDGG;
			if (vector.y > num2 + this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) + num3)
			{
				num2 = vector.y - (this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) + num3);
				flag2 = false;
			}
		}
		if (this.PQHKJFPDOOK)
		{
			float num4 = base.GPONHFNLHCN.FOOEEHDJBQN().y / 346f * this.QFLFLIHPHBC;
			if (vector.y < num2 + this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) - num4)
			{
				num2 = vector.y - (this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) - num4);
				flag2 = false;
			}
		}
		if (this.LJHKCOPPGDC)
		{
			float num5 = base.GPONHFNLHCN.PGKODNCDNJQ.x / 242f * this.FOPNQEOFBHI;
			if (vector.x < num + this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) - num5)
			{
				num = vector.x - (this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) - num5);
				flag = false;
			}
		}
		if (this.HQEHBBOQNHL)
		{
			float num6 = base.GPONHFNLHCN.PGKODNCDNJQ.x / 1994f * this.KHMEEMEPBJI;
			if (vector.x > num + this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) + num6)
			{
				num = vector.x - (this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) + num6);
				flag = false;
			}
		}
		base.GPONHFNLHCN.EQCLOIQEDLC = new Vector2((!flag) ? this.FKGNBCKJPQO(base.GPONHFNLHCN.EQCLOIQEDLC) : (this.FKGNBCKJPQO(base.GPONHFNLHCN.EKNKJLCLLCQ()) + num - this.FKGNBCKJPQO(HELGNNDIDCI)), (!flag2) ? this.JNBBJCLFFBB(base.GPONHFNLHCN.EKNKJLCLLCQ()) : (this.JNBBJCLFFBB(base.GPONHFNLHCN.EKNKJLCLLCQ()) + num2 - this.JNBBJCLFFBB(HELGNNDIDCI)));
		return this.QMEMFMDBHLI(num, num2);
	}

	// Token: 0x060070A9 RID: 28841 RVA: 0x000295FA File Offset: 0x000277FA
	protected virtual void HMNFDLJGBIM()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.CQCBELCFQBK(this);
	}

	// Token: 0x060070AA RID: 28842 RVA: 0x000295FA File Offset: 0x000277FA
	protected virtual void BKGJCLMIDKC()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.CQCBELCFQBK(this);
	}

	// Token: 0x060070AB RID: 28843 RVA: 0x00028E65 File Offset: 0x00027065
	protected virtual void LKDKBNOBIPK()
	{
		base.Awake();
		base.GPONHFNLHCN.JKNBMCKEBOF(this);
	}

	// Token: 0x060070AC RID: 28844 RVA: 0x00028E65 File Offset: 0x00027065
	protected virtual void FOLBFDNJLII()
	{
		base.Awake();
		base.GPONHFNLHCN.JKNBMCKEBOF(this);
	}

	// Token: 0x060070AD RID: 28845 RVA: 0x000295FA File Offset: 0x000277FA
	protected virtual void FIMPCGCJHIC()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.CQCBELCFQBK(this);
	}

	// Token: 0x060070AE RID: 28846 RVA: 0x00028E65 File Offset: 0x00027065
	protected virtual void ICINMCLMJDJ()
	{
		base.Awake();
		base.GPONHFNLHCN.JKNBMCKEBOF(this);
	}

	// Token: 0x060070AF RID: 28847 RVA: 0x0036AA64 File Offset: 0x00368C64
	public Vector3 HHMJGDKJKDC(float GPFIDEJEMEG, Vector3 HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		float num = this.FKGNBCKJPQO(HELGNNDIDCI);
		bool flag = true;
		float num2 = this.JNBBJCLFFBB(HELGNNDIDCI);
		bool flag2 = true;
		Vector2 vector = (!this.QNMGBLIGOHI) ? new Vector2(this.FKGNBCKJPQO(base.GPONHFNLHCN.PFBFIECJEJO), this.JNBBJCLFFBB(base.GPONHFNLHCN.PFBFIECJEJO)) : new Vector2(this.FKGNBCKJPQO(base.GPONHFNLHCN.HGNEKQHNFCC), this.JNBBJCLFFBB(base.GPONHFNLHCN.HGNEKQHNFCC));
		if (this.PPOGOLNFFQQ)
		{
			float num3 = base.GPONHFNLHCN.PGKODNCDNJQ.y / 944f * this.JNEFMHEFDGG;
			if (vector.y > num2 + this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) + num3)
			{
				num2 = vector.y - (this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) + num3);
				flag2 = false;
			}
		}
		if (this.PQHKJFPDOOK)
		{
			float num4 = base.GPONHFNLHCN.FOOEEHDJBQN().y / 888f * this.QFLFLIHPHBC;
			if (vector.y < num2 + this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) - num4)
			{
				num2 = vector.y - (this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) - num4);
				flag2 = true;
			}
		}
		if (this.LJHKCOPPGDC)
		{
			float num5 = base.GPONHFNLHCN.FOOEEHDJBQN().x / 1118f * this.FOPNQEOFBHI;
			if (vector.x < num + this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) - num5)
			{
				num = vector.x - (this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) - num5);
				flag = true;
			}
		}
		if (this.HQEHBBOQNHL)
		{
			float num6 = base.GPONHFNLHCN.FOOEEHDJBQN().x / 31f * this.KHMEEMEPBJI;
			if (vector.x > num + this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) + num6)
			{
				num = vector.x - (this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) + num6);
				flag = false;
			}
		}
		base.GPONHFNLHCN.PJPMKJGIPOO(new Vector2((!flag) ? this.FKGNBCKJPQO(base.GPONHFNLHCN.EKNKJLCLLCQ()) : (this.FKGNBCKJPQO(base.GPONHFNLHCN.EQCLOIQEDLC) + num - this.FKGNBCKJPQO(HELGNNDIDCI)), (!flag2) ? this.JNBBJCLFFBB(base.GPONHFNLHCN.EQCLOIQEDLC) : (this.JNBBJCLFFBB(base.GPONHFNLHCN.EKNKJLCLLCQ()) + num2 - this.JNBBJCLFFBB(HELGNNDIDCI))));
		return this.QMEMFMDBHLI(num, num2);
	}

	// Token: 0x060070B0 RID: 28848 RVA: 0x0002960E File Offset: 0x0002780E
	public int OQEPLCBLCPN()
	{
		return this.IEDKDIJGNNO;
	}

	// Token: 0x060070B1 RID: 28849 RVA: 0x0036AD84 File Offset: 0x00368F84
	public Vector3 MKKGHGDNEOK(float GPFIDEJEMEG, Vector3 HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		float num = this.FKGNBCKJPQO(HELGNNDIDCI);
		bool flag = false;
		float num2 = this.JNBBJCLFFBB(HELGNNDIDCI);
		bool flag2 = false;
		Vector2 vector = (!this.QNMGBLIGOHI) ? new Vector2(this.FKGNBCKJPQO(base.GPONHFNLHCN.PFBFIECJEJO), this.JNBBJCLFFBB(base.GPONHFNLHCN.PFBFIECJEJO)) : new Vector2(this.FKGNBCKJPQO(base.GPONHFNLHCN.HGNEKQHNFCC), this.JNBBJCLFFBB(base.GPONHFNLHCN.HGNEKQHNFCC));
		if (this.PPOGOLNFFQQ)
		{
			float num3 = base.GPONHFNLHCN.PGKODNCDNJQ.y / 2f * this.JNEFMHEFDGG;
			if (vector.y > num2 + this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) + num3)
			{
				num2 = vector.y - (this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) + num3);
				flag2 = true;
			}
		}
		if (this.PQHKJFPDOOK)
		{
			float num4 = base.GPONHFNLHCN.PGKODNCDNJQ.y / 2f * this.QFLFLIHPHBC;
			if (vector.y < num2 + this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) - num4)
			{
				num2 = vector.y - (this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) - num4);
				flag2 = true;
			}
		}
		if (this.LJHKCOPPGDC)
		{
			float num5 = base.GPONHFNLHCN.PGKODNCDNJQ.x / 2f * this.FOPNQEOFBHI;
			if (vector.x < num + this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) - num5)
			{
				num = vector.x - (this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) - num5);
				flag = true;
			}
		}
		if (this.HQEHBBOQNHL)
		{
			float num6 = base.GPONHFNLHCN.PGKODNCDNJQ.x / 2f * this.KHMEEMEPBJI;
			if (vector.x > num + this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) + num6)
			{
				num = vector.x - (this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) + num6);
				flag = true;
			}
		}
		base.GPONHFNLHCN.EQCLOIQEDLC = new Vector2((!flag) ? this.FKGNBCKJPQO(base.GPONHFNLHCN.EQCLOIQEDLC) : (this.FKGNBCKJPQO(base.GPONHFNLHCN.EQCLOIQEDLC) + num - this.FKGNBCKJPQO(HELGNNDIDCI)), (!flag2) ? this.JNBBJCLFFBB(base.GPONHFNLHCN.EQCLOIQEDLC) : (this.JNBBJCLFFBB(base.GPONHFNLHCN.EQCLOIQEDLC) + num2 - this.JNBBJCLFFBB(HELGNNDIDCI)));
		return this.QMEMFMDBHLI(num, num2);
	}

	// Token: 0x060070B2 RID: 28850 RVA: 0x0002960E File Offset: 0x0002780E
	public int LNGBPFJCBFK()
	{
		return this.IEDKDIJGNNO;
	}

	// Token: 0x060070B3 RID: 28851 RVA: 0x000295FA File Offset: 0x000277FA
	protected virtual void DKDQKJJKEIL()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.CQCBELCFQBK(this);
	}

	// Token: 0x060070B4 RID: 28852 RVA: 0x00028E65 File Offset: 0x00027065
	protected virtual void QOLNLDBHGJL()
	{
		base.Awake();
		base.GPONHFNLHCN.JKNBMCKEBOF(this);
	}

	// Token: 0x060070B5 RID: 28853 RVA: 0x000295FA File Offset: 0x000277FA
	protected virtual void EFDMKMLENGN()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.CQCBELCFQBK(this);
	}

	// Token: 0x060070B8 RID: 28856 RVA: 0x000295FA File Offset: 0x000277FA
	protected virtual void DGODHNHPNHE()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.CQCBELCFQBK(this);
	}

	// Token: 0x060070B9 RID: 28857 RVA: 0x000295FA File Offset: 0x000277FA
	protected virtual void QIPGKGEBBNI()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.CQCBELCFQBK(this);
	}

	// Token: 0x060070BA RID: 28858 RVA: 0x000295FA File Offset: 0x000277FA
	protected virtual void FBOOPIKPEQB()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.CQCBELCFQBK(this);
	}

	// Token: 0x060070BB RID: 28859 RVA: 0x00028E65 File Offset: 0x00027065
	protected virtual void NNPPKOGDNOM()
	{
		base.Awake();
		base.GPONHFNLHCN.JKNBMCKEBOF(this);
	}

	// Token: 0x060070BC RID: 28860 RVA: 0x00028E65 File Offset: 0x00027065
	protected virtual void NKFQOJPEFKD()
	{
		base.Awake();
		base.GPONHFNLHCN.JKNBMCKEBOF(this);
	}

	// Token: 0x060070BD RID: 28861 RVA: 0x00029616 File Offset: 0x00027816
	public void CFNGNNEMMPC(int BGBMIEJJQKC)
	{
		this.IEDKDIJGNNO = BGBMIEJJQKC;
	}

	// Token: 0x060070BE RID: 28862 RVA: 0x0002960E File Offset: 0x0002780E
	public int JNMDQMLLPBI()
	{
		return this.IEDKDIJGNNO;
	}

	// Token: 0x060070BF RID: 28863 RVA: 0x0036B114 File Offset: 0x00369314
	public Vector3 ECPEBNPOMQJ(float GPFIDEJEMEG, Vector3 HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		float num = this.FKGNBCKJPQO(HELGNNDIDCI);
		bool flag = false;
		float num2 = this.JNBBJCLFFBB(HELGNNDIDCI);
		bool flag2 = false;
		Vector2 vector = (!this.QNMGBLIGOHI) ? new Vector2(this.FKGNBCKJPQO(base.GPONHFNLHCN.PFBFIECJEJO), this.JNBBJCLFFBB(base.GPONHFNLHCN.PFBFIECJEJO)) : new Vector2(this.FKGNBCKJPQO(base.GPONHFNLHCN.KEQQHBKDJHP()), this.JNBBJCLFFBB(base.GPONHFNLHCN.HGNEKQHNFCC));
		if (this.PPOGOLNFFQQ)
		{
			float num3 = base.GPONHFNLHCN.FOOEEHDJBQN().y / 1474f * this.JNEFMHEFDGG;
			if (vector.y > num2 + this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) + num3)
			{
				num2 = vector.y - (this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) + num3);
				flag2 = false;
			}
		}
		if (this.PQHKJFPDOOK)
		{
			float num4 = base.GPONHFNLHCN.FOOEEHDJBQN().y / 1743f * this.QFLFLIHPHBC;
			if (vector.y < num2 + this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) - num4)
			{
				num2 = vector.y - (this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) - num4);
				flag2 = false;
			}
		}
		if (this.LJHKCOPPGDC)
		{
			float num5 = base.GPONHFNLHCN.FOOEEHDJBQN().x / 377f * this.FOPNQEOFBHI;
			if (vector.x < num + this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) - num5)
			{
				num = vector.x - (this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) - num5);
				flag = false;
			}
		}
		if (this.HQEHBBOQNHL)
		{
			float num6 = base.GPONHFNLHCN.PGKODNCDNJQ.x / 1080f * this.KHMEEMEPBJI;
			if (vector.x > num + this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) + num6)
			{
				num = vector.x - (this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) + num6);
				flag = true;
			}
		}
		base.GPONHFNLHCN.EQCLOIQEDLC = new Vector2((!flag) ? this.FKGNBCKJPQO(base.GPONHFNLHCN.EKNKJLCLLCQ()) : (this.FKGNBCKJPQO(base.GPONHFNLHCN.EQCLOIQEDLC) + num - this.FKGNBCKJPQO(HELGNNDIDCI)), (!flag2) ? this.JNBBJCLFFBB(base.GPONHFNLHCN.EQCLOIQEDLC) : (this.JNBBJCLFFBB(base.GPONHFNLHCN.EKNKJLCLLCQ()) + num2 - this.JNBBJCLFFBB(HELGNNDIDCI)));
		return this.QMEMFMDBHLI(num, num2);
	}

	// Token: 0x060070C0 RID: 28864 RVA: 0x0036B434 File Offset: 0x00369634
	public Vector3 EIMNCGQGEKD(float GPFIDEJEMEG, Vector3 HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		float num = this.FKGNBCKJPQO(HELGNNDIDCI);
		bool flag = false;
		float num2 = this.JNBBJCLFFBB(HELGNNDIDCI);
		bool flag2 = false;
		Vector2 vector = (!this.QNMGBLIGOHI) ? new Vector2(this.FKGNBCKJPQO(base.GPONHFNLHCN.PFBFIECJEJO), this.JNBBJCLFFBB(base.GPONHFNLHCN.PFBFIECJEJO)) : new Vector2(this.FKGNBCKJPQO(base.GPONHFNLHCN.KEQQHBKDJHP()), this.JNBBJCLFFBB(base.GPONHFNLHCN.HGNEKQHNFCC));
		if (this.PPOGOLNFFQQ)
		{
			float num3 = base.GPONHFNLHCN.PGKODNCDNJQ.y / 595f * this.JNEFMHEFDGG;
			if (vector.y > num2 + this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) + num3)
			{
				num2 = vector.y - (this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) + num3);
				flag2 = true;
			}
		}
		if (this.PQHKJFPDOOK)
		{
			float num4 = base.GPONHFNLHCN.PGKODNCDNJQ.y / 954f * this.QFLFLIHPHBC;
			if (vector.y < num2 + this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) - num4)
			{
				num2 = vector.y - (this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) - num4);
				flag2 = false;
			}
		}
		if (this.LJHKCOPPGDC)
		{
			float num5 = base.GPONHFNLHCN.PGKODNCDNJQ.x / 704f * this.FOPNQEOFBHI;
			if (vector.x < num + this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) - num5)
			{
				num = vector.x - (this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) - num5);
				flag = true;
			}
		}
		if (this.HQEHBBOQNHL)
		{
			float num6 = base.GPONHFNLHCN.PGKODNCDNJQ.x / 617f * this.KHMEEMEPBJI;
			if (vector.x > num + this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) + num6)
			{
				num = vector.x - (this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) + num6);
				flag = false;
			}
		}
		base.GPONHFNLHCN.PJPMKJGIPOO(new Vector2((!flag) ? this.FKGNBCKJPQO(base.GPONHFNLHCN.EKNKJLCLLCQ()) : (this.FKGNBCKJPQO(base.GPONHFNLHCN.EQCLOIQEDLC) + num - this.FKGNBCKJPQO(HELGNNDIDCI)), (!flag2) ? this.JNBBJCLFFBB(base.GPONHFNLHCN.EQCLOIQEDLC) : (this.JNBBJCLFFBB(base.GPONHFNLHCN.EQCLOIQEDLC) + num2 - this.JNBBJCLFFBB(HELGNNDIDCI))));
		return this.QMEMFMDBHLI(num, num2);
	}

	// Token: 0x060070C1 RID: 28865 RVA: 0x0036B754 File Offset: 0x00369954
	public Vector3 IOOEJHQOCOK(float GPFIDEJEMEG, Vector3 HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		float num = this.FKGNBCKJPQO(HELGNNDIDCI);
		bool flag = true;
		float num2 = this.JNBBJCLFFBB(HELGNNDIDCI);
		bool flag2 = false;
		Vector2 vector = (!this.QNMGBLIGOHI) ? new Vector2(this.FKGNBCKJPQO(base.GPONHFNLHCN.PFBFIECJEJO), this.JNBBJCLFFBB(base.GPONHFNLHCN.PFBFIECJEJO)) : new Vector2(this.FKGNBCKJPQO(base.GPONHFNLHCN.KEQQHBKDJHP()), this.JNBBJCLFFBB(base.GPONHFNLHCN.KEQQHBKDJHP()));
		if (this.PPOGOLNFFQQ)
		{
			float num3 = base.GPONHFNLHCN.FOOEEHDJBQN().y / 685f * this.JNEFMHEFDGG;
			if (vector.y > num2 + this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) + num3)
			{
				num2 = vector.y - (this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) + num3);
				flag2 = false;
			}
		}
		if (this.PQHKJFPDOOK)
		{
			float num4 = base.GPONHFNLHCN.PGKODNCDNJQ.y / 645f * this.QFLFLIHPHBC;
			if (vector.y < num2 + this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) - num4)
			{
				num2 = vector.y - (this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) - num4);
				flag2 = false;
			}
		}
		if (this.LJHKCOPPGDC)
		{
			float num5 = base.GPONHFNLHCN.FOOEEHDJBQN().x / 125f * this.FOPNQEOFBHI;
			if (vector.x < num + this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) - num5)
			{
				num = vector.x - (this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) - num5);
				flag = false;
			}
		}
		if (this.HQEHBBOQNHL)
		{
			float num6 = base.GPONHFNLHCN.FOOEEHDJBQN().x / 388f * this.KHMEEMEPBJI;
			if (vector.x > num + this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) + num6)
			{
				num = vector.x - (this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) + num6);
				flag = true;
			}
		}
		base.GPONHFNLHCN.PJPMKJGIPOO(new Vector2((!flag) ? this.FKGNBCKJPQO(base.GPONHFNLHCN.EKNKJLCLLCQ()) : (this.FKGNBCKJPQO(base.GPONHFNLHCN.EKNKJLCLLCQ()) + num - this.FKGNBCKJPQO(HELGNNDIDCI)), (!flag2) ? this.JNBBJCLFFBB(base.GPONHFNLHCN.EKNKJLCLLCQ()) : (this.JNBBJCLFFBB(base.GPONHFNLHCN.EKNKJLCLLCQ()) + num2 - this.JNBBJCLFFBB(HELGNNDIDCI))));
		return this.QMEMFMDBHLI(num, num2);
	}

	// Token: 0x060070C2 RID: 28866 RVA: 0x000295FA File Offset: 0x000277FA
	protected virtual void IOLLJNQCJIK()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.CQCBELCFQBK(this);
	}

	// Token: 0x060070C3 RID: 28867 RVA: 0x0036BA74 File Offset: 0x00369C74
	public Vector3 KELHMHMOFJB(float GPFIDEJEMEG, Vector3 HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		float num = this.FKGNBCKJPQO(HELGNNDIDCI);
		bool flag = true;
		float num2 = this.JNBBJCLFFBB(HELGNNDIDCI);
		bool flag2 = false;
		Vector2 vector = (!this.QNMGBLIGOHI) ? new Vector2(this.FKGNBCKJPQO(base.GPONHFNLHCN.PFBFIECJEJO), this.JNBBJCLFFBB(base.GPONHFNLHCN.PFBFIECJEJO)) : new Vector2(this.FKGNBCKJPQO(base.GPONHFNLHCN.HGNEKQHNFCC), this.JNBBJCLFFBB(base.GPONHFNLHCN.HGNEKQHNFCC));
		if (this.PPOGOLNFFQQ)
		{
			float num3 = base.GPONHFNLHCN.FOOEEHDJBQN().y / 636f * this.JNEFMHEFDGG;
			if (vector.y > num2 + this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) + num3)
			{
				num2 = vector.y - (this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) + num3);
				flag2 = true;
			}
		}
		if (this.PQHKJFPDOOK)
		{
			float num4 = base.GPONHFNLHCN.FOOEEHDJBQN().y / 1207f * this.QFLFLIHPHBC;
			if (vector.y < num2 + this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) - num4)
			{
				num2 = vector.y - (this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) - num4);
				flag2 = true;
			}
		}
		if (this.LJHKCOPPGDC)
		{
			float num5 = base.GPONHFNLHCN.FOOEEHDJBQN().x / 21f * this.FOPNQEOFBHI;
			if (vector.x < num + this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) - num5)
			{
				num = vector.x - (this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) - num5);
				flag = true;
			}
		}
		if (this.HQEHBBOQNHL)
		{
			float num6 = base.GPONHFNLHCN.PGKODNCDNJQ.x / 1957f * this.KHMEEMEPBJI;
			if (vector.x > num + this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) + num6)
			{
				num = vector.x - (this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) + num6);
				flag = false;
			}
		}
		base.GPONHFNLHCN.EQCLOIQEDLC = new Vector2((!flag) ? this.FKGNBCKJPQO(base.GPONHFNLHCN.EQCLOIQEDLC) : (this.FKGNBCKJPQO(base.GPONHFNLHCN.EKNKJLCLLCQ()) + num - this.FKGNBCKJPQO(HELGNNDIDCI)), (!flag2) ? this.JNBBJCLFFBB(base.GPONHFNLHCN.EKNKJLCLLCQ()) : (this.JNBBJCLFFBB(base.GPONHFNLHCN.EKNKJLCLLCQ()) + num2 - this.JNBBJCLFFBB(HELGNNDIDCI)));
		return this.QMEMFMDBHLI(num, num2);
	}

	// Token: 0x060070C4 RID: 28868 RVA: 0x00028E65 File Offset: 0x00027065
	protected virtual void CHKQIFFEEPL()
	{
		base.Awake();
		base.GPONHFNLHCN.JKNBMCKEBOF(this);
	}

	// Token: 0x060070C6 RID: 28870 RVA: 0x00028E65 File Offset: 0x00027065
	protected virtual void BMIIKIKIKIK()
	{
		base.Awake();
		base.GPONHFNLHCN.JKNBMCKEBOF(this);
	}

	// Token: 0x060070C7 RID: 28871 RVA: 0x00029616 File Offset: 0x00027816
	public void HLJGPGIGCIH(int BGBMIEJJQKC)
	{
		this.IEDKDIJGNNO = BGBMIEJJQKC;
	}

	// Token: 0x060070C8 RID: 28872 RVA: 0x000295FA File Offset: 0x000277FA
	protected virtual void BHJIKJLLIQQ()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.CQCBELCFQBK(this);
	}

	// Token: 0x040017FC RID: 6140
	public static string OPGNGFNJDDP = "Limit Distance";

	// Token: 0x040017FD RID: 6141
	public bool QNMGBLIGOHI = true;

	// Token: 0x040017FE RID: 6142
	public bool PPOGOLNFFQQ = true;

	// Token: 0x040017FF RID: 6143
	[Range(0.1f, 1f)]
	public float JNEFMHEFDGG = 0.8f;

	// Token: 0x04001800 RID: 6144
	public bool PQHKJFPDOOK = true;

	// Token: 0x04001801 RID: 6145
	[Range(0.1f, 1f)]
	public float QFLFLIHPHBC = 0.8f;

	// Token: 0x04001802 RID: 6146
	public bool LJHKCOPPGDC = true;

	// Token: 0x04001803 RID: 6147
	[Range(0.1f, 1f)]
	public float FOPNQEOFBHI = 0.8f;

	// Token: 0x04001804 RID: 6148
	public bool HQEHBBOQNHL = true;

	// Token: 0x04001805 RID: 6149
	[Range(0.1f, 1f)]
	public float KHMEEMEPBJI = 0.8f;

	// Token: 0x04001806 RID: 6150
	private int IEDKDIJGNNO = 2000;
}
