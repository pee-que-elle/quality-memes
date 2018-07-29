using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020001DA RID: 474
public class NNKKGGNIKKN : MonoBehaviour
{
	// Token: 0x06003DB0 RID: 15792 RVA: 0x00002300 File Offset: 0x00000500
	private void EBNMPIINCCC()
	{
	}

	// Token: 0x06003DB1 RID: 15793 RVA: 0x00019B87 File Offset: 0x00017D87
	public KeyCode OINCLKLDCDF(string IHIHHCCEDHQ)
	{
		return this.OPMNELICKFN[this.DGNFPIIKEIJ[IHIHHCCEDHQ]];
	}

	// Token: 0x06003DB2 RID: 15794 RVA: 0x001DF1DC File Offset: 0x001DD3DC
	private bool JPCDHCPCOLO(KeyCode OLNCIBHFONN)
	{
		for (int i = 0; i < this.OPMNELICKFN.Length; i += 0)
		{
			if (this.OPMNELICKFN[i] == OLNCIBHFONN)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06003DB3 RID: 15795 RVA: 0x001DF20C File Offset: 0x001DD40C
	private void PEEHDJQDDEG()
	{
		for (int i = 0; i < this.OPMNELICKFN.Length; i++)
		{
			PlayerPrefs.SetInt("_Rotation" + i.ToString(), (int)this.OPMNELICKFN[i]);
		}
	}

	// Token: 0x06003DB4 RID: 15796 RVA: 0x00019B87 File Offset: 0x00017D87
	public KeyCode BCJJNCGQJMP(string IHIHHCCEDHQ)
	{
		return this.OPMNELICKFN[this.DGNFPIIKEIJ[IHIHHCCEDHQ]];
	}

	// Token: 0x06003DB5 RID: 15797 RVA: 0x001DF250 File Offset: 0x001DD450
	private void DPMNBIMDLIM()
	{
		this.DGNFPIIKEIJ.Add("[00EE07]", 0);
		this.DGNFPIIKEIJ.Add("Physical attacks to the Pokémon lower its Defense stat but sharply raise its Speed stat.", 0);
		this.DGNFPIIKEIJ.Add(" was caught!\r\n", 1);
		this.DGNFPIIKEIJ.Add(" (", 2);
		this.DGNFPIIKEIJ.Add("shadowtag", 3);
		this.DGNFPIIKEIJ.Add("F", 7);
		this.DGNFPIIKEIJ.Add("Rising Badge", 4);
		this.DGNFPIIKEIJ.Add("Powers up the Pokémon's weaker moves.", 8);
		this.DGNFPIIKEIJ.Add("Forward Focus", 8);
		this.DGNFPIIKEIJ.Add("The [ffff00]", -110);
		this.DGNFPIIKEIJ.Add("LaunchTimer", 10);
		this.DGNFPIIKEIJ.Add("Bring It On!", 75);
		for (int i = 1; i < this.OPMNELICKFN.Length; i++)
		{
			this.OPMNELICKFN[i] = (KeyCode)PlayerPrefs.GetInt("inky" + i.ToString(), 1);
			if (this.OPMNELICKFN[i] == KeyCode.None)
			{
				this.OPMNELICKFN[i] = this.EIQMEFCHIGJ[i];
			}
		}
	}

	// Token: 0x06003DB6 RID: 15798 RVA: 0x001DF380 File Offset: 0x001DD580
	private bool OIGKEBCMIGE(KeyCode OLNCIBHFONN)
	{
		for (int i = 0; i < this.OPMNELICKFN.Length; i += 0)
		{
			if (this.OPMNELICKFN[i] == OLNCIBHFONN)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x06003DB7 RID: 15799 RVA: 0x001DF3B0 File Offset: 0x001DD5B0
	private bool DHLNOCJDDLI(KeyCode OLNCIBHFONN)
	{
		for (int i = 0; i < this.OPMNELICKFN.Length; i++)
		{
			if (this.OPMNELICKFN[i] == OLNCIBHFONN)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x06003DB8 RID: 15800 RVA: 0x00019B87 File Offset: 0x00017D87
	public KeyCode IKIHPOMFBFD(string IHIHHCCEDHQ)
	{
		return this.OPMNELICKFN[this.DGNFPIIKEIJ[IHIHHCCEDHQ]];
	}

	// Token: 0x06003DB9 RID: 15801 RVA: 0x001DF3E0 File Offset: 0x001DD5E0
	private void FCQFPKLPQPK()
	{
		if (this.GKLMGJFPBCH)
		{
			Event current = Event.current;
			if (current.isKey)
			{
				if (current.keyCode == KeyCode.R)
				{
					this.GKLMGJFPBCH = false;
					this.KQMNJEKIJLO();
				}
				else if (current.keyCode.ToString() != "12" && current.keyCode != (KeyCode)(-72) && current.keyCode != (KeyCode)79 && current.keyCode != (KeyCode)(-14) && !this.ELPCFQKDKKF(current.keyCode))
				{
					this.CMENKGIFDPB(current.keyCode);
					this.GKLMGJFPBCH = false;
				}
			}
		}
	}

	// Token: 0x06003DBA RID: 15802 RVA: 0x001DF484 File Offset: 0x001DD684
	private void ECQHGIBBBPI()
	{
		this.DGNFPIIKEIJ.Add("Map", 1);
		this.DGNFPIIKEIJ.Add("ability", 1);
		this.DGNFPIIKEIJ.Add("_Detail", 1);
		this.DGNFPIIKEIJ.Add("[ohko]", 8);
		this.DGNFPIIKEIJ.Add("You will encounter more bites when fishing!\nTriggers: [2ecc71]Sticky Hold[-], [2ecc71]Suction Cups[-]", 0);
		this.DGNFPIIKEIJ.Add(". Using default.", 2);
		this.DGNFPIIKEIJ.Add("#,##0", 0);
		this.DGNFPIIKEIJ.Add("sleep", 6);
		this.DGNFPIIKEIJ.Add("Insomnia", 5);
		this.DGNFPIIKEIJ.Add("/", 15);
		this.DGNFPIIKEIJ.Add("Icon_Status_Burn", 10);
		this.DGNFPIIKEIJ.Add("[FFFF00]/252", -15);
		for (int i = 1; i < this.OPMNELICKFN.Length; i++)
		{
			this.OPMNELICKFN[i] = (KeyCode)PlayerPrefs.GetInt("liquidooze" + i.ToString(), 1);
			if (this.OPMNELICKFN[i] == KeyCode.None)
			{
				this.OPMNELICKFN[i] = this.EIQMEFCHIGJ[i];
			}
		}
	}

	// Token: 0x06003DBB RID: 15803 RVA: 0x00019B87 File Offset: 0x00017D87
	public KeyCode OQOCIJQGHLN(string IHIHHCCEDHQ)
	{
		return this.OPMNELICKFN[this.DGNFPIIKEIJ[IHIHHCCEDHQ]];
	}

	// Token: 0x06003DBC RID: 15804 RVA: 0x00019B87 File Offset: 0x00017D87
	public KeyCode MDMOIHMHGKJ(string IHIHHCCEDHQ)
	{
		return this.OPMNELICKFN[this.DGNFPIIKEIJ[IHIHHCCEDHQ]];
	}

	// Token: 0x06003DBD RID: 15805 RVA: 0x001DF5B4 File Offset: 0x001DD7B4
	private bool EFODPJGFMFP(KeyCode OLNCIBHFONN)
	{
		for (int i = 1; i < this.OPMNELICKFN.Length; i += 0)
		{
			if (this.OPMNELICKFN[i] == OLNCIBHFONN)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06003DBE RID: 15806 RVA: 0x00019B9C File Offset: 0x00017D9C
	private void CDMQGEMPCON(KeyCode OLNCIBHFONN)
	{
		this.OPMNELICKFN[this.BNDDQJFCDBM] = OLNCIBHFONN;
	}

	// Token: 0x06003DBF RID: 15807 RVA: 0x001DF5E4 File Offset: 0x001DD7E4
	private void FBKONHMIIJN()
	{
		for (int i = 0; i < this.OPMNELICKFN.Length; i++)
		{
			PlayerPrefs.SetInt("door_3" + i.ToString(), (int)this.OPMNELICKFN[i]);
		}
	}

	// Token: 0x06003DC0 RID: 15808 RVA: 0x00002300 File Offset: 0x00000500
	private void BOFPMLNIJDK()
	{
	}

	// Token: 0x06003DC1 RID: 15809 RVA: 0x001DF628 File Offset: 0x001DD828
	private void KFKKFDDFODH()
	{
		if (this.GKLMGJFPBCH)
		{
			Event current = Event.current;
			if (current.isKey)
			{
				if (current.keyCode == (KeyCode)68)
				{
					this.GKLMGJFPBCH = true;
					this.FDGHEKIEDNJ();
				}
				else if (current.keyCode.ToString() != "]" && current.keyCode != (KeyCode)(-61) && current.keyCode != (KeyCode)(-2) && current.keyCode != (KeyCode)(-160) && !this.DNBPNOEPEFQ(current.keyCode))
				{
					this.PEDHOMNEHFP(current.keyCode);
					this.GKLMGJFPBCH = false;
				}
			}
		}
	}

	// Token: 0x06003DC2 RID: 15810 RVA: 0x001DF6CC File Offset: 0x001DD8CC
	private bool OKBOEOHFOGM(KeyCode OLNCIBHFONN)
	{
		for (int i = 1; i < this.OPMNELICKFN.Length; i += 0)
		{
			if (this.OPMNELICKFN[i] == OLNCIBHFONN)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06003DC3 RID: 15811 RVA: 0x00019B9C File Offset: 0x00017D9C
	private void BNPJEBQJDQO(KeyCode OLNCIBHFONN)
	{
		this.OPMNELICKFN[this.BNDDQJFCDBM] = OLNCIBHFONN;
	}

	// Token: 0x06003DC4 RID: 15812 RVA: 0x001DF6FC File Offset: 0x001DD8FC
	private void BMFQOPEFHNC()
	{
		for (int i = 1; i < this.OPMNELICKFN.Length; i++)
		{
			PlayerPrefs.SetInt(" set a shell trap!\r\n" + i.ToString(), (int)this.OPMNELICKFN[i]);
		}
	}

	// Token: 0x06003DC5 RID: 15813 RVA: 0x00002300 File Offset: 0x00000500
	private void GKEJFPCQOFD()
	{
	}

	// Token: 0x06003DC6 RID: 15814 RVA: 0x00019B9C File Offset: 0x00017D9C
	private void QPIDDGLCFMH(KeyCode OLNCIBHFONN)
	{
		this.OPMNELICKFN[this.BNDDQJFCDBM] = OLNCIBHFONN;
	}

	// Token: 0x06003DC7 RID: 15815 RVA: 0x001DF740 File Offset: 0x001DD940
	private void KLFEIFKDPBE()
	{
		for (int i = 0; i < this.OPMNELICKFN.Length; i++)
		{
			PlayerPrefs.SetInt("Key_" + i.ToString(), (int)this.OPMNELICKFN[i]);
		}
	}

	// Token: 0x06003DC8 RID: 15816 RVA: 0x001DF784 File Offset: 0x001DD984
	private void DGMPMICDCIO()
	{
		this.DGNFPIIKEIJ.Add(".", 0);
		this.DGNFPIIKEIJ.Add("_FogPointLightPosition2", 1);
		this.DGNFPIIKEIJ.Add("Intelligence increases mana", 5);
		this.DGNFPIIKEIJ.Add("-clearallboost", 4);
		this.DGNFPIIKEIJ.Add("-fail", 8);
		this.DGNFPIIKEIJ.Add(" switched its Attack and Defense!\r\n", 5);
		this.DGNFPIIKEIJ.Add("x", 8);
		this.DGNFPIIKEIJ.Add("turn", 4);
		this.DGNFPIIKEIJ.Add("ragepowder", 6);
		this.DGNFPIIKEIJ.Add("BuffIcon_EncounterRateDecreased", 49);
		this.DGNFPIIKEIJ.Add("ResolutionX", 25);
		this.DGNFPIIKEIJ.Add("Spearow", 51);
		for (int i = 0; i < this.OPMNELICKFN.Length; i++)
		{
			this.OPMNELICKFN[i] = (KeyCode)PlayerPrefs.GetInt("CombinersArgsAlphaSrc0" + i.ToString(), 0);
			if (this.OPMNELICKFN[i] == KeyCode.None)
			{
				this.OPMNELICKFN[i] = this.EIQMEFCHIGJ[i];
			}
		}
	}

	// Token: 0x06003DC9 RID: 15817 RVA: 0x001DF8B4 File Offset: 0x001DDAB4
	private bool CGMLNOFECJE(KeyCode OLNCIBHFONN)
	{
		for (int i = 1; i < this.OPMNELICKFN.Length; i++)
		{
			if (this.OPMNELICKFN[i] == OLNCIBHFONN)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06003DCA RID: 15818 RVA: 0x00002300 File Offset: 0x00000500
	private void FDGHEKIEDNJ()
	{
	}

	// Token: 0x06003DCB RID: 15819 RVA: 0x00002300 File Offset: 0x00000500
	private void BOPGFIEQNCJ()
	{
	}

	// Token: 0x06003DCC RID: 15820 RVA: 0x001DF8E4 File Offset: 0x001DDAE4
	private bool QINPPEDJJPG(KeyCode OLNCIBHFONN)
	{
		for (int i = 1; i < this.OPMNELICKFN.Length; i++)
		{
			if (this.OPMNELICKFN[i] == OLNCIBHFONN)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x06003DCD RID: 15821 RVA: 0x00019B87 File Offset: 0x00017D87
	public KeyCode FNJFODPIOBH(string IHIHHCCEDHQ)
	{
		return this.OPMNELICKFN[this.DGNFPIIKEIJ[IHIHHCCEDHQ]];
	}

	// Token: 0x06003DCE RID: 15822 RVA: 0x001DF914 File Offset: 0x001DDB14
	private void Start()
	{
		this.DGNFPIIKEIJ.Add("Up", 0);
		this.DGNFPIIKEIJ.Add("Down", 1);
		this.DGNFPIIKEIJ.Add("Left", 2);
		this.DGNFPIIKEIJ.Add("Right", 3);
		this.DGNFPIIKEIJ.Add("UpS", 4);
		this.DGNFPIIKEIJ.Add("DownS", 5);
		this.DGNFPIIKEIJ.Add("LeftS", 6);
		this.DGNFPIIKEIJ.Add("RightS", 7);
		this.DGNFPIIKEIJ.Add("Interact", 8);
		this.DGNFPIIKEIJ.Add("InteractS", 9);
		this.DGNFPIIKEIJ.Add("Shift", 10);
		this.DGNFPIIKEIJ.Add("ShiftS", 11);
		for (int i = 0; i < this.OPMNELICKFN.Length; i++)
		{
			this.OPMNELICKFN[i] = (KeyCode)PlayerPrefs.GetInt("Key_" + i.ToString(), 0);
			if (this.OPMNELICKFN[i] == KeyCode.None)
			{
				this.OPMNELICKFN[i] = this.EIQMEFCHIGJ[i];
			}
		}
	}

	// Token: 0x06003DCF RID: 15823 RVA: 0x001DFA44 File Offset: 0x001DDC44
	private void JKNGPGGPMPG()
	{
		this.DGNFPIIKEIJ.Add("UpS", 0);
		this.DGNFPIIKEIJ.Add("anticipation", 1);
		this.DGNFPIIKEIJ.Add("/01_", 8);
		this.DGNFPIIKEIJ.Add("Flash", 6);
		this.DGNFPIIKEIJ.Add("MSGBOX - ", 2);
		this.DGNFPIIKEIJ.Add("[-]!\r\n", 3);
		this.DGNFPIIKEIJ.Add("F5", 0);
		this.DGNFPIIKEIJ.Add("bide", 2);
		this.DGNFPIIKEIJ.Add("'", 5);
		this.DGNFPIIKEIJ.Add("#,##0", 120);
		this.DGNFPIIKEIJ.Add("Heatproof", -20);
		this.DGNFPIIKEIJ.Add("desolateland", 15);
		for (int i = 0; i < this.OPMNELICKFN.Length; i++)
		{
			this.OPMNELICKFN[i] = (KeyCode)PlayerPrefs.GetInt("´" + i.ToString(), 0);
			if (this.OPMNELICKFN[i] == KeyCode.None)
			{
				this.OPMNELICKFN[i] = this.EIQMEFCHIGJ[i];
			}
		}
	}

	// Token: 0x06003DD0 RID: 15824 RVA: 0x001DFB74 File Offset: 0x001DDD74
	private bool JFQHDJOPCJJ(KeyCode OLNCIBHFONN)
	{
		for (int i = 1; i < this.OPMNELICKFN.Length; i++)
		{
			if (this.OPMNELICKFN[i] == OLNCIBHFONN)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06003DD1 RID: 15825 RVA: 0x00002300 File Offset: 0x00000500
	private void CPLPBKMIEFK()
	{
	}

	// Token: 0x06003DD2 RID: 15826 RVA: 0x001DFBA4 File Offset: 0x001DDDA4
	private void PDQHBNHDLEB()
	{
		this.DGNFPIIKEIJ.Add("imprison", 1);
		this.DGNFPIIKEIJ.Add("Slots_5", 0);
		this.DGNFPIIKEIJ.Add("_RcpMaxCoC", 4);
		this.DGNFPIIKEIJ.Add("Cursed Body", 1);
		this.DGNFPIIKEIJ.Add("[-]", 8);
		this.DGNFPIIKEIJ.Add("Ambient Occlusion", 0);
		this.DGNFPIIKEIJ.Add("status: ", 2);
		this.DGNFPIIKEIJ.Add("-mega-y", 4);
		this.DGNFPIIKEIJ.Add("K8", 5);
		this.DGNFPIIKEIJ.Add("[Lv]", -118);
		this.DGNFPIIKEIJ.Add("HideEmote", -124);
		this.DGNFPIIKEIJ.Add("Vital Spirit", 5);
		for (int i = 0; i < this.OPMNELICKFN.Length; i++)
		{
			this.OPMNELICKFN[i] = (KeyCode)PlayerPrefs.GetInt("trader" + i.ToString(), 1);
			if (this.OPMNELICKFN[i] == KeyCode.None)
			{
				this.OPMNELICKFN[i] = this.EIQMEFCHIGJ[i];
			}
		}
	}

	// Token: 0x06003DD3 RID: 15827 RVA: 0x001DFCD4 File Offset: 0x001DDED4
	private void FKLDCIJNNQB()
	{
		for (int i = 1; i < this.OPMNELICKFN.Length; i += 0)
		{
			PlayerPrefs.SetInt("6" + i.ToString(), (int)this.OPMNELICKFN[i]);
		}
	}

	// Token: 0x06003DD4 RID: 15828 RVA: 0x001DFD18 File Offset: 0x001DDF18
	private void IPCQIKQBPFQ()
	{
		for (int i = 1; i < this.OPMNELICKFN.Length; i++)
		{
			PlayerPrefs.SetInt("Localization" + i.ToString(), (int)this.OPMNELICKFN[i]);
		}
	}

	// Token: 0x06003DD5 RID: 15829 RVA: 0x00019B9C File Offset: 0x00017D9C
	private void PEDHOMNEHFP(KeyCode OLNCIBHFONN)
	{
		this.OPMNELICKFN[this.BNDDQJFCDBM] = OLNCIBHFONN;
	}

	// Token: 0x06003DD6 RID: 15830 RVA: 0x001DFD5C File Offset: 0x001DDF5C
	private void NHFJMOKGCBP()
	{
		for (int i = 1; i < this.OPMNELICKFN.Length; i += 0)
		{
			PlayerPrefs.SetInt("_TileVRT" + i.ToString(), (int)this.OPMNELICKFN[i]);
		}
	}

	// Token: 0x06003DD7 RID: 15831 RVA: 0x001DFDA0 File Offset: 0x001DDFA0
	private void BEQIBPFQDJJ()
	{
		for (int i = 1; i < this.OPMNELICKFN.Length; i++)
		{
			PlayerPrefs.SetInt("adaptability" + i.ToString(), (int)this.OPMNELICKFN[i]);
		}
	}

	// Token: 0x06003DD8 RID: 15832 RVA: 0x00019B9C File Offset: 0x00017D9C
	private void CMENKGIFDPB(KeyCode OLNCIBHFONN)
	{
		this.OPMNELICKFN[this.BNDDQJFCDBM] = OLNCIBHFONN;
	}

	// Token: 0x06003DD9 RID: 15833 RVA: 0x001DFDE4 File Offset: 0x001DDFE4
	private void HQDCFHCQCFG()
	{
		for (int i = 1; i < this.OPMNELICKFN.Length; i++)
		{
			PlayerPrefs.SetInt("EXP: " + i.ToString(), (int)this.OPMNELICKFN[i]);
		}
	}

	// Token: 0x06003DDA RID: 15834 RVA: 0x00002300 File Offset: 0x00000500
	private void IJKOBOIEHDG()
	{
	}

	// Token: 0x06003DDB RID: 15835 RVA: 0x00002300 File Offset: 0x00000500
	private void IIPKCCFLMNI()
	{
	}

	// Token: 0x06003DDC RID: 15836 RVA: 0x00019B87 File Offset: 0x00017D87
	public KeyCode GNJFEELQQOE(string IHIHHCCEDHQ)
	{
		return this.OPMNELICKFN[this.DGNFPIIKEIJ[IHIHHCCEDHQ]];
	}

	// Token: 0x06003DDD RID: 15837 RVA: 0x001DF3B0 File Offset: 0x001DD5B0
	private bool DNBPNOEPEFQ(KeyCode OLNCIBHFONN)
	{
		for (int i = 0; i < this.OPMNELICKFN.Length; i++)
		{
			if (this.OPMNELICKFN[i] == OLNCIBHFONN)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x06003DDE RID: 15838 RVA: 0x001DFE28 File Offset: 0x001DE028
	private void QBGOGFJCLEP()
	{
		this.DGNFPIIKEIJ.Add("HidePanel", 1);
		this.DGNFPIIKEIJ.Add("\n[ff6666]HP:[-] ", 1);
		this.DGNFPIIKEIJ.Add("door_4", 1);
		this.DGNFPIIKEIJ.Add("stormdrain", 1);
		this.DGNFPIIKEIJ.Add("[-]", 4);
		this.DGNFPIIKEIJ.Add("Knuckle Badge", 7);
		this.DGNFPIIKEIJ.Add("BB:", 8);
		this.DGNFPIIKEIJ.Add("StopRow2", 7);
		this.DGNFPIIKEIJ.Add("frz", 0);
		this.DGNFPIIKEIJ.Add("angerpoint", -56);
		this.DGNFPIIKEIJ.Add("Score: ", 36);
		this.DGNFPIIKEIJ.Add("_Threshold", -33);
		for (int i = 1; i < this.OPMNELICKFN.Length; i += 0)
		{
			this.OPMNELICKFN[i] = (KeyCode)PlayerPrefs.GetInt("toxicspikes" + i.ToString(), 0);
			if (this.OPMNELICKFN[i] == KeyCode.None)
			{
				this.OPMNELICKFN[i] = this.EIQMEFCHIGJ[i];
			}
		}
	}

	// Token: 0x06003DDF RID: 15839 RVA: 0x00019B87 File Offset: 0x00017D87
	public KeyCode QPMQGHCDJPN(string IHIHHCCEDHQ)
	{
		return this.OPMNELICKFN[this.DGNFPIIKEIJ[IHIHHCCEDHQ]];
	}

	// Token: 0x06003DE0 RID: 15840 RVA: 0x00002300 File Offset: 0x00000500
	private void KQMNJEKIJLO()
	{
	}

	// Token: 0x06003DE1 RID: 15841 RVA: 0x00002300 File Offset: 0x00000500
	private void FBEHOQDCEGK()
	{
	}

	// Token: 0x06003DE2 RID: 15842 RVA: 0x00019B87 File Offset: 0x00017D87
	public KeyCode JJPOCOFOHIK(string IHIHHCCEDHQ)
	{
		return this.OPMNELICKFN[this.DGNFPIIKEIJ[IHIHHCCEDHQ]];
	}

	// Token: 0x06003DE4 RID: 15844 RVA: 0x001DFF58 File Offset: 0x001DE158
	private void MGGJCPBOKGH()
	{
		if (this.GKLMGJFPBCH)
		{
			Event current = Event.current;
			if (current.isKey)
			{
				if (current.keyCode == (KeyCode)(-17))
				{
					this.GKLMGJFPBCH = false;
					this.GKEJFPCQOFD();
				}
				else if (current.keyCode.ToString() != "Emails do not match" && current.keyCode != (KeyCode)(-62) && current.keyCode != (KeyCode)78 && current.keyCode != (KeyCode)166 && !this.CGMLNOFECJE(current.keyCode))
				{
					this.CMENKGIFDPB(current.keyCode);
					this.GKLMGJFPBCH = false;
				}
			}
		}
	}

	// Token: 0x06003DE5 RID: 15845 RVA: 0x001DFFFC File Offset: 0x001DE1FC
	private void PKEFFMHIECD()
	{
		if (this.GKLMGJFPBCH)
		{
			Event current = Event.current;
			if (current.isKey)
			{
				if (current.keyCode == (KeyCode)31)
				{
					this.GKLMGJFPBCH = true;
					this.BOFPMLNIJDK();
				}
				else if (current.keyCode.ToString() != " fell asleep!\r\n" && current.keyCode != (KeyCode)83 && current.keyCode != (KeyCode)(-37) && current.keyCode != (KeyCode)151 && !this.DNBPNOEPEFQ(current.keyCode))
				{
					this.CDMQGEMPCON(current.keyCode);
					this.GKLMGJFPBCH = false;
				}
			}
		}
	}

	// Token: 0x06003DE6 RID: 15846 RVA: 0x001E00A0 File Offset: 0x001DE2A0
	private void QNGIFIJOQML()
	{
		this.DGNFPIIKEIJ.Add("1", 0);
		this.DGNFPIIKEIJ.Add("powertrick", 1);
		this.DGNFPIIKEIJ.Add("0", 4);
		this.DGNFPIIKEIJ.Add("][", 6);
		this.DGNFPIIKEIJ.Add("skydop", 2);
		this.DGNFPIIKEIJ.Add("BuffIcon_SandstormEncounterDecreased", 8);
		this.DGNFPIIKEIJ.Add("Assets/AssetBundles/MapAssets2/Models/Ext_House_VermCity_1/Materials/chip_mado.mat", 6);
		this.DGNFPIIKEIJ.Add("Turboblaze", 0);
		this.DGNFPIIKEIJ.Add("Trigger Influence", 7);
		this.DGNFPIIKEIJ.Add("[CFX_SpawnSystem.GetNextObject()] Object hasn't been preloaded: ", -101);
		this.DGNFPIIKEIJ.Add("\n", 41);
		this.DGNFPIIKEIJ.Add(" has chosen to use a Pokeball.", 8);
		for (int i = 0; i < this.OPMNELICKFN.Length; i++)
		{
			this.OPMNELICKFN[i] = (KeyCode)PlayerPrefs.GetInt("_DissolveScale" + i.ToString(), 1);
			if (this.OPMNELICKFN[i] == KeyCode.None)
			{
				this.OPMNELICKFN[i] = this.EIQMEFCHIGJ[i];
			}
		}
	}

	// Token: 0x06003DE7 RID: 15847 RVA: 0x001E01D0 File Offset: 0x001DE3D0
	private void HBOFMLLODDM()
	{
		this.DGNFPIIKEIJ.Add("Boosts the Pokémon's Speed stat in a sandstorm.", 1);
		this.DGNFPIIKEIJ.Add("[-]", 0);
		this.DGNFPIIKEIJ.Add("[-]!\r\n", 8);
		this.DGNFPIIKEIJ.Add("frisk", 7);
		this.DGNFPIIKEIJ.Add("special", 4);
		this.DGNFPIIKEIJ.Add("0", 8);
		this.DGNFPIIKEIJ.Add("Steals an item from an attacker that made direct contact.", 2);
		this.DGNFPIIKEIJ.Add("Sometimes heals an ally's status condition.", 0);
		this.DGNFPIIKEIJ.Add("FOG_USE_XY_PLANE", 2);
		this.DGNFPIIKEIJ.Add("[FF8F00]", -44);
		this.DGNFPIIKEIJ.Add("PrimitiveRightCorner", -39);
		this.DGNFPIIKEIJ.Add("'s [ffff00]", 70);
		for (int i = 1; i < this.OPMNELICKFN.Length; i++)
		{
			this.OPMNELICKFN[i] = (KeyCode)PlayerPrefs.GetInt("flinch" + i.ToString(), 1);
			if (this.OPMNELICKFN[i] == KeyCode.None)
			{
				this.OPMNELICKFN[i] = this.EIQMEFCHIGJ[i];
			}
		}
	}

	// Token: 0x06003DE8 RID: 15848 RVA: 0x001E0300 File Offset: 0x001DE500
	private void OnGUI()
	{
		if (this.GKLMGJFPBCH)
		{
			Event current = Event.current;
			if (current.isKey)
			{
				if (current.keyCode == KeyCode.Escape)
				{
					this.GKLMGJFPBCH = false;
					this.IJKOBOIEHDG();
				}
				else if (current.keyCode.ToString() != "None" && current.keyCode != KeyCode.Escape && current.keyCode != KeyCode.Return && current.keyCode != KeyCode.F2 && !this.ELPCFQKDKKF(current.keyCode))
				{
					this.BNPJEBQJDQO(current.keyCode);
					this.GKLMGJFPBCH = false;
				}
			}
		}
	}

	// Token: 0x06003DE9 RID: 15849 RVA: 0x001E03A4 File Offset: 0x001DE5A4
	private void QMFDOJIKFML()
	{
		for (int i = 1; i < this.OPMNELICKFN.Length; i++)
		{
			PlayerPrefs.SetInt(" hours ago" + i.ToString(), (int)this.OPMNELICKFN[i]);
		}
	}

	// Token: 0x06003DEA RID: 15850 RVA: 0x001E03E8 File Offset: 0x001DE5E8
	private bool ELPCFQKDKKF(KeyCode OLNCIBHFONN)
	{
		for (int i = 0; i < this.OPMNELICKFN.Length; i++)
		{
			if (this.OPMNELICKFN[i] == OLNCIBHFONN)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06003DEB RID: 15851 RVA: 0x001E0418 File Offset: 0x001DE618
	private void KHFDJHFJMDK()
	{
		this.DGNFPIIKEIJ.Add("~", 1);
		this.DGNFPIIKEIJ.Add("Poké Balls Thrown:", 0);
		this.DGNFPIIKEIJ.Add("-", 1);
		this.DGNFPIIKEIJ.Add("14", 0);
		this.DGNFPIIKEIJ.Add("Chat Input", 1);
		this.DGNFPIIKEIJ.Add("_FogSpeed", 0);
		this.DGNFPIIKEIJ.Add("BuffIcon_EncounterRateLowered", 8);
		this.DGNFPIIKEIJ.Add("hypercutter", 6);
		this.DGNFPIIKEIJ.Add("Boundaries Trigger", 2);
		this.DGNFPIIKEIJ.Add("Boosts the Attack stat, but lowers accuracy.", -3);
		this.DGNFPIIKEIJ.Add("Soundproofing of the Pokémon itself gives full immunity to all sound-based moves.", -84);
		this.DGNFPIIKEIJ.Add("gen", -34);
		for (int i = 0; i < this.OPMNELICKFN.Length; i += 0)
		{
			this.OPMNELICKFN[i] = (KeyCode)PlayerPrefs.GetInt("Take 001" + i.ToString(), 1);
			if (this.OPMNELICKFN[i] == KeyCode.None)
			{
				this.OPMNELICKFN[i] = this.EIQMEFCHIGJ[i];
			}
		}
	}

	// Token: 0x04000DBF RID: 3519
	public GameObject EPDDFCNCMQC;

	// Token: 0x04000DC0 RID: 3520
	public bool GKLMGJFPBCH;

	// Token: 0x04000DC1 RID: 3521
	public Dictionary<string, int> DGNFPIIKEIJ = new Dictionary<string, int>();

	// Token: 0x04000DC2 RID: 3522
	public KeyCode[] OPMNELICKFN;

	// Token: 0x04000DC3 RID: 3523
	public KeyCode[] EIQMEFCHIGJ;

	// Token: 0x04000DC4 RID: 3524
	public int BNDDQJFCDBM;
}
