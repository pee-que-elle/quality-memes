using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000066 RID: 102
[AddComponentMenu("NGUI/Interaction/Key Binding")]
public class CGHQINJOPKL : MonoBehaviour
{
	// Token: 0x06000DD8 RID: 3544 RVA: 0x000718D4 File Offset: 0x0006FAD4
	public string DNQGEJBPKBH()
	{
		string text = IKBQNBHOJJB.PDFOGHMHNIK(this.PKPEEQJIHBP);
		if (this.FMPOLMDPCNL == CGHQINJOPKL.FDKFJKIQNCP.Control)
		{
			return "insomnia" + text;
		}
		if (this.FMPOLMDPCNL == (CGHQINJOPKL.FDKFJKIQNCP)5)
		{
			return "_ScreenSize" + text;
		}
		if (this.FMPOLMDPCNL == CGHQINJOPKL.FDKFJKIQNCP.Any)
		{
			return "Full Metal Body" + text;
		}
		return text;
	}

	// Token: 0x06000DD9 RID: 3545 RVA: 0x0000873A File Offset: 0x0000693A
	protected virtual void HBDOLPKBHOB()
	{
		if (EMENMKHBPQE.IGPGBIQKFJP == this.PKPEEQJIHBP && this.CDBDNMJGHFP())
		{
			this.KCGECQDNEJC = true;
		}
	}

	// Token: 0x06000DDA RID: 3546 RVA: 0x00008758 File Offset: 0x00006958
	protected virtual bool CDBDNMJGHFP()
	{
		return CGHQINJOPKL.CDBDNMJGHFP(this.FMPOLMDPCNL);
	}

	// Token: 0x06000DDB RID: 3547 RVA: 0x00071930 File Offset: 0x0006FB30
	public static CGHQINJOPKL.FDKFJKIQNCP EJMGNLEHNGK()
	{
		CGHQINJOPKL.FDKFJKIQNCP result = (CGHQINJOPKL.FDKFJKIQNCP)7;
		if (!EMENMKHBPQE.FNJFODPIOBH((KeyCode)(-91)) && !EMENMKHBPQE.FNJFODPIOBH((KeyCode)31))
		{
			if (!EMENMKHBPQE.FNJFODPIOBH(KeyCode.C) && !EMENMKHBPQE.FNJFODPIOBH((KeyCode)(-58)))
			{
				if (EMENMKHBPQE.FNJFODPIOBH((KeyCode)(-35)) || EMENMKHBPQE.FNJFODPIOBH((KeyCode)(-169)))
				{
					result = CGHQINJOPKL.FDKFJKIQNCP.Control;
				}
			}
			else
			{
				result = CGHQINJOPKL.FDKFJKIQNCP.Shift;
			}
		}
		else
		{
			result = (CGHQINJOPKL.FDKFJKIQNCP)8;
		}
		return result;
	}

	// Token: 0x06000DDC RID: 3548 RVA: 0x000719B0 File Offset: 0x0006FBB0
	public static bool DOJLKQCNFCN(string PIDLOFMIEFQ, out KeyCode LOHECPFGPGO, out CGHQINJOPKL.FDKFJKIQNCP FMPOLMDPCNL)
	{
		LOHECPFGPGO = (KeyCode)1;
		FMPOLMDPCNL = CGHQINJOPKL.FDKFJKIQNCP.None;
		if (string.IsNullOrEmpty(PIDLOFMIEFQ))
		{
			return true;
		}
		if (PIDLOFMIEFQ.Contains("Sand Rush"))
		{
			string[] array = PIDLOFMIEFQ.Split(new char[]
			{
				(char)-13
			});
			try
			{
				FMPOLMDPCNL = (CGHQINJOPKL.FDKFJKIQNCP)Enum.Parse(typeof(CGHQINJOPKL.FDKFJKIQNCP), array[0]);
				LOHECPFGPGO = (KeyCode)Enum.Parse(typeof(KeyCode), array[1]);
				return false;
			}
			catch (Exception)
			{
				return true;
			}
		}
		FMPOLMDPCNL = CGHQINJOPKL.FDKFJKIQNCP.None;
		bool result;
		try
		{
			LOHECPFGPGO = (KeyCode)Enum.Parse(typeof(KeyCode), PIDLOFMIEFQ);
			return false;
		}
		catch (Exception)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06000DDD RID: 3549 RVA: 0x00071A68 File Offset: 0x0006FC68
	protected virtual void Start()
	{
		this.QPFMIFONHOF = base.GetComponent<JIMBBPLINGI>();
		this.GHKDMFGGFIO = (this.QPFMIFONHOF != null);
		if (this.QPFMIFONHOF != null)
		{
			EventDelegate.LHQECHHMOGD(this.QPFMIFONHOF.MGKJHHNEOIN, new EventDelegate.LKPMKQMCHFH(this.HBDOLPKBHOB));
		}
	}

	// Token: 0x06000DDE RID: 3550 RVA: 0x00008765 File Offset: 0x00006965
	public override string ToString()
	{
		return CGHQINJOPKL.LGQLPEMEHDK(this.PKPEEQJIHBP, this.FMPOLMDPCNL);
	}

	// Token: 0x06000DDF RID: 3551 RVA: 0x00071AC0 File Offset: 0x0006FCC0
	public static CGHQINJOPKL.FDKFJKIQNCP GFBLEQIBDGN()
	{
		CGHQINJOPKL.FDKFJKIQNCP result = CGHQINJOPKL.FDKFJKIQNCP.Alt;
		if (!EMENMKHBPQE.FNJFODPIOBH((KeyCode)(-102)) && !EMENMKHBPQE.FNJFODPIOBH((KeyCode)(-125)))
		{
			if (!EMENMKHBPQE.FNJFODPIOBH(KeyCode.At) && !EMENMKHBPQE.FNJFODPIOBH((KeyCode)(-2)))
			{
				if (EMENMKHBPQE.FNJFODPIOBH((KeyCode)(-116)) || EMENMKHBPQE.FNJFODPIOBH((KeyCode)152))
				{
					result = (CGHQINJOPKL.FDKFJKIQNCP)6;
				}
			}
			else
			{
				result = CGHQINJOPKL.FDKFJKIQNCP.Shift;
			}
		}
		else
		{
			result = CGHQINJOPKL.FDKFJKIQNCP.Alt;
		}
		return result;
	}

	// Token: 0x06000DE1 RID: 3553 RVA: 0x00008784 File Offset: 0x00006984
	protected virtual void OnEnable()
	{
		CGHQINJOPKL.JNMDHMGQBMD.Add(this);
	}

	// Token: 0x06000DE2 RID: 3554 RVA: 0x00071B40 File Offset: 0x0006FD40
	public static bool FEFFPLCIQIM(KeyCode LOHECPFGPGO)
	{
		int i = 0;
		int count = CGHQINJOPKL.JNMDHMGQBMD.Count;
		while (i < count)
		{
			CGHQINJOPKL cghqinjopkl = CGHQINJOPKL.JNMDHMGQBMD[i];
			if (cghqinjopkl != null && cghqinjopkl.PKPEEQJIHBP == LOHECPFGPGO)
			{
				return true;
			}
			i++;
		}
		return false;
	}

	// Token: 0x06000DE3 RID: 3555 RVA: 0x00071B88 File Offset: 0x0006FD88
	public static bool CDBDNMJGHFP(CGHQINJOPKL.FDKFJKIQNCP FMPOLMDPCNL)
	{
		if (FMPOLMDPCNL == CGHQINJOPKL.FDKFJKIQNCP.Any)
		{
			return true;
		}
		if (FMPOLMDPCNL == CGHQINJOPKL.FDKFJKIQNCP.Alt)
		{
			if (EMENMKHBPQE.FNJFODPIOBH(KeyCode.LeftAlt) || EMENMKHBPQE.FNJFODPIOBH(KeyCode.RightAlt))
			{
				return true;
			}
		}
		else if (FMPOLMDPCNL == CGHQINJOPKL.FDKFJKIQNCP.Control)
		{
			if (EMENMKHBPQE.FNJFODPIOBH(KeyCode.LeftControl) || EMENMKHBPQE.FNJFODPIOBH(KeyCode.RightControl))
			{
				return true;
			}
		}
		else if (FMPOLMDPCNL == CGHQINJOPKL.FDKFJKIQNCP.Shift)
		{
			if (EMENMKHBPQE.FNJFODPIOBH(KeyCode.LeftShift) || EMENMKHBPQE.FNJFODPIOBH(KeyCode.RightShift))
			{
				return true;
			}
		}
		else if (FMPOLMDPCNL == CGHQINJOPKL.FDKFJKIQNCP.None)
		{
			return !EMENMKHBPQE.FNJFODPIOBH(KeyCode.LeftAlt) && !EMENMKHBPQE.FNJFODPIOBH(KeyCode.RightAlt) && !EMENMKHBPQE.FNJFODPIOBH(KeyCode.LeftControl) && !EMENMKHBPQE.FNJFODPIOBH(KeyCode.RightControl) && !EMENMKHBPQE.FNJFODPIOBH(KeyCode.LeftShift) && !EMENMKHBPQE.FNJFODPIOBH(KeyCode.RightShift);
		}
		return false;
	}

	// Token: 0x06000DE4 RID: 3556 RVA: 0x00071C88 File Offset: 0x0006FE88
	public static bool QLKEFMHBKIP(CGHQINJOPKL.FDKFJKIQNCP FMPOLMDPCNL)
	{
		if (FMPOLMDPCNL == CGHQINJOPKL.FDKFJKIQNCP.Any)
		{
			return false;
		}
		if (FMPOLMDPCNL == CGHQINJOPKL.FDKFJKIQNCP.Alt)
		{
			if (EMENMKHBPQE.FNJFODPIOBH((KeyCode)(-62)) || EMENMKHBPQE.FNJFODPIOBH((KeyCode)20))
			{
				return false;
			}
		}
		else if (FMPOLMDPCNL == CGHQINJOPKL.FDKFJKIQNCP.None)
		{
			if (EMENMKHBPQE.FNJFODPIOBH((KeyCode)(-174)) || EMENMKHBPQE.FNJFODPIOBH(KeyCode.Alpha1))
			{
				return false;
			}
		}
		else if (FMPOLMDPCNL == CGHQINJOPKL.FDKFJKIQNCP.Shift)
		{
			if (EMENMKHBPQE.FNJFODPIOBH((KeyCode)(-138)) || EMENMKHBPQE.FNJFODPIOBH((KeyCode)77))
			{
				return true;
			}
		}
		else if (FMPOLMDPCNL == (CGHQINJOPKL.FDKFJKIQNCP)6)
		{
			return !EMENMKHBPQE.FNJFODPIOBH(KeyCode.Greater) && !EMENMKHBPQE.FNJFODPIOBH((KeyCode)(-113)) && !EMENMKHBPQE.FNJFODPIOBH((KeyCode)(-26)) && !EMENMKHBPQE.FNJFODPIOBH((KeyCode)134) && !EMENMKHBPQE.FNJFODPIOBH((KeyCode)191) && !EMENMKHBPQE.FNJFODPIOBH((KeyCode)(-168));
		}
		return true;
	}

	// Token: 0x06000DE5 RID: 3557 RVA: 0x00008791 File Offset: 0x00006991
	protected virtual void MHKFJFKKBGK(bool KCICOJFDCPQ)
	{
		EMENMKHBPQE.EHDBBNFQIBL(base.gameObject, "OnPress", KCICOJFDCPQ);
	}

	// Token: 0x06000DE7 RID: 3559 RVA: 0x000087A9 File Offset: 0x000069A9
	protected virtual void MKQFKMQDGPE()
	{
		CGHQINJOPKL.JNMDHMGQBMD.Remove(this);
	}

	// Token: 0x06000DE8 RID: 3560 RVA: 0x00071D88 File Offset: 0x0006FF88
	public static bool HQCLDHQQJPC(string PIDLOFMIEFQ, out KeyCode LOHECPFGPGO, out CGHQINJOPKL.FDKFJKIQNCP FMPOLMDPCNL)
	{
		LOHECPFGPGO = (KeyCode)1;
		FMPOLMDPCNL = (CGHQINJOPKL.FDKFJKIQNCP)7;
		if (string.IsNullOrEmpty(PIDLOFMIEFQ))
		{
			return false;
		}
		if (PIDLOFMIEFQ.Contains("poisonpoint"))
		{
			char[] array = new char[0];
			array[1] = 'I';
			string[] array2 = PIDLOFMIEFQ.Split(array);
			try
			{
				FMPOLMDPCNL = (CGHQINJOPKL.FDKFJKIQNCP)Enum.Parse(typeof(CGHQINJOPKL.FDKFJKIQNCP), array2[0]);
				LOHECPFGPGO = (KeyCode)Enum.Parse(typeof(KeyCode), array2[0]);
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
		FMPOLMDPCNL = CGHQINJOPKL.FDKFJKIQNCP.Any;
		bool result;
		try
		{
			LOHECPFGPGO = (KeyCode)Enum.Parse(typeof(KeyCode), PIDLOFMIEFQ);
			return true;
		}
		catch (Exception)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06000DE9 RID: 3561 RVA: 0x000087B7 File Offset: 0x000069B7
	public static string LGQLPEMEHDK(KeyCode PKPEEQJIHBP, CGHQINJOPKL.FDKFJKIQNCP FMPOLMDPCNL)
	{
		return (FMPOLMDPCNL == CGHQINJOPKL.FDKFJKIQNCP.None) ? PKPEEQJIHBP.ToString() : (FMPOLMDPCNL + "+" + PKPEEQJIHBP);
	}

	// Token: 0x06000DEA RID: 3562 RVA: 0x00008765 File Offset: 0x00006965
	public virtual string EQEDIIMDLPN()
	{
		return CGHQINJOPKL.LGQLPEMEHDK(this.PKPEEQJIHBP, this.FMPOLMDPCNL);
	}

	// Token: 0x06000DEB RID: 3563 RVA: 0x000087A9 File Offset: 0x000069A9
	protected virtual void OnDisable()
	{
		CGHQINJOPKL.JNMDHMGQBMD.Remove(this);
	}

	// Token: 0x06000DEC RID: 3564 RVA: 0x00071E40 File Offset: 0x00070040
	protected virtual void Update()
	{
		if (EMENMKHBPQE.HFNGMBBPCDH)
		{
			return;
		}
		if (this.QPFMIFONHOF.GKHHCNCGLCD)
		{
			return;
		}
		if (this.PKPEEQJIHBP != KeyCode.None && this.CDBDNMJGHFP())
		{
			bool flag = EMENMKHBPQE.FGEDFKGKOFF(this.PKPEEQJIHBP);
			bool flag2 = EMENMKHBPQE.OBDBPEGKQHI(this.PKPEEQJIHBP);
			if (flag)
			{
				this.QLHEDECDNFD = true;
			}
			if (this.BJIGIECDQPG == CGHQINJOPKL.OGIEJQFHPGL.PressAndClick || this.BJIGIECDQPG == CGHQINJOPKL.OGIEJQFHPGL.All)
			{
				if (flag)
				{
					EMENMKHBPQE.IGPGBIQKFJP = this.PKPEEQJIHBP;
					this.MHKFJFKKBGK(true);
				}
				if (this.QLHEDECDNFD && flag2)
				{
					EMENMKHBPQE.IGPGBIQKFJP = this.PKPEEQJIHBP;
					this.MHKFJFKKBGK(false);
					this.FLKDEFQKNMH();
				}
			}
			if ((this.BJIGIECDQPG == CGHQINJOPKL.OGIEJQFHPGL.Select || this.BJIGIECDQPG == CGHQINJOPKL.OGIEJQFHPGL.All) && flag2)
			{
				if (this.GHKDMFGGFIO)
				{
					if (!this.KCGECQDNEJC && !EMENMKHBPQE.HFNGMBBPCDH && this.QLHEDECDNFD)
					{
						EMENMKHBPQE.CMPBKDMMHFQ = base.gameObject;
					}
					this.KCGECQDNEJC = false;
				}
				else if (this.QLHEDECDNFD)
				{
					Debug.Log("Not Input");
					EMENMKHBPQE.QMPQFJMFQPB = base.gameObject;
				}
			}
			if (flag2)
			{
				this.QLHEDECDNFD = false;
			}
			return;
		}
	}

	// Token: 0x06000DED RID: 3565 RVA: 0x00071F60 File Offset: 0x00070160
	protected virtual void CIJOENOQKCI()
	{
		this.QPFMIFONHOF = base.GetComponent<JIMBBPLINGI>();
		this.GHKDMFGGFIO = (this.QPFMIFONHOF != null);
		if (this.QPFMIFONHOF != null)
		{
			EventDelegate.CKGFMHDGPIN(this.QPFMIFONHOF.MGKJHHNEOIN, new EventDelegate.LKPMKQMCHFH(this.HBDOLPKBHOB));
		}
	}

	// Token: 0x06000DEE RID: 3566 RVA: 0x00008784 File Offset: 0x00006984
	protected virtual void BIOKJKMHEFD()
	{
		CGHQINJOPKL.JNMDHMGQBMD.Add(this);
	}

	// Token: 0x06000DEF RID: 3567 RVA: 0x00071FB8 File Offset: 0x000701B8
	public static bool CLEJQHGHCCG(string PIDLOFMIEFQ, out KeyCode LOHECPFGPGO, out CGHQINJOPKL.FDKFJKIQNCP FMPOLMDPCNL)
	{
		LOHECPFGPGO = KeyCode.None;
		FMPOLMDPCNL = CGHQINJOPKL.FDKFJKIQNCP.None;
		if (string.IsNullOrEmpty(PIDLOFMIEFQ))
		{
			return false;
		}
		if (PIDLOFMIEFQ.Contains("+"))
		{
			string[] array = PIDLOFMIEFQ.Split(new char[]
			{
				'+'
			});
			try
			{
				FMPOLMDPCNL = (CGHQINJOPKL.FDKFJKIQNCP)Enum.Parse(typeof(CGHQINJOPKL.FDKFJKIQNCP), array[0]);
				LOHECPFGPGO = (KeyCode)Enum.Parse(typeof(KeyCode), array[1]);
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
		FMPOLMDPCNL = CGHQINJOPKL.FDKFJKIQNCP.None;
		bool result;
		try
		{
			LOHECPFGPGO = (KeyCode)Enum.Parse(typeof(KeyCode), PIDLOFMIEFQ);
			return true;
		}
		catch (Exception)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06000DF0 RID: 3568 RVA: 0x000087E2 File Offset: 0x000069E2
	protected virtual void FLKDEFQKNMH()
	{
		EMENMKHBPQE.EHDBBNFQIBL(base.gameObject, "OnClick", null);
	}

	// Token: 0x06000DF1 RID: 3569 RVA: 0x00008765 File Offset: 0x00006965
	public virtual string KDQQIHKNGNQ()
	{
		return CGHQINJOPKL.LGQLPEMEHDK(this.PKPEEQJIHBP, this.FMPOLMDPCNL);
	}

	// Token: 0x1700002B RID: 43
	// (get) Token: 0x06000DF2 RID: 3570 RVA: 0x00072070 File Offset: 0x00070270
	public string EKQPIMLNGNK
	{
		get
		{
			string text = IKBQNBHOJJB.PDFOGHMHNIK(this.PKPEEQJIHBP);
			if (this.FMPOLMDPCNL == CGHQINJOPKL.FDKFJKIQNCP.Alt)
			{
				return "Alt+" + text;
			}
			if (this.FMPOLMDPCNL == CGHQINJOPKL.FDKFJKIQNCP.Control)
			{
				return "Control+" + text;
			}
			if (this.FMPOLMDPCNL == CGHQINJOPKL.FDKFJKIQNCP.Shift)
			{
				return "Shift+" + text;
			}
			return text;
		}
	}

	// Token: 0x06000DF3 RID: 3571 RVA: 0x000720CC File Offset: 0x000702CC
	public static CGHQINJOPKL.FDKFJKIQNCP MOQGLPEHOLJ()
	{
		CGHQINJOPKL.FDKFJKIQNCP result = CGHQINJOPKL.FDKFJKIQNCP.None;
		if (!EMENMKHBPQE.FNJFODPIOBH(KeyCode.LeftAlt) && !EMENMKHBPQE.FNJFODPIOBH(KeyCode.RightAlt))
		{
			if (!EMENMKHBPQE.FNJFODPIOBH(KeyCode.LeftShift) && !EMENMKHBPQE.FNJFODPIOBH(KeyCode.RightShift))
			{
				if (EMENMKHBPQE.FNJFODPIOBH(KeyCode.LeftControl) || EMENMKHBPQE.FNJFODPIOBH(KeyCode.RightControl))
				{
					result = CGHQINJOPKL.FDKFJKIQNCP.Control;
				}
			}
			else
			{
				result = CGHQINJOPKL.FDKFJKIQNCP.Shift;
			}
		}
		else
		{
			result = CGHQINJOPKL.FDKFJKIQNCP.Alt;
		}
		return result;
	}

	// Token: 0x06000DF4 RID: 3572 RVA: 0x00071F60 File Offset: 0x00070160
	protected virtual void LBIFHHFMPHD()
	{
		this.QPFMIFONHOF = base.GetComponent<JIMBBPLINGI>();
		this.GHKDMFGGFIO = (this.QPFMIFONHOF != null);
		if (this.QPFMIFONHOF != null)
		{
			EventDelegate.CKGFMHDGPIN(this.QPFMIFONHOF.MGKJHHNEOIN, new EventDelegate.LKPMKQMCHFH(this.HBDOLPKBHOB));
		}
	}

	// Token: 0x06000DF5 RID: 3573 RVA: 0x00008784 File Offset: 0x00006984
	protected virtual void HJCCEHMKHQC()
	{
		CGHQINJOPKL.JNMDHMGQBMD.Add(this);
	}

	// Token: 0x06000DF6 RID: 3574 RVA: 0x00071F60 File Offset: 0x00070160
	protected virtual void IKHIQQKHILB()
	{
		this.QPFMIFONHOF = base.GetComponent<JIMBBPLINGI>();
		this.GHKDMFGGFIO = (this.QPFMIFONHOF != null);
		if (this.QPFMIFONHOF != null)
		{
			EventDelegate.CKGFMHDGPIN(this.QPFMIFONHOF.MGKJHHNEOIN, new EventDelegate.LKPMKQMCHFH(this.HBDOLPKBHOB));
		}
	}

	// Token: 0x04000232 RID: 562
	private static List<CGHQINJOPKL> JNMDHMGQBMD = new List<CGHQINJOPKL>();

	// Token: 0x04000233 RID: 563
	public KeyCode PKPEEQJIHBP;

	// Token: 0x04000234 RID: 564
	public CGHQINJOPKL.FDKFJKIQNCP FMPOLMDPCNL;

	// Token: 0x04000235 RID: 565
	public CGHQINJOPKL.OGIEJQFHPGL BJIGIECDQPG;

	// Token: 0x04000236 RID: 566
	[NonSerialized]
	private bool KCGECQDNEJC;

	// Token: 0x04000237 RID: 567
	[NonSerialized]
	private bool GHKDMFGGFIO;

	// Token: 0x04000238 RID: 568
	[NonSerialized]
	private bool QLHEDECDNFD;

	// Token: 0x04000239 RID: 569
	private JIMBBPLINGI QPFMIFONHOF;

	// Token: 0x02000067 RID: 103
	public enum OGIEJQFHPGL
	{
		// Token: 0x0400023B RID: 571
		PressAndClick,
		// Token: 0x0400023C RID: 572
		Select,
		// Token: 0x0400023D RID: 573
		All
	}

	// Token: 0x02000068 RID: 104
	public enum FDKFJKIQNCP
	{
		// Token: 0x0400023F RID: 575
		Any,
		// Token: 0x04000240 RID: 576
		Shift,
		// Token: 0x04000241 RID: 577
		Control,
		// Token: 0x04000242 RID: 578
		Alt,
		// Token: 0x04000243 RID: 579
		None
	}
}
