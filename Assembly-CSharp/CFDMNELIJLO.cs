using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000048 RID: 72
[AddComponentMenu("NGUI/Interaction/Button")]
public class CFDMNELIJLO : PBJKDKBOLHO
{
	// Token: 0x06000A00 RID: 2560 RVA: 0x000635A0 File Offset: 0x000617A0
	protected void KFGNNLMHFHB(string QNLEJECLMHB)
	{
		if (this.LNMJLFLDCML != null && !string.IsNullOrEmpty(QNLEJECLMHB) && this.LNMJLFLDCML.MHQDJEHIOOL() != QNLEJECLMHB)
		{
			this.LNMJLFLDCML.KCLBMPFIPNQ = QNLEJECLMHB;
			if (this.HQDQHHHMLEJ)
			{
				this.LNMJLFLDCML.IQFQEOFBQKM();
			}
		}
	}

	// Token: 0x06000A01 RID: 2561 RVA: 0x000635F8 File Offset: 0x000617F8
	public override void NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD HHJEFGFNBPG, bool OGFDJFCDCLJ)
	{
		base.NHCNOIOCFCO(HHJEFGFNBPG, OGFDJFCDCLJ);
		if (this.LNMJLFLDCML != null)
		{
			switch (HHJEFGFNBPG)
			{
			case PBJKDKBOLHO.OKKDIIQGHDD.Normal:
				this.CENHKCHMBEE(this.BQMOPOOHFNG);
				break;
			case PBJKDKBOLHO.OKKDIIQGHDD.Hover:
				this.CENHKCHMBEE((!string.IsNullOrEmpty(this.OGEJCFNKILL)) ? this.OGEJCFNKILL : this.BQMOPOOHFNG);
				break;
			case PBJKDKBOLHO.OKKDIIQGHDD.Pressed:
				this.CENHKCHMBEE(this.MQGOHKQLLKH);
				break;
			case PBJKDKBOLHO.OKKDIIQGHDD.Disabled:
				this.CENHKCHMBEE(this.OILFJBNPDMH);
				break;
			}
		}
		else if (this.MDKFELNLBJH != null)
		{
			switch (HHJEFGFNBPG)
			{
			case PBJKDKBOLHO.OKKDIIQGHDD.Normal:
				this.CENHKCHMBEE(this.GIBBLJKEEOL);
				break;
			case PBJKDKBOLHO.OKKDIIQGHDD.Hover:
				this.CENHKCHMBEE((!(this.BFMHLPQCIIP == null)) ? this.BFMHLPQCIIP : this.GIBBLJKEEOL);
				break;
			case PBJKDKBOLHO.OKKDIIQGHDD.Pressed:
				this.CENHKCHMBEE(this.FPOPQHGKLKN);
				break;
			case PBJKDKBOLHO.OKKDIIQGHDD.Disabled:
				this.CENHKCHMBEE(this.LBONNEQGFDQ);
				break;
			}
		}
	}

	// Token: 0x06000A02 RID: 2562 RVA: 0x000057AC File Offset: 0x000039AC
	protected override void JHNIPQLONMK()
	{
		if (this.GGBPLMICFHN && (this.IOOMNBFQHHC || EMENMKHBPQE.JHEDGGMDIEE.KCICOJFDCPQ == base.gameObject))
		{
			base.JHNIPQLONMK();
		}
	}

	// Token: 0x17000021 RID: 33
	// (get) Token: 0x06000A23 RID: 2595 RVA: 0x000059CE File Offset: 0x00003BCE
	// (set) Token: 0x06000A03 RID: 2563 RVA: 0x00063700 File Offset: 0x00061900
	public Sprite OOLEDICQFGD
	{
		get
		{
			if (!this.KBNGENPQQFE)
			{
				this.FHJOQKCCMDH();
			}
			return this.GIBBLJKEEOL;
		}
		set
		{
			if (!this.KBNGENPQQFE)
			{
				this.FHJOQKCCMDH();
			}
			if (this.MDKFELNLBJH != null && this.GIBBLJKEEOL == this.MDKFELNLBJH.OILJNPIELOB)
			{
				this.GIBBLJKEEOL = value;
				this.CENHKCHMBEE(value);
				IKBQNBHOJJB.OCPCPKCLCOI(this.LNMJLFLDCML);
			}
			else
			{
				this.GIBBLJKEEOL = value;
				if (this.NDPCGHQDHMO == PBJKDKBOLHO.OKKDIIQGHDD.Normal)
				{
					this.CENHKCHMBEE(value);
				}
			}
		}
	}

	// Token: 0x06000A04 RID: 2564 RVA: 0x00063774 File Offset: 0x00061974
	public virtual void DJCIPEDOJFH(bool BGBMIEJJQKC)
	{
		if (this.EFBQLPLOMQB() != BGBMIEJJQKC)
		{
			Collider component = base.gameObject.GetComponent<Collider>();
			if (component != null)
			{
				component.enabled = BGBMIEJJQKC;
				CFDMNELIJLO[] components = base.GetComponents<CFDMNELIJLO>();
				CFDMNELIJLO[] array = components;
				for (int i = 1; i < array.Length; i++)
				{
					CFDMNELIJLO cfdmnelijlo = array[i];
					cfdmnelijlo.NHCNOIOCFCO((!BGBMIEJJQKC) ? PBJKDKBOLHO.OKKDIIQGHDD.Hover : PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
				}
			}
			else
			{
				Collider2D component2 = base.GetComponent<Collider2D>();
				if (component2 != null)
				{
					component2.enabled = BGBMIEJJQKC;
					CFDMNELIJLO[] components2 = base.GetComponents<CFDMNELIJLO>();
					CFDMNELIJLO[] array2 = components2;
					for (int j = 1; j < array2.Length; j++)
					{
						CFDMNELIJLO cfdmnelijlo2 = array2[j];
						cfdmnelijlo2.NHCNOIOCFCO((!BGBMIEJJQKC) ? PBJKDKBOLHO.OKKDIIQGHDD.Pressed : PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
					}
				}
				else
				{
					base.enabled = BGBMIEJJQKC;
				}
			}
		}
	}

	// Token: 0x06000A05 RID: 2565 RVA: 0x000057DB File Offset: 0x000039DB
	protected virtual void QCJEOFLKKLF()
	{
		if (this.EFBQLPLOMQB())
		{
			if (this.KBNGENPQQFE)
			{
				this.LJMOLEKDCLP(EMENMKHBPQE.QMPQFJMFQPB == base.gameObject);
			}
		}
		else
		{
			this.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
		}
	}

	// Token: 0x17000020 RID: 32
	// (get) Token: 0x06000A14 RID: 2580 RVA: 0x000058BF File Offset: 0x00003ABF
	// (set) Token: 0x06000A06 RID: 2566 RVA: 0x00063834 File Offset: 0x00061A34
	public string MNIPPKQLKNL
	{
		get
		{
			if (!this.KBNGENPQQFE)
			{
				this.FHJOQKCCMDH();
			}
			return this.BQMOPOOHFNG;
		}
		set
		{
			if (!this.KBNGENPQQFE)
			{
				this.FHJOQKCCMDH();
			}
			if (this.LNMJLFLDCML != null && !string.IsNullOrEmpty(this.BQMOPOOHFNG) && this.BQMOPOOHFNG == this.LNMJLFLDCML.KCLBMPFIPNQ)
			{
				this.BQMOPOOHFNG = value;
				this.CENHKCHMBEE(value);
				IKBQNBHOJJB.OCPCPKCLCOI(this.LNMJLFLDCML);
			}
			else
			{
				this.BQMOPOOHFNG = value;
				if (this.NDPCGHQDHMO == PBJKDKBOLHO.OKKDIIQGHDD.Normal)
				{
					this.CENHKCHMBEE(value);
				}
			}
		}
	}

	// Token: 0x06000A07 RID: 2567 RVA: 0x0000580D File Offset: 0x00003A0D
	protected override void OnEnable()
	{
		if (this.GGBPLMICFHN)
		{
			if (this.KBNGENPQQFE)
			{
				this.LJMOLEKDCLP(EMENMKHBPQE.QMPQFJMFQPB == base.gameObject);
			}
		}
		else
		{
			this.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
		}
	}

	// Token: 0x06000A08 RID: 2568 RVA: 0x000638B4 File Offset: 0x00061AB4
	protected override void FHJOQKCCMDH()
	{
		base.FHJOQKCCMDH();
		this.LNMJLFLDCML = (this.DLQMOLJPEMO as PLQFPBQEPJD);
		this.MDKFELNLBJH = (this.DLQMOLJPEMO as ILJNMOPNGQD);
		if (this.LNMJLFLDCML != null)
		{
			this.BQMOPOOHFNG = this.LNMJLFLDCML.KCLBMPFIPNQ;
		}
		if (this.MDKFELNLBJH != null)
		{
			this.GIBBLJKEEOL = this.MDKFELNLBJH.OILJNPIELOB;
		}
	}

	// Token: 0x06000A09 RID: 2569 RVA: 0x00063928 File Offset: 0x00061B28
	public virtual bool FILHPQNIPPG()
	{
		if (!base.enabled)
		{
			return true;
		}
		Collider component = base.gameObject.GetComponent<Collider>();
		if (component && component.enabled)
		{
			return false;
		}
		Collider2D component2 = base.GetComponent<Collider2D>();
		return component2 && component2.enabled;
	}

	// Token: 0x06000A0A RID: 2570 RVA: 0x00063978 File Offset: 0x00061B78
	public void MLMGOOCJONC(Sprite BGBMIEJJQKC)
	{
		if (!this.KBNGENPQQFE)
		{
			this.FHJOQKCCMDH();
		}
		if (this.MDKFELNLBJH != null && this.GIBBLJKEEOL == this.MDKFELNLBJH.DOPPQFNFCIF())
		{
			this.GIBBLJKEEOL = BGBMIEJJQKC;
			this.CENHKCHMBEE(BGBMIEJJQKC);
			IKBQNBHOJJB.OCPCPKCLCOI(this.LNMJLFLDCML);
		}
		else
		{
			this.GIBBLJKEEOL = BGBMIEJJQKC;
			if (this.NDPCGHQDHMO == PBJKDKBOLHO.OKKDIIQGHDD.Normal)
			{
				this.CENHKCHMBEE(BGBMIEJJQKC);
			}
		}
	}

	// Token: 0x06000A0B RID: 2571 RVA: 0x000639EC File Offset: 0x00061BEC
	protected void CENHKCHMBEE(Sprite QNLEJECLMHB)
	{
		if (QNLEJECLMHB != null && this.MDKFELNLBJH != null && this.MDKFELNLBJH.OILJNPIELOB != QNLEJECLMHB)
		{
			this.MDKFELNLBJH.OILJNPIELOB = QNLEJECLMHB;
			if (this.HQDQHHHMLEJ)
			{
				this.MDKFELNLBJH.IQFQEOFBQKM();
			}
		}
	}

	// Token: 0x06000A0C RID: 2572 RVA: 0x00063A44 File Offset: 0x00061C44
	protected virtual void JMPBQBEFOCM()
	{
		base.MLENNDFLBFC();
		this.LNMJLFLDCML = (this.DLQMOLJPEMO as PLQFPBQEPJD);
		this.MDKFELNLBJH = (this.DLQMOLJPEMO as ILJNMOPNGQD);
		if (this.LNMJLFLDCML != null)
		{
			this.BQMOPOOHFNG = this.LNMJLFLDCML.GQKEMOHHIMK();
		}
		if (this.MDKFELNLBJH != null)
		{
			this.GIBBLJKEEOL = this.MDKFELNLBJH.OILJNPIELOB;
		}
	}

	// Token: 0x06000A0D RID: 2573 RVA: 0x0000583F File Offset: 0x00003A3F
	protected virtual void OnClick()
	{
		if (CFDMNELIJLO.OMQCQCBLQGJ == null && this.GGBPLMICFHN && EMENMKHBPQE.JQCODFPLPNJ != -2 && EMENMKHBPQE.JQCODFPLPNJ != -3)
		{
			CFDMNELIJLO.OMQCQCBLQGJ = this;
			EventDelegate.CPGBBDIDOID(this.QQGILCDILNM);
			CFDMNELIJLO.OMQCQCBLQGJ = null;
		}
	}

	// Token: 0x06000A0E RID: 2574 RVA: 0x0000587F File Offset: 0x00003A7F
	protected virtual void HKLIDELHEJB()
	{
		if (CFDMNELIJLO.OMQCQCBLQGJ == null && this.IQKKIGIKGDN() && EMENMKHBPQE.JQCODFPLPNJ != 117 && EMENMKHBPQE.JQCODFPLPNJ != 101)
		{
			CFDMNELIJLO.OMQCQCBLQGJ = this;
			EventDelegate.QGFODQOJBOE(this.QQGILCDILNM);
			CFDMNELIJLO.OMQCQCBLQGJ = null;
		}
	}

	// Token: 0x06000A0F RID: 2575 RVA: 0x00063AB8 File Offset: 0x00061CB8
	public void FKGJKJFFBFQ()
	{
		if (!base.enabled)
		{
			return;
		}
		Collider component = base.gameObject.GetComponent<Collider>();
		if (component != null)
		{
			component.enabled = true;
			CFDMNELIJLO[] components = base.GetComponents<CFDMNELIJLO>();
			CFDMNELIJLO[] array = components;
			for (int i = 1; i < array.Length; i++)
			{
				CFDMNELIJLO cfdmnelijlo = array[i];
				cfdmnelijlo.NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)8, true);
			}
		}
	}

	// Token: 0x1700001F RID: 31
	// (get) Token: 0x06000A10 RID: 2576 RVA: 0x00063B14 File Offset: 0x00061D14
	// (set) Token: 0x06000A1F RID: 2591 RVA: 0x00063FC8 File Offset: 0x000621C8
	public override bool GGBPLMICFHN
	{
		get
		{
			if (!base.enabled)
			{
				return false;
			}
			Collider component = base.gameObject.GetComponent<Collider>();
			if (component && component.enabled)
			{
				return true;
			}
			Collider2D component2 = base.GetComponent<Collider2D>();
			return component2 && component2.enabled;
		}
		set
		{
			if (this.GGBPLMICFHN != value)
			{
				Collider component = base.gameObject.GetComponent<Collider>();
				if (component != null)
				{
					component.enabled = value;
					CFDMNELIJLO[] components = base.GetComponents<CFDMNELIJLO>();
					foreach (CFDMNELIJLO cfdmnelijlo in components)
					{
						cfdmnelijlo.NHCNOIOCFCO((!value) ? PBJKDKBOLHO.OKKDIIQGHDD.Disabled : PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
					}
				}
				else
				{
					Collider2D component2 = base.GetComponent<Collider2D>();
					if (component2 != null)
					{
						component2.enabled = value;
						CFDMNELIJLO[] components2 = base.GetComponents<CFDMNELIJLO>();
						foreach (CFDMNELIJLO cfdmnelijlo2 in components2)
						{
							cfdmnelijlo2.NHCNOIOCFCO((!value) ? PBJKDKBOLHO.OKKDIIQGHDD.Disabled : PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
						}
					}
					else
					{
						base.enabled = value;
					}
				}
			}
		}
	}

	// Token: 0x06000A11 RID: 2577 RVA: 0x00063B64 File Offset: 0x00061D64
	public void GJBCDOKDQQF(string BGBMIEJJQKC)
	{
		if (!this.KBNGENPQQFE)
		{
			this.MLENNDFLBFC();
		}
		if (this.LNMJLFLDCML != null && !string.IsNullOrEmpty(this.BQMOPOOHFNG) && this.BQMOPOOHFNG == this.LNMJLFLDCML.HQDQLOQPCOD())
		{
			this.BQMOPOOHFNG = BGBMIEJJQKC;
			this.LGIHHDENNLG(BGBMIEJJQKC);
			IKBQNBHOJJB.OCPCPKCLCOI(this.LNMJLFLDCML);
		}
		else
		{
			this.BQMOPOOHFNG = BGBMIEJJQKC;
			if (this.NDPCGHQDHMO == PBJKDKBOLHO.OKKDIIQGHDD.Normal)
			{
				this.CENHKCHMBEE(BGBMIEJJQKC);
			}
		}
	}

	// Token: 0x06000A12 RID: 2578 RVA: 0x00063BE4 File Offset: 0x00061DE4
	public void GDCCCNPLPQK(string BGBMIEJJQKC)
	{
		if (!this.KBNGENPQQFE)
		{
			this.MLENNDFLBFC();
		}
		if (this.LNMJLFLDCML != null && !string.IsNullOrEmpty(this.BQMOPOOHFNG) && this.BQMOPOOHFNG == this.LNMJLFLDCML.GDNKLMDBLEO())
		{
			this.BQMOPOOHFNG = BGBMIEJJQKC;
			this.CENHKCHMBEE(BGBMIEJJQKC);
			IKBQNBHOJJB.OCPCPKCLCOI(this.LNMJLFLDCML);
		}
		else
		{
			this.BQMOPOOHFNG = BGBMIEJJQKC;
			if (this.NDPCGHQDHMO == PBJKDKBOLHO.OKKDIIQGHDD.Normal)
			{
				this.KFGNNLMHFHB(BGBMIEJJQKC);
			}
		}
	}

	// Token: 0x06000A13 RID: 2579 RVA: 0x00063C64 File Offset: 0x00061E64
	public virtual bool DLDHBPGJBLG()
	{
		if (!base.enabled)
		{
			return true;
		}
		Collider component = base.gameObject.GetComponent<Collider>();
		if (component && component.enabled)
		{
			return false;
		}
		Collider2D component2 = base.GetComponent<Collider2D>();
		return !component2 || component2.enabled;
	}

	// Token: 0x06000A15 RID: 2581 RVA: 0x000058D5 File Offset: 0x00003AD5
	protected virtual void EDQOMJLPCJN()
	{
		if (this.GGBPLMICFHN && (this.IOOMNBFQHHC || EMENMKHBPQE.JHEDGGMDIEE.KCICOJFDCPQ == base.gameObject))
		{
			base.PHEQFQKIQDQ();
		}
	}

	// Token: 0x06000A16 RID: 2582 RVA: 0x00063CB4 File Offset: 0x00061EB4
	protected virtual void HNJIOHFNKIN()
	{
		base.FHJOQKCCMDH();
		this.LNMJLFLDCML = (this.DLQMOLJPEMO as PLQFPBQEPJD);
		this.MDKFELNLBJH = (this.DLQMOLJPEMO as ILJNMOPNGQD);
		if (this.LNMJLFLDCML != null)
		{
			this.BQMOPOOHFNG = this.LNMJLFLDCML.MHQDJEHIOOL();
		}
		if (this.MDKFELNLBJH != null)
		{
			this.GIBBLJKEEOL = this.MDKFELNLBJH.DOPPQFNFCIF();
		}
	}

	// Token: 0x06000A17 RID: 2583 RVA: 0x00063D28 File Offset: 0x00061F28
	protected virtual void LKNNQKDDKJP()
	{
		base.MLENNDFLBFC();
		this.LNMJLFLDCML = (this.DLQMOLJPEMO as PLQFPBQEPJD);
		this.MDKFELNLBJH = (this.DLQMOLJPEMO as ILJNMOPNGQD);
		if (this.LNMJLFLDCML != null)
		{
			this.BQMOPOOHFNG = this.LNMJLFLDCML.GDNKLMDBLEO();
		}
		if (this.MDKFELNLBJH != null)
		{
			this.GIBBLJKEEOL = this.MDKFELNLBJH.DOPPQFNFCIF();
		}
	}

	// Token: 0x06000A18 RID: 2584 RVA: 0x00005904 File Offset: 0x00003B04
	protected virtual void GGMINIPOKJI()
	{
		if (CFDMNELIJLO.OMQCQCBLQGJ == null && this.EFBQLPLOMQB() && EMENMKHBPQE.JQCODFPLPNJ != -34 && EMENMKHBPQE.JQCODFPLPNJ != 70)
		{
			CFDMNELIJLO.OMQCQCBLQGJ = this;
			EventDelegate.QGFODQOJBOE(this.QQGILCDILNM);
			CFDMNELIJLO.OMQCQCBLQGJ = null;
		}
	}

	// Token: 0x06000A19 RID: 2585 RVA: 0x00063D9C File Offset: 0x00061F9C
	protected void LGIHHDENNLG(string QNLEJECLMHB)
	{
		if (this.LNMJLFLDCML != null && !string.IsNullOrEmpty(QNLEJECLMHB) && this.LNMJLFLDCML.GQKEMOHHIMK() != QNLEJECLMHB)
		{
			this.LNMJLFLDCML.IQBBDKFDGGP(QNLEJECLMHB);
			if (this.HQDQHHHMLEJ)
			{
				this.LNMJLFLDCML.IQFQEOFBQKM();
			}
		}
	}

	// Token: 0x06000A1A RID: 2586 RVA: 0x00063DF4 File Offset: 0x00061FF4
	public virtual void GKLQOECPKMC(PBJKDKBOLHO.OKKDIIQGHDD HHJEFGFNBPG, bool OGFDJFCDCLJ)
	{
		base.NHCNOIOCFCO(HHJEFGFNBPG, OGFDJFCDCLJ);
		if (this.LNMJLFLDCML != null)
		{
			switch (HHJEFGFNBPG)
			{
			case PBJKDKBOLHO.OKKDIIQGHDD.Normal:
				this.LGIHHDENNLG(this.BQMOPOOHFNG);
				break;
			case PBJKDKBOLHO.OKKDIIQGHDD.Hover:
				this.LGIHHDENNLG((!string.IsNullOrEmpty(this.OGEJCFNKILL)) ? this.OGEJCFNKILL : this.BQMOPOOHFNG);
				break;
			case PBJKDKBOLHO.OKKDIIQGHDD.Pressed:
				this.LGIHHDENNLG(this.MQGOHKQLLKH);
				break;
			case PBJKDKBOLHO.OKKDIIQGHDD.Disabled:
				this.LGIHHDENNLG(this.OILFJBNPDMH);
				break;
			}
		}
		else if (this.MDKFELNLBJH != null)
		{
			switch (HHJEFGFNBPG)
			{
			case PBJKDKBOLHO.OKKDIIQGHDD.Normal:
				this.CENHKCHMBEE(this.GIBBLJKEEOL);
				break;
			case PBJKDKBOLHO.OKKDIIQGHDD.Hover:
				this.CENHKCHMBEE((!(this.BFMHLPQCIIP == null)) ? this.BFMHLPQCIIP : this.GIBBLJKEEOL);
				break;
			case PBJKDKBOLHO.OKKDIIQGHDD.Pressed:
				this.CENHKCHMBEE(this.FPOPQHGKLKN);
				break;
			case PBJKDKBOLHO.OKKDIIQGHDD.Disabled:
				this.CENHKCHMBEE(this.LBONNEQGFDQ);
				break;
			}
		}
	}

	// Token: 0x06000A1B RID: 2587 RVA: 0x00063EFC File Offset: 0x000620FC
	protected void CENHKCHMBEE(string QNLEJECLMHB)
	{
		if (this.LNMJLFLDCML != null && !string.IsNullOrEmpty(QNLEJECLMHB) && this.LNMJLFLDCML.KCLBMPFIPNQ != QNLEJECLMHB)
		{
			this.LNMJLFLDCML.KCLBMPFIPNQ = QNLEJECLMHB;
			if (this.HQDQHHHMLEJ)
			{
				this.LNMJLFLDCML.IQFQEOFBQKM();
			}
		}
	}

	// Token: 0x06000A1C RID: 2588 RVA: 0x00063F54 File Offset: 0x00062154
	protected virtual void FFHCPMPEDMG()
	{
		base.FHJOQKCCMDH();
		this.LNMJLFLDCML = (this.DLQMOLJPEMO as PLQFPBQEPJD);
		this.MDKFELNLBJH = (this.DLQMOLJPEMO as ILJNMOPNGQD);
		if (this.LNMJLFLDCML != null)
		{
			this.BQMOPOOHFNG = this.LNMJLFLDCML.GDNKLMDBLEO();
		}
		if (this.MDKFELNLBJH != null)
		{
			this.GIBBLJKEEOL = this.MDKFELNLBJH.OILJNPIELOB;
		}
	}

	// Token: 0x06000A1D RID: 2589 RVA: 0x00005944 File Offset: 0x00003B44
	protected virtual void HNPKPINGJID()
	{
		if (this.EFBQLPLOMQB())
		{
			if (this.KBNGENPQQFE)
			{
				this.BIINILQKOQM(EMENMKHBPQE.QMPQFJMFQPB == base.gameObject);
			}
		}
		else
		{
			this.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
		}
	}

	// Token: 0x06000A1E RID: 2590 RVA: 0x00005976 File Offset: 0x00003B76
	public string CQBNFFMBJOF()
	{
		if (!this.KBNGENPQQFE)
		{
			this.MLENNDFLBFC();
		}
		return this.BQMOPOOHFNG;
	}

	// Token: 0x06000A20 RID: 2592 RVA: 0x0000598C File Offset: 0x00003B8C
	protected override void NMGDOKQLMEG()
	{
		if (this.GGBPLMICFHN && (this.IOOMNBFQHHC || EMENMKHBPQE.JHEDGGMDIEE.KCICOJFDCPQ == base.gameObject))
		{
			base.NMGDOKQLMEG();
		}
	}

	// Token: 0x06000A22 RID: 2594 RVA: 0x00064088 File Offset: 0x00062288
	public void JNDDMKHOEJI()
	{
		if (!base.enabled)
		{
			return;
		}
		Collider component = base.gameObject.GetComponent<Collider>();
		if (component != null)
		{
			component.enabled = false;
			CFDMNELIJLO[] components = base.GetComponents<CFDMNELIJLO>();
			foreach (CFDMNELIJLO cfdmnelijlo in components)
			{
				cfdmnelijlo.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
			}
		}
	}

	// Token: 0x06000A24 RID: 2596 RVA: 0x000058D5 File Offset: 0x00003AD5
	protected override void PHEQFQKIQDQ()
	{
		if (this.GGBPLMICFHN && (this.IOOMNBFQHHC || EMENMKHBPQE.JHEDGGMDIEE.KCICOJFDCPQ == base.gameObject))
		{
			base.PHEQFQKIQDQ();
		}
	}

	// Token: 0x0400015A RID: 346
	public static CFDMNELIJLO OMQCQCBLQGJ;

	// Token: 0x0400015B RID: 347
	public bool IOOMNBFQHHC;

	// Token: 0x0400015C RID: 348
	public string OGEJCFNKILL;

	// Token: 0x0400015D RID: 349
	public string MQGOHKQLLKH;

	// Token: 0x0400015E RID: 350
	public string OILFJBNPDMH;

	// Token: 0x0400015F RID: 351
	public Sprite BFMHLPQCIIP;

	// Token: 0x04000160 RID: 352
	public Sprite FPOPQHGKLKN;

	// Token: 0x04000161 RID: 353
	public Sprite LBONNEQGFDQ;

	// Token: 0x04000162 RID: 354
	public bool HQDQHHHMLEJ;

	// Token: 0x04000163 RID: 355
	public List<EventDelegate> QQGILCDILNM = new List<EventDelegate>();

	// Token: 0x04000164 RID: 356
	[NonSerialized]
	private PLQFPBQEPJD LNMJLFLDCML;

	// Token: 0x04000165 RID: 357
	[NonSerialized]
	private ILJNMOPNGQD MDKFELNLBJH;

	// Token: 0x04000166 RID: 358
	[NonSerialized]
	private string BQMOPOOHFNG;

	// Token: 0x04000167 RID: 359
	[NonSerialized]
	private Sprite GIBBLJKEEOL;
}
