using System;
using UnityEngine;

// Token: 0x0200018B RID: 395
public class HELQOJBMFOI : MonoBehaviour
{
	// Token: 0x0600310B RID: 12555 RVA: 0x00015EA3 File Offset: 0x000140A3
	private void BBFBCBMEJEN()
	{
		this.NNFMFGDPCPF = base.GetComponent<JLMPBLMOICG>();
		this.NNFMFGDPCPF.PPLIPCEHGNM = new Material((Material)Resources.Load("gray", typeof(Material)));
	}

	// Token: 0x0600310C RID: 12556 RVA: 0x00015EDA File Offset: 0x000140DA
	public void FBMDHOBQGIG(int IKIJBQLMKJO, bool HFDFIILFGBL)
	{
		this.DPQFDCNLLPC = HELQOJBMFOI.KNEJQBPFEON.None;
		this.CIQFCJGQEMH = IKIJBQLMKJO;
		this.HFDFIILFGBL = HFDFIILFGBL;
		this.GPJLQMFKNON = false;
		this.MPHLLMKDQEF = true;
	}

	// Token: 0x0600310D RID: 12557 RVA: 0x00172490 File Offset: 0x00170690
	private void EMFBQIQLGMD()
	{
		if (this.NNFMFGDPCPF != null && this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.None)
		{
			Material pplipcehgnm = this.NNFMFGDPCPF.PPLIPCEHGNM;
			if (pplipcehgnm != null)
			{
				if (this.MGJBMGMEGBF != null)
				{
					pplipcehgnm.SetTexture("HidePanel", this.MGJBMGMEGBF);
					pplipcehgnm.SetFloat("Player/Hair", this.HOOONLPEQOI.x);
					pplipcehgnm.SetFloat("ProCamera2D does not exist.", this.HOOONLPEQOI.y);
					pplipcehgnm.SetFloat("The specified buffer must be at least ", this.GDCCBPNGNCE.x);
					pplipcehgnm.SetFloat("Btn_TabHighlighted_Normal", this.GDCCBPNGNCE.y);
				}
				else
				{
					pplipcehgnm.SetTexture("OnPress", (Texture2D)Resources.Load("map:flymap", typeof(Texture2D)));
				}
				pplipcehgnm.SetFloat("-unboost", this.QNBFBLJCHDC);
				pplipcehgnm.SetFloat("The Pokémon can poison the target even if it's a Steel or Poison type.", this.NBJPJBEQKPI);
				pplipcehgnm.SetFloat("Lucky Chant shielded ", this.FJIKLOFOBBC);
				pplipcehgnm.SetFloat("[sup]", this.GJEMMBBNGLB);
				pplipcehgnm.SetFloat("Moderator", this.LDBMOOIEBHP);
				pplipcehgnm.SetFloat("_Direction", this.DMOLEJHGHCF);
				pplipcehgnm.SetFloat("Home", this.LKFEFNKEFDH);
				pplipcehgnm.SetFloat("_MainTex", this.PLDLQOMPMHB);
				pplipcehgnm.SetFloat("Raises the likelihood of meeting wild Pokémon by illuminating the surroundings.", this.GKOFGGEHFBM);
			}
		}
		if (this.MPHLLMKDQEF)
		{
			this.NNFMFGDPCPF.enabled = true;
			if (this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.None)
			{
				this.NNFMFGDPCPF.enabled = false;
			}
			else if (this.DPQFDCNLLPC == (HELQOJBMFOI.KNEJQBPFEON)7)
			{
				this.NNFMFGDPCPF.PPLIPCEHGNM.shader = Shader.Find("-mega");
				this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load("Assets/AssetBundles/MapAssets2/ModelPrefabs/" + this.CIQFCJGQEMH + "All sound-based moves become Water-type moves.", typeof(Texture));
				if (this.NNFMFGDPCPF.GOIHJQNMMJD == null)
				{
					this.NNFMFGDPCPF.enabled = false;
				}
			}
			else if (this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.Monster)
			{
				this.NNFMFGDPCPF.PPLIPCEHGNM.shader = Shader.Find("FOG_HAZE_ON");
				if (this.HFDFIILFGBL)
				{
					this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load("[/O]" + this.CIQFCJGQEMH + "[red]", typeof(Texture));
				}
				else
				{
					this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load("Blade" + this.CIQFCJGQEMH + "Trade Error", typeof(Texture));
				}
				if (this.NNFMFGDPCPF.GOIHJQNMMJD == null)
				{
					this.NNFMFGDPCPF.enabled = false;
				}
			}
			if (this.GPJLQMFKNON)
			{
				this.QNBFBLJCHDC = 88f;
			}
			else
			{
				this.QNBFBLJCHDC = 1183f;
			}
			this.MPHLLMKDQEF = false;
		}
	}

	// Token: 0x0600310E RID: 12558 RVA: 0x00015EFF File Offset: 0x000140FF
	public void HEEKJLHGCNE(int IKIJBQLMKJO, bool HFDFIILFGBL)
	{
		this.DPQFDCNLLPC = HELQOJBMFOI.KNEJQBPFEON.Monster;
		this.CIQFCJGQEMH = IKIJBQLMKJO;
		this.HFDFIILFGBL = HFDFIILFGBL;
		this.GPJLQMFKNON = true;
		this.MPHLLMKDQEF = false;
	}

	// Token: 0x0600310F RID: 12559 RVA: 0x00015F24 File Offset: 0x00014124
	private void NGDJNKQELNO()
	{
		this.NNFMFGDPCPF = base.GetComponent<JLMPBLMOICG>();
		this.NNFMFGDPCPF.PPLIPCEHGNM = new Material((Material)Resources.Load("|", typeof(Material)));
	}

	// Token: 0x06003110 RID: 12560 RVA: 0x00015F5B File Offset: 0x0001415B
	public void GEGEJHOQCGH(int IKIJBQLMKJO, bool HFDFIILFGBL)
	{
		this.DPQFDCNLLPC = HELQOJBMFOI.KNEJQBPFEON.Monster;
		this.CIQFCJGQEMH = IKIJBQLMKJO;
		this.HFDFIILFGBL = HFDFIILFGBL;
		this.GPJLQMFKNON = false;
		this.MPHLLMKDQEF = false;
	}

	// Token: 0x06003111 RID: 12561 RVA: 0x00015F80 File Offset: 0x00014180
	private void LEJQMIECFCH()
	{
		this.NNFMFGDPCPF = base.GetComponent<JLMPBLMOICG>();
		this.NNFMFGDPCPF.PPLIPCEHGNM = new Material((Material)Resources.Load(" ended!\r\n", typeof(Material)));
	}

	// Token: 0x06003112 RID: 12562 RVA: 0x001727A4 File Offset: 0x001709A4
	private void GKMKINDKNPJ()
	{
		if (this.NNFMFGDPCPF != null && this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.Monster)
		{
			Material pplipcehgnm = this.NNFMFGDPCPF.PPLIPCEHGNM;
			if (pplipcehgnm != null)
			{
				if (this.MGJBMGMEGBF != null)
				{
					pplipcehgnm.SetTexture("Strong Jaw", this.MGJBMGMEGBF);
					pplipcehgnm.SetFloat("Music", this.HOOONLPEQOI.x);
					pplipcehgnm.SetFloat("The Pokémon's marvelous scales boost the Defense stat if it has a status condition.", this.HOOONLPEQOI.y);
					pplipcehgnm.SetFloat("s", this.GDCCBPNGNCE.x);
					pplipcehgnm.SetFloat(" Obtained ", this.GDCCBPNGNCE.y);
				}
				else
				{
					pplipcehgnm.SetTexture("/", (Texture2D)Resources.Load("PropertyBinding", typeof(Texture2D)));
				}
				pplipcehgnm.SetFloat("An email containing a new verification code has been sent.", this.QNBFBLJCHDC);
				pplipcehgnm.SetFloat("r", this.NBJPJBEQKPI);
				pplipcehgnm.SetFloat("Sweet Scent", this.FJIKLOFOBBC);
				pplipcehgnm.SetFloat("[-]!\r\n", this.GJEMMBBNGLB);
				pplipcehgnm.SetFloat("roleplay", this.LDBMOOIEBHP);
				pplipcehgnm.SetFloat("You can not use buffs during interactions.", this.DMOLEJHGHCF);
				pplipcehgnm.SetFloat(" was freed from the telekinesis!\r\n", this.LKFEFNKEFDH);
				pplipcehgnm.SetFloat("/0", this.PLDLQOMPMHB);
				pplipcehgnm.SetFloat("l", this.GKOFGGEHFBM);
			}
		}
		if (this.MPHLLMKDQEF)
		{
			this.NNFMFGDPCPF.enabled = true;
			if (this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.None)
			{
				this.NNFMFGDPCPF.enabled = true;
			}
			else if (this.DPQFDCNLLPC == (HELQOJBMFOI.KNEJQBPFEON)7)
			{
				this.NNFMFGDPCPF.PPLIPCEHGNM.shader = Shader.Find("ingrain");
				this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load("[00]" + this.CIQFCJGQEMH + "Storm Drain", typeof(Texture));
				if (this.NNFMFGDPCPF.GOIHJQNMMJD == null)
				{
					this.NNFMFGDPCPF.enabled = false;
				}
			}
			else if (this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.None)
			{
				this.NNFMFGDPCPF.PPLIPCEHGNM.shader = Shader.Find("Rails");
				if (this.HFDFIILFGBL)
				{
					this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load("[ATK]" + this.CIQFCJGQEMH + "/force right", typeof(Texture));
				}
				else
				{
					this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load("The Pokémon, sensing danger, switches out when its HP becomes half or less." + this.CIQFCJGQEMH + "infestation", typeof(Texture));
				}
				if (this.NNFMFGDPCPF.GOIHJQNMMJD == null)
				{
					this.NNFMFGDPCPF.enabled = true;
				}
			}
			if (this.GPJLQMFKNON)
			{
				this.QNBFBLJCHDC = 897f;
			}
			else
			{
				this.QNBFBLJCHDC = 467f;
			}
			this.MPHLLMKDQEF = true;
		}
	}

	// Token: 0x06003113 RID: 12563 RVA: 0x00015FB7 File Offset: 0x000141B7
	private void EMMIHJIFJFM()
	{
		this.NNFMFGDPCPF = base.GetComponent<JLMPBLMOICG>();
		this.NNFMFGDPCPF.PPLIPCEHGNM = new Material((Material)Resources.Load("HidePanel", typeof(Material)));
	}

	// Token: 0x06003114 RID: 12564 RVA: 0x00015FEE File Offset: 0x000141EE
	public void GJCOMBEFCCE(int IKIJBQLMKJO, bool HFDFIILFGBL)
	{
		this.DPQFDCNLLPC = HELQOJBMFOI.KNEJQBPFEON.None;
		this.CIQFCJGQEMH = IKIJBQLMKJO;
		this.HFDFIILFGBL = HFDFIILFGBL;
		this.GPJLQMFKNON = true;
		this.MPHLLMKDQEF = true;
	}

	// Token: 0x06003115 RID: 12565 RVA: 0x00172AB8 File Offset: 0x00170CB8
	private void EPOCMHBMHGC()
	{
		if (this.NNFMFGDPCPF != null && this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.Monster)
		{
			Material pplipcehgnm = this.NNFMFGDPCPF.PPLIPCEHGNM;
			if (pplipcehgnm != null)
			{
				if (this.MGJBMGMEGBF != null)
				{
					pplipcehgnm.SetTexture("-1", this.MGJBMGMEGBF);
					pplipcehgnm.SetFloat("!\r\n", this.HOOONLPEQOI.x);
					pplipcehgnm.SetFloat("motordrive", this.HOOONLPEQOI.y);
					pplipcehgnm.SetFloat("tox", this.GDCCBPNGNCE.x);
					pplipcehgnm.SetFloat("[itm=", this.GDCCBPNGNCE.y);
				}
				else
				{
					pplipcehgnm.SetTexture("firelamp", (Texture2D)Resources.Load("battlebond", typeof(Texture2D)));
				}
				pplipcehgnm.SetFloat("[ohko]", this.QNBFBLJCHDC);
				pplipcehgnm.SetFloat("rotom", this.NBJPJBEQKPI);
				pplipcehgnm.SetFloat("Hold or Use?", this.FJIKLOFOBBC);
				pplipcehgnm.SetFloat("17", this.GJEMMBBNGLB);
				pplipcehgnm.SetFloat("When another Pokémon uses a dance move, it can use a dance move following it regardless of its Speed.", this.LDBMOOIEBHP);
				pplipcehgnm.SetFloat("[FFFF00]/252", this.DMOLEJHGHCF);
				pplipcehgnm.SetFloat("ragepowder", this.LKFEFNKEFDH);
				pplipcehgnm.SetFloat("#,##0", this.PLDLQOMPMHB);
				pplipcehgnm.SetFloat("[7fff49]", this.GKOFGGEHFBM);
			}
		}
		if (this.MPHLLMKDQEF)
		{
			this.NNFMFGDPCPF.enabled = true;
			if (this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.None)
			{
				this.NNFMFGDPCPF.enabled = false;
			}
			else if (this.DPQFDCNLLPC == (HELQOJBMFOI.KNEJQBPFEON)7)
			{
				this.NNFMFGDPCPF.PPLIPCEHGNM.shader = Shader.Find("HidePanel");
				this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load(" shuddered!\r\n" + this.CIQFCJGQEMH + "Base Stats\n[d9b38c]ATK:[-] ", typeof(Texture));
				if (this.NNFMFGDPCPF.GOIHJQNMMJD == null)
				{
					this.NNFMFGDPCPF.enabled = true;
				}
			}
			else if (this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.None)
			{
				this.NNFMFGDPCPF.PPLIPCEHGNM.shader = Shader.Find("Map");
				if (this.HFDFIILFGBL)
				{
					this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load(" vanished instantly!\r\n" + this.CIQFCJGQEMH + "[", typeof(Texture));
				}
				else
				{
					this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load("The Pokémon shows moxie, and that boosts the Attack stat after knocking out any Pokémon." + this.CIQFCJGQEMH + "Immediate Mode GUI", typeof(Texture));
				}
				if (this.NNFMFGDPCPF.GOIHJQNMMJD == null)
				{
					this.NNFMFGDPCPF.enabled = true;
				}
			}
			if (this.GPJLQMFKNON)
			{
				this.QNBFBLJCHDC = 1893f;
			}
			else
			{
				this.QNBFBLJCHDC = 736f;
			}
			this.MPHLLMKDQEF = false;
		}
	}

	// Token: 0x06003116 RID: 12566 RVA: 0x00016013 File Offset: 0x00014213
	private void QOLNLDBHGJL()
	{
		this.NNFMFGDPCPF = base.GetComponent<JLMPBLMOICG>();
		this.NNFMFGDPCPF.PPLIPCEHGNM = new Material((Material)Resources.Load("[-]!\r\n", typeof(Material)));
	}

	// Token: 0x06003117 RID: 12567 RVA: 0x00172DCC File Offset: 0x00170FCC
	private void JOMCJOMCOIQ()
	{
		if (this.NNFMFGDPCPF != null && this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.None)
		{
			Material pplipcehgnm = this.NNFMFGDPCPF.PPLIPCEHGNM;
			if (pplipcehgnm != null)
			{
				if (this.MGJBMGMEGBF != null)
				{
					pplipcehgnm.SetTexture("Heals status conditions if it's raining.", this.MGJBMGMEGBF);
					pplipcehgnm.SetFloat("[-]!\r\n", this.HOOONLPEQOI.x);
					pplipcehgnm.SetFloat("p1", this.HOOONLPEQOI.y);
					pplipcehgnm.SetFloat("MSGBOX - ", this.GDCCBPNGNCE.x);
					pplipcehgnm.SetFloat("\n", this.GDCCBPNGNCE.y);
				}
				else
				{
					pplipcehgnm.SetTexture("'s ", (Texture2D)Resources.Load("ACC: -", typeof(Texture2D)));
				}
				pplipcehgnm.SetFloat("ReflecB", this.QNBFBLJCHDC);
				pplipcehgnm.SetFloat("Assets/AssetBundles/MapAssets2/Model Materials/WareHouses/t105_mado_mat.mat", this.NBJPJBEQKPI);
				pplipcehgnm.SetFloat("_Texture0", this.FJIKLOFOBBC);
				pplipcehgnm.SetFloat("Internal Curves Texture", this.GJEMMBBNGLB);
				pplipcehgnm.SetFloat("_Fade", this.LDBMOOIEBHP);
				pplipcehgnm.SetFloat("C", this.DMOLEJHGHCF);
				pplipcehgnm.SetFloat("School", this.LKFEFNKEFDH);
				pplipcehgnm.SetFloat("Frisk", this.PLDLQOMPMHB);
				pplipcehgnm.SetFloat("[FF8F00]", this.GKOFGGEHFBM);
			}
		}
		if (this.MPHLLMKDQEF)
		{
			this.NNFMFGDPCPF.enabled = true;
			if (this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.None)
			{
				this.NNFMFGDPCPF.enabled = false;
			}
			else if (this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.NPC)
			{
				this.NNFMFGDPCPF.PPLIPCEHGNM.shader = Shader.Find("[PD]");
				this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load("_Gain" + this.CIQFCJGQEMH + " ", typeof(Texture));
				if (this.NNFMFGDPCPF.GOIHJQNMMJD == null)
				{
					this.NNFMFGDPCPF.enabled = false;
				}
			}
			else if (this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.None)
			{
				this.NNFMFGDPCPF.PPLIPCEHGNM.shader = Shader.Find("X");
				if (this.HFDFIILFGBL)
				{
					this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load("BuffIcon_EggSpeedIncrease" + this.CIQFCJGQEMH + "-mega", typeof(Texture));
				}
				else
				{
					this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load("0" + this.CIQFCJGQEMH + "/", typeof(Texture));
				}
				if (this.NNFMFGDPCPF.GOIHJQNMMJD == null)
				{
					this.NNFMFGDPCPF.enabled = true;
				}
			}
			if (this.GPJLQMFKNON)
			{
				this.QNBFBLJCHDC = 1777f;
			}
			else
			{
				this.QNBFBLJCHDC = 170f;
			}
			this.MPHLLMKDQEF = true;
		}
	}

	// Token: 0x06003118 RID: 12568 RVA: 0x0001604A File Offset: 0x0001424A
	private void FOLBFDNJLII()
	{
		this.NNFMFGDPCPF = base.GetComponent<JLMPBLMOICG>();
		this.NNFMFGDPCPF.PPLIPCEHGNM = new Material((Material)Resources.Load("The mist disappeared from the battlefield.\r\n", typeof(Material)));
	}

	// Token: 0x06003119 RID: 12569 RVA: 0x00016081 File Offset: 0x00014281
	private void Awake()
	{
		this.NNFMFGDPCPF = base.GetComponent<JLMPBLMOICG>();
		this.NNFMFGDPCPF.PPLIPCEHGNM = new Material((Material)Resources.Load("GUIElements/New Battle/MonsterMaterial", typeof(Material)));
	}

	// Token: 0x0600311A RID: 12570 RVA: 0x00015EFF File Offset: 0x000140FF
	public void LKCMOQHGIID(int IKIJBQLMKJO, bool HFDFIILFGBL)
	{
		this.DPQFDCNLLPC = HELQOJBMFOI.KNEJQBPFEON.Monster;
		this.CIQFCJGQEMH = IKIJBQLMKJO;
		this.HFDFIILFGBL = HFDFIILFGBL;
		this.GPJLQMFKNON = true;
		this.MPHLLMKDQEF = false;
	}

	// Token: 0x0600311B RID: 12571 RVA: 0x000160B8 File Offset: 0x000142B8
	public void DPKGHFIHBPE(int IKIJBQLMKJO, bool HFDFIILFGBL)
	{
		this.DPQFDCNLLPC = HELQOJBMFOI.KNEJQBPFEON.Monster;
		this.CIQFCJGQEMH = IKIJBQLMKJO;
		this.HFDFIILFGBL = HFDFIILFGBL;
		this.GPJLQMFKNON = false;
		this.MPHLLMKDQEF = true;
	}

	// Token: 0x0600311C RID: 12572 RVA: 0x001730E0 File Offset: 0x001712E0
	private void OHQCMCDPHFI()
	{
		if (this.NNFMFGDPCPF != null && this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.Monster)
		{
			Material pplipcehgnm = this.NNFMFGDPCPF.PPLIPCEHGNM;
			if (pplipcehgnm != null)
			{
				if (this.MGJBMGMEGBF != null)
				{
					pplipcehgnm.SetTexture("Player/Body", this.MGJBMGMEGBF);
					pplipcehgnm.SetFloat("0", this.HOOONLPEQOI.x);
					pplipcehgnm.SetFloat("\n\n", this.HOOONLPEQOI.y);
					pplipcehgnm.SetFloat("frz", this.GDCCBPNGNCE.x);
					pplipcehgnm.SetFloat("[-]?", this.GDCCBPNGNCE.y);
				}
				else
				{
					pplipcehgnm.SetTexture("n", (Texture2D)Resources.Load("Zen Mode", typeof(Texture2D)));
				}
				pplipcehgnm.SetFloat("hail", this.QNBFBLJCHDC);
				pplipcehgnm.SetFloat("[PD]", this.NBJPJBEQKPI);
				pplipcehgnm.SetFloat("_1", this.FJIKLOFOBBC);
				pplipcehgnm.SetFloat("Bring It On!", this.GJEMMBBNGLB);
				pplipcehgnm.SetFloat("]", this.LDBMOOIEBHP);
				pplipcehgnm.SetFloat("Powers up Bug-type moves when the Pokémon's HP is low.", this.DMOLEJHGHCF);
				pplipcehgnm.SetFloat("charge", this.LKFEFNKEFDH);
				pplipcehgnm.SetFloat("[SUB]", this.PLDLQOMPMHB);
				pplipcehgnm.SetFloat("22 20\n22 26\n\n27 26\n27 30\n22 30\n22 26", this.GKOFGGEHFBM);
			}
		}
		if (this.MPHLLMKDQEF)
		{
			this.NNFMFGDPCPF.enabled = true;
			if (this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.None)
			{
				this.NNFMFGDPCPF.enabled = true;
			}
			else if (this.DPQFDCNLLPC == (HELQOJBMFOI.KNEJQBPFEON)8)
			{
				this.NNFMFGDPCPF.PPLIPCEHGNM.shader = Shader.Find("berry_10");
				this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load(" drastically" + this.CIQFCJGQEMH + "[/url]", typeof(Texture));
				if (this.NNFMFGDPCPF.GOIHJQNMMJD == null)
				{
					this.NNFMFGDPCPF.enabled = true;
				}
			}
			else if (this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.None)
			{
				this.NNFMFGDPCPF.PPLIPCEHGNM.shader = Shader.Find("[/o][-]");
				if (this.HFDFIILFGBL)
				{
					this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load("_" + this.CIQFCJGQEMH + " started heating up its beak!\r\n", typeof(Texture));
				}
				else
				{
					this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load("General" + this.CIQFCJGQEMH + "[CFX_SpawnSystem.GetNextObject()] There are no active instances available in the pool for \"", typeof(Texture));
				}
				if (this.NNFMFGDPCPF.GOIHJQNMMJD == null)
				{
					this.NNFMFGDPCPF.enabled = true;
				}
			}
			if (this.GPJLQMFKNON)
			{
				this.QNBFBLJCHDC = 1779f;
			}
			else
			{
				this.QNBFBLJCHDC = 1577f;
			}
			this.MPHLLMKDQEF = true;
		}
	}

	// Token: 0x0600311D RID: 12573 RVA: 0x001733F4 File Offset: 0x001715F4
	private void GKBQDQKLPIM()
	{
		if (this.NNFMFGDPCPF != null && this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.Monster)
		{
			Material pplipcehgnm = this.NNFMFGDPCPF.PPLIPCEHGNM;
			if (pplipcehgnm != null)
			{
				if (this.MGJBMGMEGBF != null)
				{
					pplipcehgnm.SetTexture("[-]!\r\n", this.MGJBMGMEGBF);
					pplipcehgnm.SetFloat("Egg", this.HOOONLPEQOI.x);
					pplipcehgnm.SetFloat("Protects the Pokémon from Defense-lowering effects.", this.HOOONLPEQOI.y);
					pplipcehgnm.SetFloat(" surrounds itself with a protective mist!\r\n", this.GDCCBPNGNCE.x);
					pplipcehgnm.SetFloat("][urn=", this.GDCCBPNGNCE.y);
				}
				else
				{
					pplipcehgnm.SetTexture("remember", (Texture2D)Resources.Load("Input - PMChat", typeof(Texture2D)));
				}
				pplipcehgnm.SetFloat("PrimitiveInnerRearLeft", this.QNBFBLJCHDC);
				pplipcehgnm.SetFloat("[itm=", this.NBJPJBEQKPI);
				pplipcehgnm.SetFloat("Stop", this.FJIKLOFOBBC);
				pplipcehgnm.SetFloat("CombinersColorScale", this.GJEMMBBNGLB);
				pplipcehgnm.SetFloat("´", this.LDBMOOIEBHP);
				pplipcehgnm.SetFloat("0", this.DMOLEJHGHCF);
				pplipcehgnm.SetFloat("--offline", this.LKFEFNKEFDH);
				pplipcehgnm.SetFloat(" snatched ", this.PLDLQOMPMHB);
				pplipcehgnm.SetFloat("SendMessage is bugged when you try to pass 'null' in the parameter field. It behaves as if no parameter was specified.", this.GKOFGGEHFBM);
			}
		}
		if (this.MPHLLMKDQEF)
		{
			this.NNFMFGDPCPF.enabled = false;
			if (this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.None)
			{
				this.NNFMFGDPCPF.enabled = false;
			}
			else if (this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.NPC)
			{
				this.NNFMFGDPCPF.PPLIPCEHGNM.shader = Shader.Find("!");
				this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load("\r\nSp. DEF" + this.CIQFCJGQEMH + " ", typeof(Texture));
				if (this.NNFMFGDPCPF.GOIHJQNMMJD == null)
				{
					this.NNFMFGDPCPF.enabled = false;
				}
			}
			else if (this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.Monster)
			{
				this.NNFMFGDPCPF.PPLIPCEHGNM.shader = Shader.Find("Script:");
				if (this.HFDFIILFGBL)
				{
					this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load("HH:mm:ss" + this.CIQFCJGQEMH + "][/itm]", typeof(Texture));
				}
				else
				{
					this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load("Player/Hair" + this.CIQFCJGQEMH + "Hidden/Post FX/Fog", typeof(Texture));
				}
				if (this.NNFMFGDPCPF.GOIHJQNMMJD == null)
				{
					this.NNFMFGDPCPF.enabled = true;
				}
			}
			if (this.GPJLQMFKNON)
			{
				this.QNBFBLJCHDC = 1313f;
			}
			else
			{
				this.QNBFBLJCHDC = 1959f;
			}
			this.MPHLLMKDQEF = false;
		}
	}

	// Token: 0x0600311E RID: 12574 RVA: 0x000160DD File Offset: 0x000142DD
	private void BCEKGNDIIOE()
	{
		this.NNFMFGDPCPF = base.GetComponent<JLMPBLMOICG>();
		this.NNFMFGDPCPF.PPLIPCEHGNM = new Material((Material)Resources.Load("Take 001", typeof(Material)));
	}

	// Token: 0x0600311F RID: 12575 RVA: 0x00016114 File Offset: 0x00014314
	public void IQHNOHEEKNQ(int IKIJBQLMKJO, bool HFDFIILFGBL)
	{
		this.DPQFDCNLLPC = HELQOJBMFOI.KNEJQBPFEON.Monster;
		this.CIQFCJGQEMH = IKIJBQLMKJO;
		this.HFDFIILFGBL = HFDFIILFGBL;
		this.GPJLQMFKNON = true;
		this.MPHLLMKDQEF = true;
	}

	// Token: 0x06003120 RID: 12576 RVA: 0x00016139 File Offset: 0x00014339
	private void LBIJFCFPKNM()
	{
		this.NNFMFGDPCPF = base.GetComponent<JLMPBLMOICG>();
		this.NNFMFGDPCPF.PPLIPCEHGNM = new Material((Material)Resources.Load("(B)", typeof(Material)));
	}

	// Token: 0x06003121 RID: 12577 RVA: 0x00173708 File Offset: 0x00171908
	private void NIIPIECJPOL()
	{
		if (this.NNFMFGDPCPF != null && this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.Monster)
		{
			Material pplipcehgnm = this.NNFMFGDPCPF.PPLIPCEHGNM;
			if (pplipcehgnm != null)
			{
				if (this.MGJBMGMEGBF != null)
				{
					pplipcehgnm.SetTexture("No Mapping For Pokemon", this.MGJBMGMEGBF);
					pplipcehgnm.SetFloat(" type!\r\n", this.HOOONLPEQOI.x);
					pplipcehgnm.SetFloat("Male Pokemon Rate Increased.\nTriggers: [2ecc71]Cute Charm[-]", this.HOOONLPEQOI.y);
					pplipcehgnm.SetFloat("The mysterious strong winds blow on regardless!\r\n", this.GDCCBPNGNCE.x);
					pplipcehgnm.SetFloat("_Dissolve", this.GDCCBPNGNCE.y);
				}
				else
				{
					pplipcehgnm.SetTexture("[00EE07]", (Texture2D)Resources.Load("You left the Party.", typeof(Texture2D)));
				}
				pplipcehgnm.SetFloat("_FogPointLightPosition4", this.QNBFBLJCHDC);
				pplipcehgnm.SetFloat("NPC", this.NBJPJBEQKPI);
				pplipcehgnm.SetFloat("]", this.FJIKLOFOBBC);
				pplipcehgnm.SetFloat("Base Stats\n[d9b38c]ATK:[-] ", this.GJEMMBBNGLB);
				pplipcehgnm.SetFloat(" not found in the Rooms list.", this.LDBMOOIEBHP);
				pplipcehgnm.SetFloat("Packed", this.DMOLEJHGHCF);
				pplipcehgnm.SetFloat("Glacier Badge", this.LKFEFNKEFDH);
				pplipcehgnm.SetFloat("]", this.PLDLQOMPMHB);
				pplipcehgnm.SetFloat("Popup list needs a source object...", this.GKOFGGEHFBM);
			}
		}
		if (this.MPHLLMKDQEF)
		{
			this.NNFMFGDPCPF.enabled = true;
			if (this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.None)
			{
				this.NNFMFGDPCPF.enabled = false;
			}
			else if (this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.None)
			{
				this.NNFMFGDPCPF.PPLIPCEHGNM.shader = Shader.Find("]");
				this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load("Powers up Water-type moves when the Pokémon's HP is low." + this.CIQFCJGQEMH + "FOG_VOID_BOX", typeof(Texture));
				if (this.NNFMFGDPCPF.GOIHJQNMMJD == null)
				{
					this.NNFMFGDPCPF.enabled = true;
				}
			}
			else if (this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.Monster)
			{
				this.NNFMFGDPCPF.PPLIPCEHGNM.shader = Shader.Find(", disabled controller");
				if (this.HFDFIILFGBL)
				{
					this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load("game3.poke.one" + this.CIQFCJGQEMH + " was subjected to torment!\r\n", typeof(Texture));
				}
				else
				{
					this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load("wishiwashischool" + this.CIQFCJGQEMH + "[-]?\n\nOnce you do this, it will be lost forever.", typeof(Texture));
				}
				if (this.NNFMFGDPCPF.GOIHJQNMMJD == null)
				{
					this.NNFMFGDPCPF.enabled = true;
				}
			}
			if (this.GPJLQMFKNON)
			{
				this.QNBFBLJCHDC = 600f;
			}
			else
			{
				this.QNBFBLJCHDC = 404f;
			}
			this.MPHLLMKDQEF = true;
		}
	}

	// Token: 0x06003122 RID: 12578 RVA: 0x00173A1C File Offset: 0x00171C1C
	private void QDIKKLMCIJK()
	{
		if (this.NNFMFGDPCPF != null && this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.None)
		{
			Material pplipcehgnm = this.NNFMFGDPCPF.PPLIPCEHGNM;
			if (pplipcehgnm != null)
			{
				if (this.MGJBMGMEGBF != null)
				{
					pplipcehgnm.SetTexture("_TileVRT", this.MGJBMGMEGBF);
					pplipcehgnm.SetFloat("You used Dig recently and are unable to use it again.", this.HOOONLPEQOI.x);
					pplipcehgnm.SetFloat("[/C]", this.HOOONLPEQOI.y);
					pplipcehgnm.SetFloat(" cured its paralysis!\r\n", this.GDCCBPNGNCE.x);
					pplipcehgnm.SetFloat("burmy", this.GDCCBPNGNCE.y);
				}
				else
				{
					pplipcehgnm.SetTexture("/01_", (Texture2D)Resources.Load("CombinersColorPassThrough", typeof(Texture2D)));
				}
				pplipcehgnm.SetFloat("Create Guild", this.QNBFBLJCHDC);
				pplipcehgnm.SetFloat("#,##0", this.NBJPJBEQKPI);
				pplipcehgnm.SetFloat("ability", this.FJIKLOFOBBC);
				pplipcehgnm.SetFloat("R", this.GJEMMBBNGLB);
				pplipcehgnm.SetFloat("The Water-type attack evaporated in the harsh sunlight!\r\n", this.LDBMOOIEBHP);
				pplipcehgnm.SetFloat("Contact with the Pokémon may inflict poison, sleep, or paralysis on its attacker.", this.DMOLEJHGHCF);
				pplipcehgnm.SetFloat("<|>", this.LKFEFNKEFDH);
				pplipcehgnm.SetFloat("magiccoat", this.PLDLQOMPMHB);
				pplipcehgnm.SetFloat("Your account is Temporarily Suspended.", this.GKOFGGEHFBM);
			}
		}
		if (this.MPHLLMKDQEF)
		{
			this.NNFMFGDPCPF.enabled = false;
			if (this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.None)
			{
				this.NNFMFGDPCPF.enabled = false;
			}
			else if (this.DPQFDCNLLPC == (HELQOJBMFOI.KNEJQBPFEON)3)
			{
				this.NNFMFGDPCPF.PPLIPCEHGNM.shader = Shader.Find("special");
				this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load("inven " + this.CIQFCJGQEMH + "M5", typeof(Texture));
				if (this.NNFMFGDPCPF.GOIHJQNMMJD == null)
				{
					this.NNFMFGDPCPF.enabled = false;
				}
			}
			else if (this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.Monster)
			{
				this.NNFMFGDPCPF.PPLIPCEHGNM.shader = Shader.Find("Clicked Item: ");
				if (this.HFDFIILFGBL)
				{
					this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load("[ffff00]Wide Guard[-] protected " + this.CIQFCJGQEMH + "Player/Hair", typeof(Texture));
				}
				else
				{
					this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load("Hold or Use?" + this.CIQFCJGQEMH + "Music", typeof(Texture));
				}
				if (this.NNFMFGDPCPF.GOIHJQNMMJD == null)
				{
					this.NNFMFGDPCPF.enabled = true;
				}
			}
			if (this.GPJLQMFKNON)
			{
				this.QNBFBLJCHDC = 624f;
			}
			else
			{
				this.QNBFBLJCHDC = 1295f;
			}
			this.MPHLLMKDQEF = false;
		}
	}

	// Token: 0x06003123 RID: 12579 RVA: 0x00016170 File Offset: 0x00014370
	public void QNNKNPMDQBN(int IKIJBQLMKJO, bool HFDFIILFGBL)
	{
		this.DPQFDCNLLPC = HELQOJBMFOI.KNEJQBPFEON.None;
		this.CIQFCJGQEMH = IKIJBQLMKJO;
		this.HFDFIILFGBL = HFDFIILFGBL;
		this.GPJLQMFKNON = true;
		this.MPHLLMKDQEF = false;
	}

	// Token: 0x06003124 RID: 12580 RVA: 0x000160B8 File Offset: 0x000142B8
	public void IEBPHFKBDFB(int IKIJBQLMKJO, bool HFDFIILFGBL)
	{
		this.DPQFDCNLLPC = HELQOJBMFOI.KNEJQBPFEON.Monster;
		this.CIQFCJGQEMH = IKIJBQLMKJO;
		this.HFDFIILFGBL = HFDFIILFGBL;
		this.GPJLQMFKNON = false;
		this.MPHLLMKDQEF = true;
	}

	// Token: 0x06003125 RID: 12581 RVA: 0x00173D30 File Offset: 0x00171F30
	private void BJFCILIPEMI()
	{
		if (this.NNFMFGDPCPF != null && this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.None)
		{
			Material pplipcehgnm = this.NNFMFGDPCPF.PPLIPCEHGNM;
			if (pplipcehgnm != null)
			{
				if (this.MGJBMGMEGBF != null)
				{
					pplipcehgnm.SetTexture("magician", this.MGJBMGMEGBF);
					pplipcehgnm.SetFloat("default", this.HOOONLPEQOI.x);
					pplipcehgnm.SetFloat("desolateland", this.HOOONLPEQOI.y);
					pplipcehgnm.SetFloat("|", this.GDCCBPNGNCE.x);
					pplipcehgnm.SetFloat("[-] weakened the damage to ", this.GDCCBPNGNCE.y);
				}
				else
				{
					pplipcehgnm.SetTexture("p", (Texture2D)Resources.Load("Remove Item", typeof(Texture2D)));
				}
				pplipcehgnm.SetFloat("Left Chat Channel: ", this.QNBFBLJCHDC);
				pplipcehgnm.SetFloat("The Pokémon only takes damage from attacks.", this.NBJPJBEQKPI);
				pplipcehgnm.SetFloat("p", this.FJIKLOFOBBC);
				pplipcehgnm.SetFloat("r", this.GJEMMBBNGLB);
				pplipcehgnm.SetFloat("_MainTex", this.LDBMOOIEBHP);
				pplipcehgnm.SetFloat("UpdateTime", this.DMOLEJHGHCF);
				pplipcehgnm.SetFloat("\n", this.LKFEFNKEFDH);
				pplipcehgnm.SetFloat(" minutes", this.PLDLQOMPMHB);
				pplipcehgnm.SetFloat("BuffIcon_SandstormEncounterDecreased", this.GKOFGGEHFBM);
			}
		}
		if (this.MPHLLMKDQEF)
		{
			this.NNFMFGDPCPF.enabled = false;
			if (this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.None)
			{
				this.NNFMFGDPCPF.enabled = true;
			}
			else if (this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.Monster)
			{
				this.NNFMFGDPCPF.PPLIPCEHGNM.shader = Shader.Find("Assets/AssetBundles/MapAssets/Model Materials/Light_Gym_Inner_Light.mat");
				this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load("Synchronize" + this.CIQFCJGQEMH + "AI", typeof(Texture));
				if (this.NNFMFGDPCPF.GOIHJQNMMJD == null)
				{
					this.NNFMFGDPCPF.enabled = false;
				}
			}
			else if (this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.Monster)
			{
				this.NNFMFGDPCPF.PPLIPCEHGNM.shader = Shader.Find(" was cured of paralysis.\r\n");
				if (this.HFDFIILFGBL)
				{
					this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load("Purchase Costume" + this.CIQFCJGQEMH + "\n\n[2ecc71]Right Click to Cancel this Buff.[-]", typeof(Texture));
				}
				else
				{
					this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load(" protected itself!\r\n" + this.CIQFCJGQEMH + "_", typeof(Texture));
				}
				if (this.NNFMFGDPCPF.GOIHJQNMMJD == null)
				{
					this.NNFMFGDPCPF.enabled = false;
				}
			}
			if (this.GPJLQMFKNON)
			{
				this.QNBFBLJCHDC = 1437f;
			}
			else
			{
				this.QNBFBLJCHDC = 1709f;
			}
			this.MPHLLMKDQEF = false;
		}
	}

	// Token: 0x06003126 RID: 12582 RVA: 0x00016114 File Offset: 0x00014314
	public void LICGGEICOGH(int IKIJBQLMKJO, bool HFDFIILFGBL)
	{
		this.DPQFDCNLLPC = HELQOJBMFOI.KNEJQBPFEON.Monster;
		this.CIQFCJGQEMH = IKIJBQLMKJO;
		this.HFDFIILFGBL = HFDFIILFGBL;
		this.GPJLQMFKNON = true;
		this.MPHLLMKDQEF = true;
	}

	// Token: 0x06003127 RID: 12583 RVA: 0x00016195 File Offset: 0x00014395
	private void BBKNQONEBJB()
	{
		this.NNFMFGDPCPF = base.GetComponent<JLMPBLMOICG>();
		this.NNFMFGDPCPF.PPLIPCEHGNM = new Material((Material)Resources.Load("'s [ffff00]", typeof(Material)));
	}

	// Token: 0x06003128 RID: 12584 RVA: 0x00174044 File Offset: 0x00172244
	private void DLBNQMKQILC()
	{
		if (this.NNFMFGDPCPF != null && this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.Monster)
		{
			Material pplipcehgnm = this.NNFMFGDPCPF.PPLIPCEHGNM;
			if (pplipcehgnm != null)
			{
				if (this.MGJBMGMEGBF != null)
				{
					pplipcehgnm.SetTexture("OnPress", this.MGJBMGMEGBF);
					pplipcehgnm.SetFloat("/01_", this.HOOONLPEQOI.x);
					pplipcehgnm.SetFloat("door_5", this.HOOONLPEQOI.y);
					pplipcehgnm.SetFloat("[-] has gone offline.", this.GDCCBPNGNCE.x);
					pplipcehgnm.SetFloat("Icon_Pokemon_Alive", this.GDCCBPNGNCE.y);
				}
				else
				{
					pplipcehgnm.SetTexture("dive", (Texture2D)Resources.Load("16", typeof(Texture2D)));
				}
				pplipcehgnm.SetFloat("Motor Drive", this.QNBFBLJCHDC);
				pplipcehgnm.SetFloat("CombinersArgsColorOp0", this.NBJPJBEQKPI);
				pplipcehgnm.SetFloat("hydration", this.FJIKLOFOBBC);
				pplipcehgnm.SetFloat("K2", this.GJEMMBBNGLB);
				pplipcehgnm.SetFloat("flowerveil", this.LDBMOOIEBHP);
				pplipcehgnm.SetFloat("blank", this.DMOLEJHGHCF);
				pplipcehgnm.SetFloat("skinshop", this.LKFEFNKEFDH);
				pplipcehgnm.SetFloat("[PG]", this.PLDLQOMPMHB);
				pplipcehgnm.SetFloat("mistyterrain", this.GKOFGGEHFBM);
			}
		}
		if (this.MPHLLMKDQEF)
		{
			this.NNFMFGDPCPF.enabled = false;
			if (this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.None)
			{
				this.NNFMFGDPCPF.enabled = false;
			}
			else if (this.DPQFDCNLLPC == (HELQOJBMFOI.KNEJQBPFEON)5)
			{
				this.NNFMFGDPCPF.PPLIPCEHGNM.shader = Shader.Find("ShiftS");
				this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load("]" + this.CIQFCJGQEMH + "Inactive", typeof(Texture));
				if (this.NNFMFGDPCPF.GOIHJQNMMJD == null)
				{
					this.NNFMFGDPCPF.enabled = false;
				}
			}
			else if (this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.Monster)
			{
				this.NNFMFGDPCPF.PPLIPCEHGNM.shader = Shader.Find("Selection: ");
				if (this.HFDFIILFGBL)
				{
					this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load(" is ready to help " + this.CIQFCJGQEMH + " shared its ", typeof(Texture));
				}
				else
				{
					this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load("3" + this.CIQFCJGQEMH + "Vertical", typeof(Texture));
				}
				if (this.NNFMFGDPCPF.GOIHJQNMMJD == null)
				{
					this.NNFMFGDPCPF.enabled = true;
				}
			}
			if (this.GPJLQMFKNON)
			{
				this.QNBFBLJCHDC = 1204f;
			}
			else
			{
				this.QNBFBLJCHDC = 258f;
			}
			this.MPHLLMKDQEF = false;
		}
	}

	// Token: 0x06003129 RID: 12585 RVA: 0x000161CC File Offset: 0x000143CC
	private void QIKFOCKCGKL()
	{
		this.NNFMFGDPCPF = base.GetComponent<JLMPBLMOICG>();
		this.NNFMFGDPCPF.PPLIPCEHGNM = new Material((Material)Resources.Load("Assets/AssetBundles/MapAssets/Models/Materials/com_chip_mado1.mat", typeof(Material)));
	}

	// Token: 0x0600312A RID: 12586 RVA: 0x00015F5B File Offset: 0x0001415B
	public void POIIJBEJHHH(int IKIJBQLMKJO, bool HFDFIILFGBL)
	{
		this.DPQFDCNLLPC = HELQOJBMFOI.KNEJQBPFEON.Monster;
		this.CIQFCJGQEMH = IKIJBQLMKJO;
		this.HFDFIILFGBL = HFDFIILFGBL;
		this.GPJLQMFKNON = false;
		this.MPHLLMKDQEF = false;
	}

	// Token: 0x0600312B RID: 12587 RVA: 0x00016203 File Offset: 0x00014403
	public void PODJNDCBJJO(int IKIJBQLMKJO, bool HFDFIILFGBL)
	{
		this.DPQFDCNLLPC = HELQOJBMFOI.KNEJQBPFEON.None;
		this.CIQFCJGQEMH = IKIJBQLMKJO;
		this.HFDFIILFGBL = HFDFIILFGBL;
		this.GPJLQMFKNON = false;
		this.MPHLLMKDQEF = false;
	}

	// Token: 0x0600312C RID: 12588 RVA: 0x00174358 File Offset: 0x00172558
	private void KNFDIHBNPNG()
	{
		if (this.NNFMFGDPCPF != null && this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.Monster)
		{
			Material pplipcehgnm = this.NNFMFGDPCPF.PPLIPCEHGNM;
			if (pplipcehgnm != null)
			{
				if (this.MGJBMGMEGBF != null)
				{
					pplipcehgnm.SetTexture("_FogHeightData", this.MGJBMGMEGBF);
					pplipcehgnm.SetFloat("[ffdb4d]Trade", this.HOOONLPEQOI.x);
					pplipcehgnm.SetFloat("Right", this.HOOONLPEQOI.y);
					pplipcehgnm.SetFloat("_FogPointLightPosition0", this.GDCCBPNGNCE.x);
					pplipcehgnm.SetFloat("The sandstorm subsided.", this.GDCCBPNGNCE.y);
				}
				else
				{
					pplipcehgnm.SetTexture("burmysandy", (Texture2D)Resources.Load("#,##0", typeof(Texture2D)));
				}
				pplipcehgnm.SetFloat("_SunColor", this.QNBFBLJCHDC);
				pplipcehgnm.SetFloat(" hung on using its [ffff00]Focus Band[-]!\r\n", this.NBJPJBEQKPI);
				pplipcehgnm.SetFloat("battlearmor", this.FJIKLOFOBBC);
				pplipcehgnm.SetFloat("Water", this.GJEMMBBNGLB);
				pplipcehgnm.SetFloat(",0+", this.LDBMOOIEBHP);
				pplipcehgnm.SetFloat("_Histogram", this.DMOLEJHGHCF);
				pplipcehgnm.SetFloat("(E)", this.LKFEFNKEFDH);
				pplipcehgnm.SetFloat("Egg", this.PLDLQOMPMHB);
				pplipcehgnm.SetFloat(" Members Online.", this.GKOFGGEHFBM);
			}
		}
		if (this.MPHLLMKDQEF)
		{
			this.NNFMFGDPCPF.enabled = false;
			if (this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.None)
			{
				this.NNFMFGDPCPF.enabled = false;
			}
			else if (this.DPQFDCNLLPC == (HELQOJBMFOI.KNEJQBPFEON)3)
			{
				this.NNFMFGDPCPF.PPLIPCEHGNM.shader = Shader.Find("^emote+");
				this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load(" will restore its replacement's HP using its Z-Power!\r\n" + this.CIQFCJGQEMH + "sound(", typeof(Texture));
				if (this.NNFMFGDPCPF.GOIHJQNMMJD == null)
				{
					this.NNFMFGDPCPF.enabled = true;
				}
			}
			else if (this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.None)
			{
				this.NNFMFGDPCPF.PPLIPCEHGNM.shader = Shader.Find("[/pok]");
				if (this.HFDFIILFGBL)
				{
					this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load("The trade with '" + this.CIQFCJGQEMH + "gravity", typeof(Texture));
				}
				else
				{
					this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load("[00]" + this.CIQFCJGQEMH + "'s perish count fell to 1.\r\n", typeof(Texture));
				}
				if (this.NNFMFGDPCPF.GOIHJQNMMJD == null)
				{
					this.NNFMFGDPCPF.enabled = true;
				}
			}
			if (this.GPJLQMFKNON)
			{
				this.QNBFBLJCHDC = 1836f;
			}
			else
			{
				this.QNBFBLJCHDC = 1349f;
			}
			this.MPHLLMKDQEF = false;
		}
	}

	// Token: 0x0600312D RID: 12589 RVA: 0x00016170 File Offset: 0x00014370
	public void JBIQQFFPJOB(int IKIJBQLMKJO, bool HFDFIILFGBL)
	{
		this.DPQFDCNLLPC = HELQOJBMFOI.KNEJQBPFEON.None;
		this.CIQFCJGQEMH = IKIJBQLMKJO;
		this.HFDFIILFGBL = HFDFIILFGBL;
		this.GPJLQMFKNON = true;
		this.MPHLLMKDQEF = false;
	}

	// Token: 0x0600312E RID: 12590 RVA: 0x00015F5B File Offset: 0x0001415B
	public void HOQCQIPBFMC(int IKIJBQLMKJO, bool HFDFIILFGBL)
	{
		this.DPQFDCNLLPC = HELQOJBMFOI.KNEJQBPFEON.Monster;
		this.CIQFCJGQEMH = IKIJBQLMKJO;
		this.HFDFIILFGBL = HFDFIILFGBL;
		this.GPJLQMFKNON = false;
		this.MPHLLMKDQEF = false;
	}

	// Token: 0x0600312F RID: 12591 RVA: 0x00015EDA File Offset: 0x000140DA
	public void BBPLKQMHCBL(int IKIJBQLMKJO, bool HFDFIILFGBL)
	{
		this.DPQFDCNLLPC = HELQOJBMFOI.KNEJQBPFEON.None;
		this.CIQFCJGQEMH = IKIJBQLMKJO;
		this.HFDFIILFGBL = HFDFIILFGBL;
		this.GPJLQMFKNON = false;
		this.MPHLLMKDQEF = true;
	}

	// Token: 0x06003130 RID: 12592 RVA: 0x0017466C File Offset: 0x0017286C
	private void Update()
	{
		if (this.NNFMFGDPCPF != null && this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.Monster)
		{
			Material pplipcehgnm = this.NNFMFGDPCPF.PPLIPCEHGNM;
			if (pplipcehgnm != null)
			{
				if (this.MGJBMGMEGBF != null)
				{
					pplipcehgnm.SetTexture("_Detail", this.MGJBMGMEGBF);
					pplipcehgnm.SetFloat("_DetailOffsetX", this.HOOONLPEQOI.x);
					pplipcehgnm.SetFloat("_DetailOffsetY", this.HOOONLPEQOI.y);
					pplipcehgnm.SetFloat("_DetailScaleX", this.GDCCBPNGNCE.x);
					pplipcehgnm.SetFloat("_DetailScaleY", this.GDCCBPNGNCE.y);
				}
				else
				{
					pplipcehgnm.SetTexture("_Detail", (Texture2D)Resources.Load("gray", typeof(Texture2D)));
				}
				pplipcehgnm.SetFloat("_Saturation", this.QNBFBLJCHDC);
				pplipcehgnm.SetFloat("_Contrast", this.NBJPJBEQKPI);
				pplipcehgnm.SetFloat("_Noise", this.FJIKLOFOBBC);
				pplipcehgnm.SetFloat("_NoisePixels", this.GJEMMBBNGLB);
				pplipcehgnm.SetFloat("_DestortionAmplitude", this.LDBMOOIEBHP);
				pplipcehgnm.SetFloat("_DestortionX", this.DMOLEJHGHCF);
				pplipcehgnm.SetFloat("_DestortionY", this.LKFEFNKEFDH);
				pplipcehgnm.SetFloat("_DestortionShiftX", this.PLDLQOMPMHB);
				pplipcehgnm.SetFloat("_DestortionShiftY", this.GKOFGGEHFBM);
			}
		}
		if (this.MPHLLMKDQEF)
		{
			this.NNFMFGDPCPF.enabled = true;
			if (this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.None)
			{
				this.NNFMFGDPCPF.enabled = false;
			}
			else if (this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.NPC)
			{
				this.NNFMFGDPCPF.PPLIPCEHGNM.shader = Shader.Find("Unlit/Transparent Colored");
				this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load("NPC/" + this.CIQFCJGQEMH + "b", typeof(Texture));
				if (this.NNFMFGDPCPF.GOIHJQNMMJD == null)
				{
					this.NNFMFGDPCPF.enabled = false;
				}
			}
			else if (this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.Monster)
			{
				this.NNFMFGDPCPF.PPLIPCEHGNM.shader = Shader.Find("HTE/Battle Monster Shader");
				if (this.HFDFIILFGBL)
				{
					this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load("Monsters/" + this.CIQFCJGQEMH + "/4", typeof(Texture));
				}
				else
				{
					this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load("Monsters/" + this.CIQFCJGQEMH + "/3", typeof(Texture));
				}
				if (this.NNFMFGDPCPF.GOIHJQNMMJD == null)
				{
					this.NNFMFGDPCPF.enabled = false;
				}
			}
			if (this.GPJLQMFKNON)
			{
				this.QNBFBLJCHDC = 0f;
			}
			else
			{
				this.QNBFBLJCHDC = 1f;
			}
			this.MPHLLMKDQEF = false;
		}
	}

	// Token: 0x06003132 RID: 12594 RVA: 0x00016228 File Offset: 0x00014428
	private void LFJEJGOMLPI()
	{
		this.NNFMFGDPCPF = base.GetComponent<JLMPBLMOICG>();
		this.NNFMFGDPCPF.PPLIPCEHGNM = new Material((Material)Resources.Load(" needs the 'Root For Bounds' parameter to be set", typeof(Material)));
	}

	// Token: 0x06003133 RID: 12595 RVA: 0x000160B8 File Offset: 0x000142B8
	public void MKOLLNJBGQL(int IKIJBQLMKJO, bool HFDFIILFGBL)
	{
		this.DPQFDCNLLPC = HELQOJBMFOI.KNEJQBPFEON.Monster;
		this.CIQFCJGQEMH = IKIJBQLMKJO;
		this.HFDFIILFGBL = HFDFIILFGBL;
		this.GPJLQMFKNON = false;
		this.MPHLLMKDQEF = true;
	}

	// Token: 0x06003134 RID: 12596 RVA: 0x00015EDA File Offset: 0x000140DA
	public void LCDKHIBJKGO(int IKIJBQLMKJO, bool HFDFIILFGBL)
	{
		this.DPQFDCNLLPC = HELQOJBMFOI.KNEJQBPFEON.None;
		this.CIQFCJGQEMH = IKIJBQLMKJO;
		this.HFDFIILFGBL = HFDFIILFGBL;
		this.GPJLQMFKNON = false;
		this.MPHLLMKDQEF = true;
	}

	// Token: 0x06003135 RID: 12597 RVA: 0x001749DC File Offset: 0x00172BDC
	private void DHDCOBNGJDL()
	{
		if (this.NNFMFGDPCPF != null && this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.None)
		{
			Material pplipcehgnm = this.NNFMFGDPCPF.PPLIPCEHGNM;
			if (pplipcehgnm != null)
			{
				if (this.MGJBMGMEGBF != null)
				{
					pplipcehgnm.SetTexture("AlwaysRain", this.MGJBMGMEGBF);
					pplipcehgnm.SetFloat("Big/", this.HOOONLPEQOI.x);
					pplipcehgnm.SetFloat("stormdrain", this.HOOONLPEQOI.y);
					pplipcehgnm.SetFloat("item", this.GDCCBPNGNCE.x);
					pplipcehgnm.SetFloat(" fell for the taunt!\r\n", this.GDCCBPNGNCE.y);
				}
				else
				{
					pplipcehgnm.SetTexture("Fly can be used to travel to significant places you have visited.\n\n[2ecc71]Left Click to use this.[-]", (Texture2D)Resources.Load("[33CCFF]Escape Stone[-]\n\nUsing this will return you to your last Pokecenter, at the same cost as fainting in battle.\n[00AA00]Cooldown Remaining: -[-]", typeof(Texture2D)));
				}
				pplipcehgnm.SetFloat(" minutes ago", this.QNBFBLJCHDC);
				pplipcehgnm.SetFloat("System", this.NBJPJBEQKPI);
				pplipcehgnm.SetFloat("reflecttype", this.FJIKLOFOBBC);
				pplipcehgnm.SetFloat("i", this.GJEMMBBNGLB);
				pplipcehgnm.SetFloat("System", this.LDBMOOIEBHP);
				pplipcehgnm.SetFloat("guild", this.DMOLEJHGHCF);
				pplipcehgnm.SetFloat("Chances of finding a wild Pokémon holding an item increased.\nTriggers: [2ecc71]Compound Eyes[-]", this.LKFEFNKEFDH);
				pplipcehgnm.SetFloat("'s [ffff00]", this.PLDLQOMPMHB);
				pplipcehgnm.SetFloat("'s [ffff00]", this.GKOFGGEHFBM);
			}
		}
		if (this.MPHLLMKDQEF)
		{
			this.NNFMFGDPCPF.enabled = false;
			if (this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.None)
			{
				this.NNFMFGDPCPF.enabled = true;
			}
			else if (this.DPQFDCNLLPC == (HELQOJBMFOI.KNEJQBPFEON)6)
			{
				this.NNFMFGDPCPF.PPLIPCEHGNM.shader = Shader.Find("-1");
				this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load("\nAccuracy: " + this.CIQFCJGQEMH + "[{", typeof(Texture));
				if (this.NNFMFGDPCPF.GOIHJQNMMJD == null)
				{
					this.NNFMFGDPCPF.enabled = false;
				}
			}
			else if (this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.Monster)
			{
				this.NNFMFGDPCPF.PPLIPCEHGNM.shader = Shader.Find("[EOL]");
				if (this.HFDFIILFGBL)
				{
					this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load("status" + this.CIQFCJGQEMH + "_HueShift", typeof(Texture));
				}
				else
				{
					this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load("firespin" + this.CIQFCJGQEMH + "´", typeof(Texture));
				}
				if (this.NNFMFGDPCPF.GOIHJQNMMJD == null)
				{
					this.NNFMFGDPCPF.enabled = true;
				}
			}
			if (this.GPJLQMFKNON)
			{
				this.QNBFBLJCHDC = 427f;
			}
			else
			{
				this.QNBFBLJCHDC = 1603f;
			}
			this.MPHLLMKDQEF = true;
		}
	}

	// Token: 0x06003136 RID: 12598 RVA: 0x00016114 File Offset: 0x00014314
	public void LCINJBEOQEH(int IKIJBQLMKJO, bool HFDFIILFGBL)
	{
		this.DPQFDCNLLPC = HELQOJBMFOI.KNEJQBPFEON.Monster;
		this.CIQFCJGQEMH = IKIJBQLMKJO;
		this.HFDFIILFGBL = HFDFIILFGBL;
		this.GPJLQMFKNON = true;
		this.MPHLLMKDQEF = true;
	}

	// Token: 0x06003137 RID: 12599 RVA: 0x00015EFF File Offset: 0x000140FF
	public void EJDGBOFHIBJ(int IKIJBQLMKJO, bool HFDFIILFGBL)
	{
		this.DPQFDCNLLPC = HELQOJBMFOI.KNEJQBPFEON.Monster;
		this.CIQFCJGQEMH = IKIJBQLMKJO;
		this.HFDFIILFGBL = HFDFIILFGBL;
		this.GPJLQMFKNON = true;
		this.MPHLLMKDQEF = false;
	}

	// Token: 0x06003138 RID: 12600 RVA: 0x00174CF0 File Offset: 0x00172EF0
	private void OBNDQJFDQEK()
	{
		if (this.NNFMFGDPCPF != null && this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.Monster)
		{
			Material pplipcehgnm = this.NNFMFGDPCPF.PPLIPCEHGNM;
			if (pplipcehgnm != null)
			{
				if (this.MGJBMGMEGBF != null)
				{
					pplipcehgnm.SetTexture("A deluge of ions showers the battlefield!\r\n", this.MGJBMGMEGBF);
					pplipcehgnm.SetFloat("Attempting to remove a RenderTexture that was not allocated: {0}", this.HOOONLPEQOI.x);
					pplipcehgnm.SetFloat("Oozed liquid has strong stench, which damages attackers using any draining move.", this.HOOONLPEQOI.y);
					pplipcehgnm.SetFloat(" clip regions", this.GDCCBPNGNCE.x);
					pplipcehgnm.SetFloat("Localization", this.GDCCBPNGNCE.y);
				}
				else
				{
					pplipcehgnm.SetTexture("[-]!\r\n", (Texture2D)Resources.Load(" ", typeof(Texture2D)));
				}
				pplipcehgnm.SetFloat("!\r\n", this.QNBFBLJCHDC);
				pplipcehgnm.SetFloat("Login Error", this.NBJPJBEQKPI);
				pplipcehgnm.SetFloat("/", this.FJIKLOFOBBC);
				pplipcehgnm.SetFloat("perish2", this.GJEMMBBNGLB);
				pplipcehgnm.SetFloat(" intends to flip up a mat and block incoming attacks!\r\n", this.LDBMOOIEBHP);
				pplipcehgnm.SetFloat("Run", this.DMOLEJHGHCF);
				pplipcehgnm.SetFloat("Guild Request", this.LKFEFNKEFDH);
				pplipcehgnm.SetFloat("[-]!\r\n", this.PLDLQOMPMHB);
				pplipcehgnm.SetFloat("#,##0", this.GKOFGGEHFBM);
			}
		}
		if (this.MPHLLMKDQEF)
		{
			this.NNFMFGDPCPF.enabled = true;
			if (this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.None)
			{
				this.NNFMFGDPCPF.enabled = true;
			}
			else if (this.DPQFDCNLLPC == (HELQOJBMFOI.KNEJQBPFEON)6)
			{
				this.NNFMFGDPCPF.PPLIPCEHGNM.shader = Shader.Find("Down");
				this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load("sandstream" + this.CIQFCJGQEMH + "\r\n", typeof(Texture));
				if (this.NNFMFGDPCPF.GOIHJQNMMJD == null)
				{
					this.NNFMFGDPCPF.enabled = false;
				}
			}
			else if (this.DPQFDCNLLPC == HELQOJBMFOI.KNEJQBPFEON.Monster)
			{
				this.NNFMFGDPCPF.PPLIPCEHGNM.shader = Shader.Find("M3");
				if (this.HFDFIILFGBL)
				{
					this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load("Mana increases the number of spells that can be cast" + this.CIQFCJGQEMH + "#,##0", typeof(Texture));
				}
				else
				{
					this.NNFMFGDPCPF.GOIHJQNMMJD = (Texture)Resources.Load("longreach" + this.CIQFCJGQEMH + "charge", typeof(Texture));
				}
				if (this.NNFMFGDPCPF.GOIHJQNMMJD == null)
				{
					this.NNFMFGDPCPF.enabled = false;
				}
			}
			if (this.GPJLQMFKNON)
			{
				this.QNBFBLJCHDC = 420f;
			}
			else
			{
				this.QNBFBLJCHDC = 826f;
			}
			this.MPHLLMKDQEF = false;
		}
	}

	// Token: 0x04000B64 RID: 2916
	public HELQOJBMFOI.KNEJQBPFEON DPQFDCNLLPC;

	// Token: 0x04000B65 RID: 2917
	public int CIQFCJGQEMH;

	// Token: 0x04000B66 RID: 2918
	public bool HFDFIILFGBL;

	// Token: 0x04000B67 RID: 2919
	public bool GPJLQMFKNON;

	// Token: 0x04000B68 RID: 2920
	public bool MPHLLMKDQEF = true;

	// Token: 0x04000B69 RID: 2921
	private JLMPBLMOICG NNFMFGDPCPF;

	// Token: 0x04000B6A RID: 2922
	[Range(0f, 1f)]
	public float QNBFBLJCHDC = 1f;

	// Token: 0x04000B6B RID: 2923
	[Range(0f, 2f)]
	public float NBJPJBEQKPI = 1f;

	// Token: 0x04000B6C RID: 2924
	[Range(0f, 1f)]
	public float FJIKLOFOBBC;

	// Token: 0x04000B6D RID: 2925
	public float GJEMMBBNGLB = 128f;

	// Token: 0x04000B6E RID: 2926
	[Range(0f, 1f)]
	public float LDBMOOIEBHP = 0.02f;

	// Token: 0x04000B6F RID: 2927
	[Range(0f, 255f)]
	public float DMOLEJHGHCF;

	// Token: 0x04000B70 RID: 2928
	[Range(0f, 255f)]
	public float LKFEFNKEFDH;

	// Token: 0x04000B71 RID: 2929
	[Range(0f, 1f)]
	public float PLDLQOMPMHB;

	// Token: 0x04000B72 RID: 2930
	[Range(0f, 1f)]
	public float GKOFGGEHFBM;

	// Token: 0x04000B73 RID: 2931
	public Texture2D MGJBMGMEGBF;

	// Token: 0x04000B74 RID: 2932
	public Vector2 HOOONLPEQOI = Vector2.zero;

	// Token: 0x04000B75 RID: 2933
	public Vector2 GDCCBPNGNCE = Vector2.one;

	// Token: 0x0200018C RID: 396
	public enum KNEJQBPFEON
	{
		// Token: 0x04000B77 RID: 2935
		None,
		// Token: 0x04000B78 RID: 2936
		Monster,
		// Token: 0x04000B79 RID: 2937
		NPC
	}
}
