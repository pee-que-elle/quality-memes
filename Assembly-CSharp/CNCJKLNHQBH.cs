using System;
using System.Collections;
using System.Diagnostics;
using PSXAPI.Request;
using PSXAPI.Response;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x020001A6 RID: 422
public class CNCJKLNHQBH : MonoBehaviour
{
	// Token: 0x060034D9 RID: 13529 RVA: 0x00199BB0 File Offset: 0x00197DB0
	public void PCMBMOFNIJE()
	{
		if (this.LIQLFCKICLQ.DJNHQQGGCNE((int)this.PPMJCBONMQJ.transform.position.x, (int)(-(int)this.PPMJCBONMQJ.transform.position.z), this.BJGQDHPBCFC, this.PPMJCBONMQJ.KBKKMQNFJIG))
		{
			if (this.QELEIBIKPOF > 0)
			{
				this.QELEIBIKPOF--;
			}
			if (this.QELEIBIKPOF == 0)
			{
				this.LFHQLIMJFHJ = UnityEngine.Time.time;
				this.KCMIHQPIQKI.SetActive(true);
			}
		}
	}

	// Token: 0x060034DA RID: 13530 RVA: 0x00199C44 File Offset: 0x00197E44
	public void JLCHNMGOKGG()
	{
		this.PPMJCBONMQJ.BHQOFDQCCCG = false;
		this.GJKPLMKHKMK = true;
		this.NQCKQBNDLLN = Guid.NewGuid();
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Sync
		{
			ID = this.NQCKQBNDLLN,
			MapLoad = false
		}, false);
	}

	// Token: 0x060034DB RID: 13531 RVA: 0x00199C94 File Offset: 0x00197E94
	public void DFMMCLFKFBH(int PECKDHFNOKI)
	{
		this.PPMJCBONMQJ.EDMFOMGFMGD(PECKDHFNOKI, null, false, 0, 0, 0, false, false);
	}

	// Token: 0x060034DC RID: 13532 RVA: 0x00199CB8 File Offset: 0x00197EB8
	public void OBCNMKNGFIF(string HIEFQEEDHGG, string NQFQGCGPHBE, string GQFFOBCKGKG, LPBPDPMJKNN.PJIJIFKBMBB DPQFDCNLLPC, bool FJDHJMOMGPC = false, KGQECFKLKOP.IJHPPMDDKIE MKBCKPPCIQO = null, int HCKMEIPJNLK = -1, bool FGGNDBDGOKD = false)
	{
		if (FJDHJMOMGPC)
		{
			if (FGGNDBDGOKD)
			{
				GameObject x = GameObject.Find("MSGBOX - " + HIEFQEEDHGG + GQFFOBCKGKG);
				if (x != null)
				{
					return;
				}
			}
			else
			{
				GameObject gameObject = GameObject.Find("MSGBOX - " + HIEFQEEDHGG);
				if (gameObject != null)
				{
					UnityEngine.Object.Destroy(gameObject);
				}
			}
		}
		LPBPDPMJKNN component = this.NEQDHPDMBJK.BFCKNMFEBDM(this.EQLPELCDBBC).GetComponent<LPBPDPMJKNN>();
		component.BQLIIQIIMDH(this, HIEFQEEDHGG, NQFQGCGPHBE, GQFFOBCKGKG, DPQFDCNLLPC, MKBCKPPCIQO, HCKMEIPJNLK);
		if (FGGNDBDGOKD)
		{
			component.gameObject.name = "MSGBOX - " + HIEFQEEDHGG + GQFFOBCKGKG;
		}
		else
		{
			component.gameObject.name = "MSGBOX - " + HIEFQEEDHGG;
		}
	}

	// Token: 0x060034DD RID: 13533 RVA: 0x00199D64 File Offset: 0x00197F64
	public void JEFDKMLGNED(PSXAPI.Response.Login KOEEIBDFFGE)
	{
		if (KOEEIBDFFGE.Result == LoginResult.Error)
		{
			GDDKPIHHICF.QOQONHOOLNE.HCFPCELLGGQ = false;
			GDDKPIHHICF.QOQONHOOLNE.EFOGMBCFBGM = false;
			INFJMNPKNQF.QOQONHOOLNE.OMBKEPGPIGE(KOEEIBDFFGE.Inventory);
			HFCMDEQKCKH.CFGIOIGOIFQ().GDECBJMCQPQ(KOEEIBDFFGE.Inventory);
			this.BFDCFEOHJIF.LKPOBCBOFIC(KOEEIBDFFGE.Username);
			EIDBQCPLPIL.BBCBOIFQDBK().JGQOMNKDJNC(KOEEIBDFFGE.Pokedex);
			if (KOEEIBDFFGE.Lobby != null)
			{
				BDLNNJFQOQH.JPGFBOPDJKH().NLEHMFFEGMK(KOEEIBDFFGE.Lobby);
			}
			if (KOEEIBDFFGE.Friends != null)
			{
				CKMLKNPNPQO.QOQONHOOLNE.NPEGDKFCMOO(KOEEIBDFFGE.Friends);
			}
			if (KOEEIBDFFGE.Ignore != null)
			{
				CKMLKNPNPQO.INJDHLQHFFD().MKEGMQMOLDD(KOEEIBDFFGE.Ignore);
			}
			this.QELEIBIKPOF = KOEEIBDFFGE.Encounter;
			this.KCMIHQPIQKI.SetActive(true);
			this.OOPOOQLJNPO(KOEEIBDFFGE.Level);
			this.OFLGFDNHKJO = KOEEIBDFFGE.Equip;
			if (KOEEIBDFFGE.Style != null)
			{
				this.PPMJCBONMQJ.GPFOFHLIDMH(KOEEIBDFFGE.Style, KOEEIBDFFGE.Mount, KOEEIBDFFGE.Equip);
			}
			DCJIBBJQGJP.OQDOKBJNBBL().LKFLHNFHJCF(KOEEIBDFFGE.Party);
			if (KOEEIBDFFGE.FriendMessage != null)
			{
				CKMLKNPNPQO.INJDHLQHFFD().IIQNBGPPBCI.NCBFKNGMKPB(KOEEIBDFFGE.FriendMessage);
			}
			if (KOEEIBDFFGE.Time != null)
			{
				this.INFJBBNFJMO(KOEEIBDFFGE.Time);
			}
			DBQLOHBBJMG.ODJQHLJCFGH().CEFOLQBGEJG = true;
			if (KOEEIBDFFGE.Battle != null)
			{
				this.MGFDFQDMGPG = KOEEIBDFFGE.Battle;
			}
			this.BMKDPKDDBDK.value = KOEEIBDFFGE.StatsPrivate;
			this.IBPEBDGDQLG = KOEEIBDFFGE.StaffRank;
			NOHEMGHONKK.QBNCFLKLLKC().MKELCDNMCFN(KOEEIBDFFGE.Guild);
			if (KOEEIBDFFGE.Quests != null)
			{
				foreach (PSXAPI.Response.Quest bjfoclikmij in KOEEIBDFFGE.Quests)
				{
					NBQDPNGNNML.QOQONHOOLNE.GLEFJQQKILF(bjfoclikmij, false);
				}
			}
			DNFENPQLICQ.JJCONJJNDQN().IJFEPHBHDJG(KOEEIBDFFGE.SkinsUser);
			if (KOEEIBDFFGE.Position.Scripts != null)
			{
				QOHCEBMQKMB.JLLBKOOQKGO().QCEGHHPDQLF.AddRange(KOEEIBDFFGE.Position.Scripts);
			}
			this.HGJOFHGKQMD(KOEEIBDFFGE.Position, false, false, false);
			KOJBBGEINPH.FHCMDGCONNE().FLPOHIKPHNJ(KOEEIBDFFGE.Lootboxes);
			KOJBBGEINPH.FHCMDGCONNE().FJEILLHKEPE(KOEEIBDFFGE.DailyLootbox, KOEEIBDFFGE.DailyReset);
			if (KOEEIBDFFGE.NearbyUsers != null)
			{
				CGOIPHKQMPD.FFCOKMHBCQJ().KDCBLNIKHFJ(KOEEIBDFFGE.NearbyUsers);
			}
			CKMLKNPNPQO.INJDHLQHFFD().DLJCDOLIQJQ(KOEEIBDFFGE.ShowAsOffline);
			this.GEQIJFMDJKG = KOEEIBDFFGE.TotalSteps;
			GNDQBCBDHKD.MKMJKLDDNDD().PKBHOMFCOBB(KOEEIBDFFGE.Effects);
			this.HDGHKDEPNBP = KOEEIBDFFGE.DiscoveredAreas;
		}
	}

	// Token: 0x060034DE RID: 13534 RVA: 0x000175DB File Offset: 0x000157DB
	public void COEIJLJCIEN()
	{
		if (this.MGFDFQDMGPG != null)
		{
			DBQLOHBBJMG.QOQONHOOLNE.EDNKECNMIBK = true;
			GDDKPIHHICF.QOQONHOOLNE.StartCoroutine(DBQLOHBBJMG.QOQONHOOLNE.GLJOODPHBCN(this.MGFDFQDMGPG));
		}
	}

	// Token: 0x060034DF RID: 13535 RVA: 0x00199FE8 File Offset: 0x001981E8
	public void GFMGCOFHDNB(string IHIHHCCEDHQ)
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatJoin
		{
			Channel = IHIHHCCEDHQ,
			Action = ChatJoinAction.Leave
		}, false);
	}

	// Token: 0x060034E0 RID: 13536 RVA: 0x0019A018 File Offset: 0x00198218
	public void CEDNIOKLNNP(PSXAPI.Response.Move QPGCBDPFIOF)
	{
		this.IDHBJBKFFON = true;
		GDDKPIHHICF.QOQONHOOLNE.FGMIKQLOEEQ();
		this.PPMJCBONMQJ.NQJHJNQFKKC();
		this.PPMJCBONMQJ.BHQOFDQCCCG = false;
		this.PPMJCBONMQJ.OQJFBJQJEFG = 0f;
		base.StartCoroutine(this.DOCMPFGLQFL(QPGCBDPFIOF));
	}

	// Token: 0x060034E1 RID: 13537 RVA: 0x0019A06C File Offset: 0x0019826C
	private void MEDIPECIDQP()
	{
		if (this.QELEIBIKPOF == 0 && UnityEngine.Time.time > this.LFHQLIMJFHJ + 27f)
		{
			this.LFHQLIMJFHJ = UnityEngine.Time.time;
			this.QELEIBIKPOF = -1;
			this.KCMIHQPIQKI.SetActive(true);
		}
		if (this.MFCEIDLOJPD + 1809f < UnityEngine.Time.time)
		{
			this.MFCEIDLOJPD = UnityEngine.Time.time;
			this.EKMPLKOBQLP.LKPOBCBOFIC(MCNLIHMMLCF.KKICFMLLMHQ().JEMKIKEMFPB.ToString() + "[-]" + this.HIEFOCPLEPD());
			KOJBBGEINPH.OQDOKBJNBBL().DKQEQBMBPDN();
		}
		if (EMENMKHBPQE.CMPBKDMMHFQ != null)
		{
			this.GJECFKPGQQF = (EMENMKHBPQE.CMPBKDMMHFQ.GetComponent<JIMBBPLINGI>() == null);
		}
		else
		{
			this.GJECFKPGQQF = true;
		}
		this.BJMPFQBFOFL();
	}

	// Token: 0x060034E2 RID: 13538 RVA: 0x0019A140 File Offset: 0x00198340
	public void INFJBBNFJMO(PSXAPI.Response.Time OQJFBJQJEFG)
	{
		this.LKIBNLMIGKG = OQJFBJQJEFG.GameSeason;
		MCNLIHMMLCF.QOQONHOOLNE.BEDOBPPLQLD = OQJFBJQJEFG.Weather;
		MCNLIHMMLCF.QOQONHOOLNE.JEMKIKEMFPB = OQJFBJQJEFG.GameDayTime;
		this.LHBQHCLOCOP = DateTime.UtcNow;
		this.KGJOGLCCQEP = OQJFBJQJEFG.GameTime;
		this.CMPFNLGQODQ = OQJFBJQJEFG.TimeFactor;
		this.EKMPLKOBQLP.PIDLOFMIEFQ = OQJFBJQJEFG.GameDayTime.ToString() + " " + this.HIEFOCPLEPD();
		MCNLIHMMLCF.QOQONHOOLNE.DHJLPCKHQBH();
	}

	// Token: 0x060034E3 RID: 13539 RVA: 0x0001760B File Offset: 0x0001580B
	public void Quit()
	{
		Application.Quit();
	}

	// Token: 0x060034E4 RID: 13540 RVA: 0x0019A1D8 File Offset: 0x001983D8
	private IEnumerator ICIHKHJLQNG()
	{
		yield return null;
		return 1;
		if (!(OGJJKKQPNMK.QOQONHOOLNE != null))
		{
			goto IL_74;
		}
		yield return null;
		return 1;
		IL_74:
		if (!DBQLOHBBJMG.QOQONHOOLNE.QQQBDBNCMCP)
		{
			goto IL_98;
		}
		yield return null;
		return 1;
		IL_98:
		if (QOHCEBMQKMB.QOQONHOOLNE.EKEKMCMJEOC())
		{
			goto IL_C5;
		}
		yield return new WaitForSeconds(1f);
		return 1;
		IL_C5:
		yield return null;
		return 1;
		if (this.JNMJGCBNBBB < 2)
		{
			goto IL_11B;
		}
		this.JOHLPPHIPNB = JLCINGQBJPJ.FJCEGFKJLCL(this.LBCKFHCPELM, 1.5f, this.JNMJGCBNBBB, 0f);
		IL_11B:
		yield break;
	}

	// Token: 0x060034E5 RID: 13541 RVA: 0x0019A1F4 File Offset: 0x001983F4
	private void Update()
	{
		if (this.QELEIBIKPOF == 0 && UnityEngine.Time.time > this.LFHQLIMJFHJ + 20f)
		{
			this.LFHQLIMJFHJ = UnityEngine.Time.time;
			this.QELEIBIKPOF = -1;
			this.KCMIHQPIQKI.SetActive(false);
		}
		if (this.MFCEIDLOJPD + 3f < UnityEngine.Time.time)
		{
			this.MFCEIDLOJPD = UnityEngine.Time.time;
			this.EKMPLKOBQLP.PIDLOFMIEFQ = MCNLIHMMLCF.QOQONHOOLNE.JEMKIKEMFPB.ToString() + " " + this.HIEFOCPLEPD();
			KOJBBGEINPH.QOQONHOOLNE.DKQEQBMBPDN();
		}
		if (EMENMKHBPQE.CMPBKDMMHFQ != null)
		{
			this.GJECFKPGQQF = !(EMENMKHBPQE.CMPBKDMMHFQ.GetComponent<JIMBBPLINGI>() == null);
		}
		else
		{
			this.GJECFKPGQQF = false;
		}
		this.BJMPFQBFOFL();
	}

	// Token: 0x060034E6 RID: 13542 RVA: 0x00017612 File Offset: 0x00015812
	private void MBHFBPBFCOF()
	{
		if (UnityEngine.Time.time > this.ECMJPDGDILO + 1349f)
		{
			this.ECMJPDGDILO = UnityEngine.Time.time;
			if (this.KOCBHNQNOJO.EMFDMGHDBOC)
			{
				DCCFQPDFBFO.CLPQIKCDHPP().BPPLKBMMBJE(35, true);
			}
		}
	}

	// Token: 0x060034E7 RID: 13543 RVA: 0x0019A2C8 File Offset: 0x001984C8
	[DebuggerHidden]
	public IEnumerator BCFGJDEGJFM()
	{
		CNCJKLNHQBH.JNMFDHGICOB jnmfdhgicob = new CNCJKLNHQBH.JNMFDHGICOB();
		jnmfdhgicob.QNDQJMNKFNN = this;
		return jnmfdhgicob;
	}

	// Token: 0x060034E8 RID: 13544 RVA: 0x0019A2E4 File Offset: 0x001984E4
	public bool QNPQDFGOOEP(int PECKDHFNOKI = -1)
	{
		if (this.IFGGFHIMCKJ)
		{
			return false;
		}
		bool flag = false;
		if (PECKDHFNOKI == -1)
		{
			if (!Input.GetKey(this.QQEBEJLJDFH.FNJFODPIOBH("Up")) && !Input.GetKey(this.QQEBEJLJDFH.FNJFODPIOBH("UpS")))
			{
				if (!Input.GetKey(this.QQEBEJLJDFH.FNJFODPIOBH("Down")) && !Input.GetKey(this.QQEBEJLJDFH.FNJFODPIOBH("DownS")))
				{
					if (!Input.GetKey(this.QQEBEJLJDFH.FNJFODPIOBH("Left")) && !Input.GetKey(this.QQEBEJLJDFH.FNJFODPIOBH("LeftS")))
					{
						if (Input.GetKey(this.QQEBEJLJDFH.FNJFODPIOBH("Right")) || Input.GetKey(this.QQEBEJLJDFH.FNJFODPIOBH("RightS")))
						{
							PECKDHFNOKI = 3;
						}
					}
					else
					{
						PECKDHFNOKI = 2;
					}
				}
				else
				{
					PECKDHFNOKI = 1;
				}
			}
			else
			{
				PECKDHFNOKI = 0;
			}
			if (Input.GetKey(KeyCode.LeftControl) && this.IBPEBDGDQLG == StaffRank.Developer)
			{
				GDDKPIHHICF.QOQONHOOLNE.PDKBHHPOQPJ();
				switch (PECKDHFNOKI)
				{
				case 0:
					GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
					{
						Channel = string.Empty,
						Message = "/force up"
					}, false);
					break;
				case 1:
					GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
					{
						Channel = string.Empty,
						Message = "/force down"
					}, false);
					break;
				case 2:
					GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
					{
						Channel = string.Empty,
						Message = "/force left"
					}, false);
					break;
				case 3:
					GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
					{
						Channel = string.Empty,
						Message = "/force right"
					}, false);
					break;
				}
				this.IFGGFHIMCKJ = true;
				return false;
			}
			if (PECKDHFNOKI > -1)
			{
				flag = true;
				if (this.QELEIBIKPOF == 0)
				{
					return false;
				}
			}
		}
		else
		{
			this.BBBKDMJDIFD = 0f;
		}
		if (PECKDHFNOKI == -1)
		{
			return false;
		}
		bool flag2 = false;
		PSXAPI.Request.MoveAction moveAction = PSXAPI.Request.MoveAction.None;
		DJOOHHIQGJK.JDQNKBIDIKE dieohloinhh = this.PPMJCBONMQJ.DIEOHLOINHH;
		bool flag3 = this.IEBJNKKJPEC.EKEKMCMJEOC();
		if (UnityEngine.Time.time > this.BBBKDMJDIFD + 0.125f)
		{
			this.BBBKDMJDIFD = 0f;
		}
		if (flag3)
		{
			this.BBBKDMJDIFD = 0f;
			flag = false;
		}
		bool flag4 = false;
		if (flag && this.BBBKDMJDIFD == 0f && !flag3 && this.PPMJCBONMQJ.JQBBIQFNONP == 0f)
		{
			flag4 = true;
			if (dieohloinhh == DJOOHHIQGJK.JDQNKBIDIKE.Up && PECKDHFNOKI == 0)
			{
				flag4 = false;
			}
			else if (dieohloinhh == DJOOHHIQGJK.JDQNKBIDIKE.Down && PECKDHFNOKI == 1)
			{
				flag4 = false;
			}
			else if (dieohloinhh == DJOOHHIQGJK.JDQNKBIDIKE.Left && PECKDHFNOKI == 2)
			{
				flag4 = false;
			}
			else if (dieohloinhh == DJOOHHIQGJK.JDQNKBIDIKE.Right && PECKDHFNOKI == 3)
			{
				flag4 = false;
			}
			if (!flag4)
			{
				this.BBBKDMJDIFD = 0f;
				flag = false;
			}
		}
		if (flag4)
		{
			this.BBBKDMJDIFD = UnityEngine.Time.time;
			switch (PECKDHFNOKI)
			{
			case 0:
				flag2 = this.PPMJCBONMQJ.EDMFOMGFMGD(4, this.BOGKQOEEBFK, false, 0, 0, 0, false, false);
				moveAction = PSXAPI.Request.MoveAction.Up;
				break;
			case 1:
				flag2 = this.PPMJCBONMQJ.EDMFOMGFMGD(5, this.BOGKQOEEBFK, false, 0, 0, 0, false, false);
				moveAction = PSXAPI.Request.MoveAction.Down;
				break;
			case 2:
				flag2 = this.PPMJCBONMQJ.EDMFOMGFMGD(6, this.BOGKQOEEBFK, false, 0, 0, 0, false, false);
				moveAction = PSXAPI.Request.MoveAction.Left;
				break;
			case 3:
				flag2 = this.PPMJCBONMQJ.EDMFOMGFMGD(7, this.BOGKQOEEBFK, false, 0, 0, 0, false, false);
				moveAction = PSXAPI.Request.MoveAction.Right;
				break;
			}
			flag2 = false;
		}
		else
		{
			if (flag && this.BBBKDMJDIFD > 0f)
			{
				return true;
			}
			switch (PECKDHFNOKI)
			{
			case 0:
				flag2 = this.PPMJCBONMQJ.EDMFOMGFMGD(0, this.BOGKQOEEBFK, false, 0, 0, 0, false, false);
				moveAction = PSXAPI.Request.MoveAction.Up;
				break;
			case 1:
				flag2 = this.PPMJCBONMQJ.EDMFOMGFMGD(1, this.BOGKQOEEBFK, false, 0, 0, 0, false, false);
				moveAction = PSXAPI.Request.MoveAction.Down;
				break;
			case 2:
				flag2 = this.PPMJCBONMQJ.EDMFOMGFMGD(2, this.BOGKQOEEBFK, false, 0, 0, 0, false, false);
				moveAction = PSXAPI.Request.MoveAction.Left;
				break;
			case 3:
				flag2 = this.PPMJCBONMQJ.EDMFOMGFMGD(3, this.BOGKQOEEBFK, false, 0, 0, 0, false, false);
				moveAction = PSXAPI.Request.MoveAction.Right;
				break;
			}
			if (!flag2)
			{
				this.CFBPHEDDDIO();
			}
		}
		if (flag2)
		{
			this.BJGQDHPBCFC = moveAction;
			if (this.LIQLFCKICLQ.DMLHFGIFMKM((int)this.PPMJCBONMQJ.transform.position.x, (int)(-(int)this.PPMJCBONMQJ.transform.position.z), this.BJGQDHPBCFC))
			{
				this.IEBJNKKJPEC.KQGLCNGHJLM = true;
				this.PPMJCBONMQJ.NQJHJNQFKKC();
				this.IEBJNKKJPEC.QKKQHILJMMO = true;
			}
			this.PCMBMOFNIJE();
			this.GEQIJFMDJKG += 1u;
			PSXAPI.Request.Move move = new PSXAPI.Request.Move();
			move.X = (int)this.PPMJCBONMQJ.transform.position.x;
			move.Y = -(int)this.PPMJCBONMQJ.transform.position.z;
			move.Map = this.LIQLFCKICLQ.CLPMOMHLNMN;
			move.Actions = new PSXAPI.Request.MoveAction[]
			{
				moveAction
			};
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(move, false);
			if (this.KCMIHQPIQKI.activeSelf)
			{
				GDDKPIHHICF.QOQONHOOLNE.PDKBHHPOQPJ();
			}
			this.LIQLFCKICLQ.JCGBDMKKMMK(this.PPMJCBONMQJ.QMCNCMNQEGL(), false, false);
			if (this.PPMJCBONMQJ.JBJIQOFPPHE)
			{
				this.PPMJCBONMQJ.FDBLQDEOENF();
				this.QMGOPPGNGPI.FDBLQDEOENF();
			}
			return true;
		}
		if (this.PPMJCBONMQJ.DIEOHLOINHH != dieohloinhh && moveAction != PSXAPI.Request.MoveAction.None && moveAction != this.BJGQDHPBCFC)
		{
			if (this.PPMJCBONMQJ.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Left)
			{
				moveAction = PSXAPI.Request.MoveAction.TurnLeft;
			}
			else if (this.PPMJCBONMQJ.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Right)
			{
				moveAction = PSXAPI.Request.MoveAction.TurnRight;
			}
			else if (this.PPMJCBONMQJ.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Down)
			{
				moveAction = PSXAPI.Request.MoveAction.TurnDown;
			}
			else if (this.PPMJCBONMQJ.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Up)
			{
				moveAction = PSXAPI.Request.MoveAction.TurnUp;
			}
			this.BJGQDHPBCFC = moveAction;
			PSXAPI.Request.Move move2 = new PSXAPI.Request.Move();
			move2.X = (int)this.PPMJCBONMQJ.transform.position.x;
			move2.Y = -(int)this.PPMJCBONMQJ.transform.position.z;
			move2.Map = this.LIQLFCKICLQ.CLPMOMHLNMN;
			move2.Actions = new PSXAPI.Request.MoveAction[]
			{
				moveAction
			};
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(move2, false);
			return true;
		}
		return false;
	}

	// Token: 0x060034E9 RID: 13545 RVA: 0x0001764C File Offset: 0x0001584C
	public void Logout(string DBEPQKEMJOP = "")
	{
		GDDKPIHHICF.QOQONHOOLNE.NJNCGMFPHFI();
	}

	// Token: 0x060034EA RID: 13546 RVA: 0x0019A934 File Offset: 0x00198B34
	public void BJMPFQBFOFL()
	{
		if (this.CKJIQFFGJHJ != null && this.QQEBEJLJDFH != null && this.CKJIQFFGJHJ.JOQBIMQCNDO)
		{
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				this.KOCBHNQNOJO.OpenCloseMenu();
			}
			if (this.LHFFLGHLPQO.activeSelf)
			{
				return;
			}
			if (!this.GJECFKPGQQF && !MCNLIHMMLCF.NIDBIHMDOQF && !this.FQQQONEOKIN.enabled && !this.GJKPLMKHKMK && !this.CNFNKELFCHN && !this.LIBEKPIFMFB.activeSelf && !this.PLGFMPNHGID.activeSelf && !this.LPOPOLFKOPI.activeSelf && !this.JOPCLLDNOHH.activeSelf && OGJJKKQPNMK.QOQONHOOLNE == null)
			{
				if (!GGQKBGDGNJN.QOQONHOOLNE.FLNKCIQLMGL.activeSelf && !this.IEBJNKKJPEC.QKKQHILJMMO && !this.IEBJNKKJPEC.EKEKMCMJEOC() && !this.LHNQPPEQIOE.activeSelf && !this.KLBKGJQONIL.activeSelf && !this.JOHBOJLFCQF.activeSelf)
				{
					if (!this.PPMJCBONMQJ.BHQOFDQCCCG)
					{
						if (this.BMKFDHDJPNE != null && this.MJCLOOLBQQB)
						{
							bool flag = false;
							if (this.JBBIMNCLPIM < this.BMKFDHDJPNE.Links.Length && this.LIQLFCKICLQ.JPBLDNBBOLO > 0)
							{
								int i = 0;
								while (i < this.LIQLFCKICLQ.JPBLDNBBOLO)
								{
									if (!(this.LIQLFCKICLQ.LIQLFCKICLQ.Links[i].ID == this.BMKFDHDJPNE.Links[this.JBBIMNCLPIM]))
									{
										i++;
									}
									else
									{
										this.PPMJCBONMQJ.NQJHJNQFKKC();
										this.PPMJCBONMQJ.GCCKFGHJFPO(this.LIQLFCKICLQ.LIQLFCKICLQ.Links[i].x, -this.LIQLFCKICLQ.LIQLFCKICLQ.Links[i].z, default(Vector2));
										this.JBBIMNCLPIM++;
										flag = true;
										this.MJCLOOLBQQB = true;
										this.PPMJCBONMQJ.MMPQCIKNBQE = true;
										IL_263:
										if (!flag)
										{
											this.BMKFDHDJPNE = null;
											this.JBBIMNCLPIM = 0;
											this.MJCLOOLBQQB = false;
											this.PPMJCBONMQJ.NQJHJNQFKKC();
											this.PPMJCBONMQJ.MMPQCIKNBQE = false;
											goto IL_292;
										}
										goto IL_292;
									}
								}
								goto IL_263;
							}
							IL_292:
							this.MJCLOOLBQQB = false;
							return;
						}
						if (!this.QNPQDFGOOEP(-1))
						{
							if (!Input.GetKeyDown(this.QQEBEJLJDFH.FNJFODPIOBH("Shift")) && !Input.GetKeyDown(this.QQEBEJLJDFH.FNJFODPIOBH("ShiftS")))
							{
								if (Input.GetKeyDown(this.QQEBEJLJDFH.FNJFODPIOBH("Interact")) && !this.LHNQPPEQIOE.activeSelf && !this.KLBKGJQONIL.activeSelf && !this.JOHBOJLFCQF.activeSelf && !GGQKBGDGNJN.QOQONHOOLNE.FLNKCIQLMGL.activeSelf && !GGQKBGDGNJN.QOQONHOOLNE.FOHOOGJMFEG)
								{
									if (this.IEBJNKKJPEC.DKQGFPEGMME + 0.5f >= UnityEngine.Time.time || this.IEBJNKKJPEC.QKKQHILJMMO)
									{
										return;
									}
									this.IEBJNKKJPEC.DKQGFPEGMME = UnityEngine.Time.time;
									if (this.BMKFDHDJPNE != null)
									{
										this.BMKFDHDJPNE = null;
										this.PPMJCBONMQJ.NQJHJNQFKKC();
									}
									Vector3 a = this.PPMJCBONMQJ.QMCNCMNQEGL();
									if (this.PPMJCBONMQJ.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Up && a.z > 0f)
									{
										a += new Vector3(0f, 0f, -1f);
									}
									else if (this.PPMJCBONMQJ.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Down && a.z < (float)this.LIQLFCKICLQ.LIQLFCKICLQ.height)
									{
										a += new Vector3(0f, 0f, 1f);
									}
									else if (this.PPMJCBONMQJ.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Left && a.x > 0f)
									{
										a += new Vector3(-1f, 0f, 0f);
									}
									else if (this.PPMJCBONMQJ.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Right && a.x < (float)this.LIQLFCKICLQ.LIQLFCKICLQ.width)
									{
										a += new Vector3(1f, 0f, 0f);
									}
									KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP((int)a.x, (int)a.z);
									if (!this.IEBJNKKJPEC.EKEKMCMJEOC())
									{
										if (nhgkgbgjefj != null)
										{
											nhgkgbgjefj.DNECDEOQKLP.EKEKMCMJEOC = true;
											nhgkgbgjefj.DNECDEOQKLP.BJGQDHPBCFC = nhgkgbgjefj.DNECDEOQKLP.DIEOHLOINHH;
											if (this.PPMJCBONMQJ.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Up)
											{
												nhgkgbgjefj.DNECDEOQKLP.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Down;
											}
											else if (this.PPMJCBONMQJ.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Down)
											{
												nhgkgbgjefj.DNECDEOQKLP.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Up;
											}
											else if (this.PPMJCBONMQJ.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Left)
											{
												nhgkgbgjefj.DNECDEOQKLP.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Right;
											}
											else if (this.PPMJCBONMQJ.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Right)
											{
												nhgkgbgjefj.DNECDEOQKLP.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Left;
											}
											this.IEBJNKKJPEC.QKKQHILJMMO = true;
											nhgkgbgjefj.DNECDEOQKLP.QMBIHEHNIGC = 0;
											nhgkgbgjefj.DNECDEOQKLP.DKMBJOHMDNJ = 0;
											GDDKPIHHICF.QOQONHOOLNE.PDKBHHPOQPJ();
											GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Talk
											{
												NpcID = nhgkgbgjefj.DBPKNCDGGEP
											}, false);
											if ((nhgkgbgjefj.NPNKKNBJMNC.Settings.Path == null || nhgkgbgjefj.NPNKKNBJMNC.Settings.Path.Length == 0) && !nhgkgbgjefj.NPNKKNBJMNC.Settings.LookRandomly)
											{
												nhgkgbgjefj.DNECDEOQKLP.EKEKMCMJEOC = false;
											}
										}
										else
										{
											this.PEIGIDFJILJ();
										}
									}
								}
							}
							else
							{
								if (this.ENDMFBCOEKH >= UnityEngine.Time.time - 1f)
								{
									return;
								}
								this.ENDMFBCOEKH = UnityEngine.Time.time;
								GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Mount(), false);
							}
						}
					}
					else if ((Input.GetKey(this.QQEBEJLJDFH.FNJFODPIOBH("Up")) || Input.GetKey(this.QQEBEJLJDFH.FNJFODPIOBH("UpS")) || Input.GetKey(this.QQEBEJLJDFH.FNJFODPIOBH("Down")) || Input.GetKey(this.QQEBEJLJDFH.FNJFODPIOBH("DownS")) || Input.GetKey(this.QQEBEJLJDFH.FNJFODPIOBH("Left")) || Input.GetKey(this.QQEBEJLJDFH.FNJFODPIOBH("LeftS")) || Input.GetKey(this.QQEBEJLJDFH.FNJFODPIOBH("Right")) || Input.GetKey(this.QQEBEJLJDFH.FNJFODPIOBH("RightS"))) && this.BMKFDHDJPNE != null && this.PPMJCBONMQJ.BHQOFDQCCCG && !this.PPMJCBONMQJ.KGCEBGIHKKC)
					{
						this.BMKFDHDJPNE = null;
						this.JBBIMNCLPIM = 0;
						this.MJCLOOLBQQB = false;
						this.PPMJCBONMQJ.MMPQCIKNBQE = false;
						if (this.PPMJCBONMQJ.PJGOMOBBNLK.Count > 0)
						{
							if (this.PPMJCBONMQJ.JGGNIDDGPHO() == 10)
							{
								DJOOHHIQGJK.JLKCKMJEGKI jlkckmjegki = this.PPMJCBONMQJ.PJGOMOBBNLK[0];
								this.PPMJCBONMQJ.NQJHJNQFKKC();
								if (jlkckmjegki.BJIGIECDQPG == "u")
								{
									this.BJGQDHPBCFC = PSXAPI.Request.MoveAction.Up;
								}
								else if (jlkckmjegki.BJIGIECDQPG == "d")
								{
									this.BJGQDHPBCFC = PSXAPI.Request.MoveAction.Down;
								}
								else if (jlkckmjegki.BJIGIECDQPG == "l")
								{
									this.BJGQDHPBCFC = PSXAPI.Request.MoveAction.Left;
								}
								else if (jlkckmjegki.BJIGIECDQPG == "r")
								{
									this.BJGQDHPBCFC = PSXAPI.Request.MoveAction.Right;
								}
							}
							else
							{
								DJOOHHIQGJK.JLKCKMJEGKI jlkckmjegki2 = this.PPMJCBONMQJ.PJGOMOBBNLK[0];
								this.PPMJCBONMQJ.NQJHJNQFKKC();
								if (jlkckmjegki2.BJIGIECDQPG == "u")
								{
									this.BJGQDHPBCFC = PSXAPI.Request.MoveAction.Up;
								}
								else if (jlkckmjegki2.BJIGIECDQPG == "d")
								{
									this.BJGQDHPBCFC = PSXAPI.Request.MoveAction.Down;
								}
								else if (jlkckmjegki2.BJIGIECDQPG == "l")
								{
									this.BJGQDHPBCFC = PSXAPI.Request.MoveAction.Left;
								}
								else if (jlkckmjegki2.BJIGIECDQPG == "r")
								{
									this.BJGQDHPBCFC = PSXAPI.Request.MoveAction.Right;
								}
								jlkckmjegki2.BJIGIECDQPG = "b";
								this.PPMJCBONMQJ.PJGOMOBBNLK.Add(jlkckmjegki2);
							}
						}
					}
					if (!Input.GetKey(this.QQEBEJLJDFH.FNJFODPIOBH("Up")) && !Input.GetKey(this.QQEBEJLJDFH.FNJFODPIOBH("UpS")) && !Input.GetKey(this.QQEBEJLJDFH.FNJFODPIOBH("Down")) && !Input.GetKey(this.QQEBEJLJDFH.FNJFODPIOBH("DownS")) && !Input.GetKey(this.QQEBEJLJDFH.FNJFODPIOBH("Left")) && !Input.GetKey(this.QQEBEJLJDFH.FNJFODPIOBH("LeftS")) && !Input.GetKey(this.QQEBEJLJDFH.FNJFODPIOBH("Right")) && !Input.GetKey(this.QQEBEJLJDFH.FNJFODPIOBH("RightS")))
					{
						this.BBBKDMJDIFD = 0f;
						this.IFGGFHIMCKJ = false;
					}
				}
				else if (Input.GetKeyDown(this.QQEBEJLJDFH.FNJFODPIOBH("Interact")))
				{
					if (this.KLBKGJQONIL.activeSelf || this.JOHBOJLFCQF.activeSelf)
					{
						return;
					}
					if (this.LHNQPPEQIOE.activeSelf)
					{
						this.LHNQPPEQIOE.GetComponent<GQFGBNEHHPC>().DDHDOLPIPEM();
						return;
					}
					this.IEBJNKKJPEC.ClickText();
					return;
				}
				else if (!this.GJECFKPGQQF && (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown(KeyCode.Alpha8) || Input.GetKeyDown(KeyCode.Alpha9)) && this.IEBJNKKJPEC.JGIFFIBHHDE != null && this.IEBJNKKJPEC.JGIFFIBHHDE.BBKKHIDMQIQ == QOHCEBMQKMB.OMGJJGGOCOJ.Select)
				{
					int childCount = this.IEBJNKKJPEC.FQQQEGDLPMB.transform.childCount;
					int num = 0;
					if (Input.GetKeyDown(KeyCode.Alpha1))
					{
						num = 0;
					}
					else if (Input.GetKeyDown(KeyCode.Alpha2))
					{
						num = 1;
					}
					else if (Input.GetKeyDown(KeyCode.Alpha3))
					{
						num = 2;
					}
					else if (Input.GetKeyDown(KeyCode.Alpha4))
					{
						num = 3;
					}
					else if (Input.GetKeyDown(KeyCode.Alpha5))
					{
						num = 4;
					}
					else if (Input.GetKeyDown(KeyCode.Alpha6))
					{
						num = 5;
					}
					else if (Input.GetKeyDown(KeyCode.Alpha7))
					{
						num = 6;
					}
					else if (Input.GetKeyDown(KeyCode.Alpha8))
					{
						num = 7;
					}
					else if (Input.GetKeyDown(KeyCode.Alpha9))
					{
						num = 8;
					}
					else if (Input.GetKeyDown(KeyCode.Alpha0))
					{
						num = 9;
					}
					if (childCount > num)
					{
						this.IEBJNKKJPEC.ClickSelect(num);
					}
				}
			}
			else if (Input.GetKeyDown(this.QQEBEJLJDFH.FNJFODPIOBH("Interact")) && !this.GJECFKPGQQF && !this.FQQQONEOKIN.enabled && !this.GJKPLMKHKMK && !this.CNFNKELFCHN && !this.LIBEKPIFMFB.activeSelf && !this.PLGFMPNHGID.activeSelf && !this.LPOPOLFKOPI.activeSelf && !this.JOPCLLDNOHH.activeSelf && OGJJKKQPNMK.QOQONHOOLNE == null && this.IEBJNKKJPEC.EKEKMCMJEOC())
			{
				if (this.KLBKGJQONIL.activeSelf || this.JOHBOJLFCQF.activeSelf)
				{
					return;
				}
				if (this.LHNQPPEQIOE.activeSelf)
				{
					this.LHNQPPEQIOE.GetComponent<GQFGBNEHHPC>().DDHDOLPIPEM();
					return;
				}
				this.IEBJNKKJPEC.ClickText();
				return;
			}
		}
	}

	// Token: 0x060034EB RID: 13547 RVA: 0x00017658 File Offset: 0x00015858
	private void CFBPHEDDDIO()
	{
		if (UnityEngine.Time.time > this.ECMJPDGDILO + 0.5f)
		{
			this.ECMJPDGDILO = UnityEngine.Time.time;
			if (this.KOCBHNQNOJO.EMFDMGHDBOC)
			{
				DCCFQPDFBFO.QOQONHOOLNE.LKHCJLDFLEJ(32, false);
			}
		}
	}

	// Token: 0x060034EC RID: 13548 RVA: 0x0019B580 File Offset: 0x00199780
	private void Start()
	{
		RenderSettings.fog = false;
		if (!GameObject.Find("TCPManager"))
		{
			SceneManager.LoadScene("Login");
		}
		this.PIBNGFEMQBL = GameObject.Find("Panel - Right Click");
		if (this.HCQGFNEJFBL == null)
		{
			this.HCQGFNEJFBL = JJGLMJNELOK.QOQONHOOLNE;
		}
		if (this.IEBJNKKJPEC == null)
		{
			this.IEBJNKKJPEC = QOHCEBMQKMB.QOQONHOOLNE;
		}
		if (this.CKJIQFFGJHJ == null)
		{
			this.CKJIQFFGJHJ = GDDKPIHHICF.QOQONHOOLNE;
		}
		this.QMGOPPGNGPI.BQLIIQIIMDH(GFHGEJNHLFQ.QOQONHOOLNE, MCNLIHMMLCF.QOQONHOOLNE, null, -1, 0);
	}

	// Token: 0x060034ED RID: 13549 RVA: 0x0019B624 File Offset: 0x00199824
	public bool HGJOFHGKQMD(PSXAPI.Response.Move QPGCBDPFIOF, bool EMJBONJQPPD = true, bool QQEOJJNFLGN = true, bool PFFLBEHLKIG = false)
	{
		bool result = false;
		this.IFGGFHIMCKJ = true;
		GDDKPIHHICF.QOQONHOOLNE.FGMIKQLOEEQ();
		this.PPMJCBONMQJ.NQJHJNQFKKC();
		this.PPMJCBONMQJ.BHQOFDQCCCG = false;
		this.PPMJCBONMQJ.OQJFBJQJEFG = 0f;
		if (QPGCBDPFIOF.Action == PSXAPI.Response.MoveAction.Set)
		{
			if (EMJBONJQPPD && !PFFLBEHLKIG)
			{
				MCNLIHMMLCF.NIDBIHMDOQF = true;
			}
			if (!PFFLBEHLKIG)
			{
				this.PPMJCBONMQJ.PKCLDNQJMMH = false;
			}
			bool flag = false;
			if (this.LIQLFCKICLQ.CLPMOMHLNMN.ToLowerInvariant() != QPGCBDPFIOF.Map.ToLowerInvariant())
			{
				flag = true;
				result = this.LIQLFCKICLQ.MHIJCEDMMOL(QPGCBDPFIOF.Map);
				string text = "map:" + QPGCBDPFIOF.Map;
				string kbehchkdfbf = this.KBEHCHKDFBF;
				if (kbehchkdfbf != string.Empty && kbehchkdfbf != text)
				{
					this.DNPDFNNHCHG(this.KBEHCHKDFBF);
				}
				this.KBEHCHKDFBF = text;
				this.PPMJCBONMQJ.NQJHJNQFKKC();
				if (this.KBEHCHKDFBF != null && this.KBEHCHKDFBF != kbehchkdfbf)
				{
					this.NPNCKMQPGOK(this.KBEHCHKDFBF);
				}
			}
			else
			{
				if (!EMJBONJQPPD && !this.LIQLFCKICLQ.BNODICFOBHI(QPGCBDPFIOF.Map.ToLowerInvariant()))
				{
					result = true;
				}
				if (!EMJBONJQPPD && MCNLIHMMLCF.QOQONHOOLNE.BFEEOBQCQOJ.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP != 0f)
				{
					base.StartCoroutine(this.NMCNMIGJLEQ());
				}
			}
			this.PPMJCBONMQJ.NQJHJNQFKKC();
			this.PPMJCBONMQJ.BHQOFDQCCCG = false;
			this.PPMJCBONMQJ.OQJFBJQJEFG = 0f;
			this.PPMJCBONMQJ.PJMKLHKFBJM(new Vector3((float)QPGCBDPFIOF.X, this.PPMJCBONMQJ.transform.position.y, (float)(-(float)QPGCBDPFIOF.Y)), QPGCBDPFIOF.Direction);
			JQOIHHDIHBN.QOQONHOOLNE.BHFPMMKFCLD();
			if (QPGCBDPFIOF.Height == 1)
			{
				this.PPMJCBONMQJ.KBKKMQNFJIG = true;
			}
			else
			{
				this.PPMJCBONMQJ.KBKKMQNFJIG = false;
			}
			if (EMJBONJQPPD && !PFFLBEHLKIG)
			{
				if (flag)
				{
					if (!MCNLIHMMLCF.QOQONHOOLNE.BDCNIKLCIQQ)
					{
						this.CNFIPMJMNJP();
					}
				}
				else
				{
					this.JLCHNMGOKGG();
				}
			}
		}
		return result;
	}

	// Token: 0x060034EE RID: 13550 RVA: 0x0019B840 File Offset: 0x00199A40
	public void FQCHBNCDQNK()
	{
		if (this.LIQLFCKICLQ.DJNHQQGGCNE((int)this.PPMJCBONMQJ.transform.position.x, (int)(-(int)this.PPMJCBONMQJ.transform.position.z), this.BJGQDHPBCFC, this.PPMJCBONMQJ.KBKKMQNFJIG))
		{
			if (this.QELEIBIKPOF > 1)
			{
				this.QELEIBIKPOF -= 0;
			}
			if (this.QELEIBIKPOF == 0)
			{
				this.LFHQLIMJFHJ = UnityEngine.Time.time;
				this.KCMIHQPIQKI.SetActive(false);
			}
		}
	}

	// Token: 0x060034EF RID: 13551 RVA: 0x0019B8D4 File Offset: 0x00199AD4
	public void HKKILIIELPF()
	{
		if (!this.CNFNKELFCHN && !QOHCEBMQKMB.QQCNCIQQPIG().DLNELFIPOHB() && !this.GJECFKPGQQF && OGJJKKQPNMK.CDDIILFBFCF() == null && !DBQLOHBBJMG.IECKOKEPENM().QQQBDBNCMCP)
		{
			GGQKBGDGNJN.QOQONHOOLNE.EFENQBOJBNG(true);
		}
	}

	// Token: 0x060034F0 RID: 13552 RVA: 0x0019B924 File Offset: 0x00199B24
	public void NPNCKMQPGOK(string IHIHHCCEDHQ)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatJoin
		{
			Channel = IHIHHCCEDHQ,
			Action = ChatJoinAction.Join
		}, false);
	}

	// Token: 0x060034F1 RID: 13553 RVA: 0x0019B954 File Offset: 0x00199B54
	public void PEIGIDFJILJ()
	{
		if (this.PPMJCBONMQJ.EMIEFKNMQMI.MountType != MountType.Surfing && MCNLIHMMLCF.QOQONHOOLNE.LIQLFCKICLQ != null)
		{
			Vector3 a = this.PPMJCBONMQJ.QMCNCMNQEGL();
			if (this.PPMJCBONMQJ.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Up && a.z > 0f)
			{
				a += new Vector3(0f, 0f, -1f);
			}
			else if (this.PPMJCBONMQJ.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Down && a.z < (float)this.LIQLFCKICLQ.LIQLFCKICLQ.height)
			{
				a += new Vector3(0f, 0f, 1f);
			}
			else if (this.PPMJCBONMQJ.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Left && a.x > 0f)
			{
				a += new Vector3(-1f, 0f, 0f);
			}
			else if (this.PPMJCBONMQJ.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Right && a.x < (float)this.LIQLFCKICLQ.LIQLFCKICLQ.width)
			{
				a += new Vector3(1f, 0f, 0f);
			}
			if (!this.PPMJCBONMQJ.KBKKMQNFJIG && MCNLIHMMLCF.QOQONHOOLNE.GICOBECCEIO((int)a.x, (int)a.z, false))
			{
				GDDKPIHHICF.QOQONHOOLNE.PDKBHHPOQPJ();
				GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf = GNDQBCBDHKD.QOQONHOOLNE.LJBHIMMHGLP("Surf");
				if (nbfcpoplomf != null)
				{
					GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Effect
					{
						Action = EffectAction.Use,
						UID = nbfcpoplomf.CBBBCEMLMLP
					}, false);
				}
			}
		}
	}

	// Token: 0x060034F2 RID: 13554 RVA: 0x0019BAFC File Offset: 0x00199CFC
	[DebuggerHidden]
	private IEnumerator NMCNMIGJLEQ()
	{
		CNCJKLNHQBH.GJBMMGNLGHH gjbmmgnlghh = new CNCJKLNHQBH.GJBMMGNLGHH();
		gjbmmgnlghh.QNDQJMNKFNN = this;
		return gjbmmgnlghh;
	}

	// Token: 0x060034F3 RID: 13555 RVA: 0x0019BB18 File Offset: 0x00199D18
	public void BGJGEDKNOMC(string HIEFQEEDHGG)
	{
		GameObject gameObject = GameObject.Find("MSGBOX - " + HIEFQEEDHGG);
		if (gameObject != null)
		{
			UnityEngine.Object.Destroy(gameObject);
		}
	}

	// Token: 0x060034F4 RID: 13556 RVA: 0x0019BB48 File Offset: 0x00199D48
	public void PECGJDEFFFI(PSXAPI.Response.Path CFHEIICNLFD)
	{
		if (!this.IEBJNKKJPEC.QKKQHILJMMO && !PJCCMHCDFJQ.QOQONHOOLNE.IGDDONDGNGG.gameObject.activeSelf && !BDLNNJFQOQH.QOQONHOOLNE.QPPGQJFBPMH.gameObject.activeSelf && OGJJKKQPNMK.QOQONHOOLNE == null && !BDLNNJFQOQH.QOQONHOOLNE.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.PPMJCBONMQJ.INMILPKMQIC.Clear();
			this.MJCLOOLBQQB = true;
			this.BMKFDHDJPNE = CFHEIICNLFD;
			if (CFHEIICNLFD.Links == null)
			{
				this.BMKFDHDJPNE = null;
				this.MJCLOOLBQQB = false;
				this.PPMJCBONMQJ.MMPQCIKNBQE = false;
			}
			this.JBBIMNCLPIM = 0;
		}
		NBQDPNGNNML.QOQONHOOLNE.JOQKNHFBIBO.GGBPLMICFHN = true;
	}

	// Token: 0x060034F5 RID: 13557 RVA: 0x0019BC10 File Offset: 0x00199E10
	public void MMEOCFDIIGK()
	{
		if (this.EFOGMBCFBGM && MCNLIHMMLCF.QOQONHOOLNE.BDCNIKLCIQQ)
		{
			MCNLIHMMLCF.QOQONHOOLNE.BDCNIKLCIQQ = false;
			this.CNFIPMJMNJP();
		}
		else if (this.DEEKLIKEPQP)
		{
			MCNLIHMMLCF.QOQONHOOLNE.HCQINBCDGNO = false;
			this.DEEKLIKEPQP = false;
			this.PPMJCBONMQJ.PKCLDNQJMMH = true;
			base.StartCoroutine(this.BCFGJDEGJFM());
			base.StartCoroutine(this.LIQLFCKICLQ.JELMONJKQKI(false));
			this.LIQLFCKICLQ.JCGBDMKKMMK(this.PPMJCBONMQJ.QMCNCMNQEGL(), false, false);
			this.GJKPLMKHKMK = false;
			this.IDHBJBKFFON = false;
			this.IFLGLEDMQML();
			GGQKBGDGNJN.QOQONHOOLNE.GKJOCIOHPHO = false;
			if (!QOHCEBMQKMB.QOQONHOOLNE.EKEKMCMJEOC())
			{
				QOHCEBMQKMB.QOQONHOOLNE.KQGLCNGHJLM = false;
				QOHCEBMQKMB.QOQONHOOLNE.QKKQHILJMMO = false;
				this.MJCLOOLBQQB = true;
			}
		}
	}

	// Token: 0x060034F6 RID: 13558 RVA: 0x0019BAFC File Offset: 0x00199CFC
	private IEnumerator HJQNGJLNNKH()
	{
		CNCJKLNHQBH.GJBMMGNLGHH gjbmmgnlghh = new CNCJKLNHQBH.GJBMMGNLGHH();
		gjbmmgnlghh.QNDQJMNKFNN = this;
		return gjbmmgnlghh;
	}

	// Token: 0x060034F7 RID: 13559 RVA: 0x00017692 File Offset: 0x00015892
	private static void DHDQJPJIBOO(CNCJKLNHQBH BGBMIEJJQKC)
	{
		CNCJKLNHQBH.<BILMJGJHOMC>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x060034F8 RID: 13560 RVA: 0x0019BCF0 File Offset: 0x00199EF0
	private IEnumerator DOCMPFGLQFL(PSXAPI.Response.Move QPGCBDPFIOF)
	{
		if (DBQLOHBBJMG.QOQONHOOLNE.ILJPOONGEDE)
		{
			yield return new WaitForSeconds(3f);
		}
		else if (this.LIQLFCKICLQ.CLPMOMHLNMN.ToLowerInvariant() == QPGCBDPFIOF.Map.ToLowerInvariant() && Vector2.Distance(new Vector2(this.PPMJCBONMQJ.transform.position.x, this.PPMJCBONMQJ.transform.position.z), new Vector2((float)QPGCBDPFIOF.X, (float)(-(float)QPGCBDPFIOF.Y))) < 6f)
		{
			MCNLIHMMLCF.QOQONHOOLNE.BFEEOBQCQOJ.enabled = false;
			MCNLIHMMLCF.QOQONHOOLNE.BFEEOBQCQOJ.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 0f;
			this.HGJOFHGKQMD(QPGCBDPFIOF, true, false, false);
			IL_189:
			yield return null;
		}
		else
		{
			MCNLIHMMLCF.QOQONHOOLNE.BFEEOBQCQOJ.enabled = true;
			MCNLIHMMLCF.QOQONHOOLNE.BFEEOBQCQOJ.PlayReverse();
			yield return new WaitForSeconds(0.4f);
		}
		return 1;
		this.HGJOFHGKQMD(QPGCBDPFIOF, true, true, false);
		goto IL_189;
		yield break;
	}

	// Token: 0x060034F9 RID: 13561 RVA: 0x0019A1D8 File Offset: 0x001983D8
	private IEnumerator FLFJNEFELMB()
	{
		yield return null;
		return 1;
		if (!(OGJJKKQPNMK.QOQONHOOLNE != null))
		{
			goto IL_74;
		}
		yield return null;
		return 1;
		IL_74:
		if (!DBQLOHBBJMG.QOQONHOOLNE.QQQBDBNCMCP)
		{
			goto IL_98;
		}
		yield return null;
		return 1;
		IL_98:
		if (QOHCEBMQKMB.QOQONHOOLNE.EKEKMCMJEOC())
		{
			goto IL_C5;
		}
		yield return new WaitForSeconds(1f);
		return 1;
		IL_C5:
		yield return null;
		return 1;
		if (this.JNMJGCBNBBB < 2)
		{
			goto IL_11B;
		}
		this.JOHLPPHIPNB = JLCINGQBJPJ.FJCEGFKJLCL(this.LBCKFHCPELM, 1.5f, this.JNMJGCBNBBB, 0f);
		IL_11B:
		yield break;
	}

	// Token: 0x060034FA RID: 13562 RVA: 0x0019BD14 File Offset: 0x00199F14
	public void NIODFIFQBFE(PSXAPI.Response.Sync BJGCBDNBQCJ)
	{
		this.QELEIBIKPOF = BJGCBDNBQCJ.Encounter;
		if (this.QELEIBIKPOF > 0)
		{
			this.KCMIHQPIQKI.SetActive(false);
		}
		if (this.NQCKQBNDLLN == BJGCBDNBQCJ.ID)
		{
			GDDKPIHHICF.QOQONHOOLNE.FGMIKQLOEEQ();
			PSXAPI.Response.Move move = new PSXAPI.Response.Move();
			move.Action = PSXAPI.Response.MoveAction.Set;
			move.Direction = PSXAPI.Response.PlayerDirection.Default;
			move.Map = BJGCBDNBQCJ.Map;
			move.X = BJGCBDNBQCJ.PosX;
			move.Y = BJGCBDNBQCJ.PosY;
			move.Height = BJGCBDNBQCJ.Height;
			this.IFGGFHIMCKJ = true;
			this.PPMJCBONMQJ.NQJHJNQFKKC();
			this.PPMJCBONMQJ.BHQOFDQCCCG = false;
			this.PPMJCBONMQJ.OQJFBJQJEFG = 0f;
			this.GEQIJFMDJKG = BJGCBDNBQCJ.TotalSteps;
			string text = "map:" + move.Map;
			string kbehchkdfbf = this.KBEHCHKDFBF;
			if (kbehchkdfbf != string.Empty && kbehchkdfbf != text)
			{
				this.DNPDFNNHCHG(this.KBEHCHKDFBF);
			}
			this.KBEHCHKDFBF = text;
			if (this.KBEHCHKDFBF != null && this.KBEHCHKDFBF != kbehchkdfbf)
			{
				this.NPNCKMQPGOK(this.KBEHCHKDFBF);
			}
			if (BJGCBDNBQCJ.Scripts != null)
			{
				foreach (Guid item in BJGCBDNBQCJ.Scripts)
				{
					if (!QOHCEBMQKMB.QOQONHOOLNE.QCEGHHPDQLF.Contains(item))
					{
						QOHCEBMQKMB.QOQONHOOLNE.QCEGHHPDQLF.Add(item);
					}
				}
			}
			if (this.HGJOFHGKQMD(move, false, false, false))
			{
				this.DEEKLIKEPQP = true;
			}
			else
			{
				MCNLIHMMLCF.QOQONHOOLNE.HCQINBCDGNO = false;
				this.DEEKLIKEPQP = false;
				this.PPMJCBONMQJ.PKCLDNQJMMH = true;
				this.PPMJCBONMQJ.HEMIMGIHFBD();
				base.StartCoroutine(this.BCFGJDEGJFM());
				base.StartCoroutine(this.LIQLFCKICLQ.JELMONJKQKI(false));
				this.LIQLFCKICLQ.JCGBDMKKMMK(this.PPMJCBONMQJ.QMCNCMNQEGL(), false, false);
				this.GJKPLMKHKMK = false;
				this.IDHBJBKFFON = false;
				this.IFLGLEDMQML();
				GGQKBGDGNJN.QOQONHOOLNE.GKJOCIOHPHO = false;
				if (!QOHCEBMQKMB.QOQONHOOLNE.EKEKMCMJEOC())
				{
					QOHCEBMQKMB.QOQONHOOLNE.KQGLCNGHJLM = false;
					QOHCEBMQKMB.QOQONHOOLNE.QKKQHILJMMO = false;
					this.MJCLOOLBQQB = true;
				}
			}
		}
		else
		{
			UnityEngine.Debug.Log("Failed Sync");
		}
	}

	// Token: 0x060034FB RID: 13563 RVA: 0x0019A2C8 File Offset: 0x001984C8
	public IEnumerator OBOMIDOMIGC()
	{
		CNCJKLNHQBH.JNMFDHGICOB jnmfdhgicob = new CNCJKLNHQBH.JNMFDHGICOB();
		jnmfdhgicob.QNDQJMNKFNN = this;
		return jnmfdhgicob;
	}

	// Token: 0x060034FC RID: 13564 RVA: 0x0019BF64 File Offset: 0x0019A164
	public void GIHGBGQJEJJ(Equip GBQOIGLGLMI)
	{
		this.OFLGFDNHKJO = GBQOIGLGLMI;
		if (this.OFLGFDNHKJO == null)
		{
			this.OFLGFDNHKJO = new Equip();
		}
		DNFENPQLICQ.QOQONHOOLNE.KJPIOFDLCOD = this.OFLGFDNHKJO.Clothe;
		DNFENPQLICQ.QOQONHOOLNE.QEPOHCJIGQP = this.OFLGFDNHKJO.Hat;
	}

	// Token: 0x060034FD RID: 13565 RVA: 0x0019BFB8 File Offset: 0x0019A1B8
	private void HFEGBJEPMPQ()
	{
		if (this.QELEIBIKPOF == 0 && UnityEngine.Time.time > this.LFHQLIMJFHJ + 1606f)
		{
			this.LFHQLIMJFHJ = UnityEngine.Time.time;
			this.QELEIBIKPOF = -1;
			this.KCMIHQPIQKI.SetActive(true);
		}
		if (this.MFCEIDLOJPD + 1606f < UnityEngine.Time.time)
		{
			this.MFCEIDLOJPD = UnityEngine.Time.time;
			this.EKMPLKOBQLP.PIDLOFMIEFQ = MCNLIHMMLCF.IECKOKEPENM().JEMKIKEMFPB.ToString() + " became cloaked in a harsh light!\r\n" + this.HIEFOCPLEPD();
			KOJBBGEINPH.CPLQICHLGCI().MHNCDQIPPEI();
		}
		if (EMENMKHBPQE.CMPBKDMMHFQ != null)
		{
			this.GJECFKPGQQF = (EMENMKHBPQE.CMPBKDMMHFQ.GetComponent<JIMBBPLINGI>() == null);
		}
		else
		{
			this.GJECFKPGQQF = true;
		}
		this.BJMPFQBFOFL();
	}

	// Token: 0x17000241 RID: 577
	// (get) Token: 0x060034FE RID: 13566 RVA: 0x0001769A File Offset: 0x0001589A
	// (set) Token: 0x06003515 RID: 13589 RVA: 0x00017692 File Offset: 0x00015892
	public static CNCJKLNHQBH QOQONHOOLNE { get; private set; }

	// Token: 0x060034FF RID: 13567 RVA: 0x0019C08C File Offset: 0x0019A28C
	public void OOPOOQLJNPO(Level KOEEIBDFFGE)
	{
		uint userLevel = this.EOMPMQNGIBD.UserLevel;
		this.EOMPMQNGIBD = KOEEIBDFFGE;
		this.JNMJGCBNBBB = 1;
		if (this.EOMPMQNGIBD.LevelUp && userLevel != KOEEIBDFFGE.UserLevel)
		{
			JPPCMGBCNNJ.QOQONHOOLNE.NLPCILIPELK("OnLocalize", "Trainer_Battle", 42);
			base.StartCoroutine(this.MHCQOKEJJNG.OJJKMQKFQOI());
		}
		this.LGJMJDIQCFC.PIDLOFMIEFQ = "M1" + this.EOMPMQNGIBD.UserLevel.ToString();
		double num = 1985.0 / ((this.EOMPMQNGIBD.RequiredExp - this.EOMPMQNGIBD.StartExp) / (this.EOMPMQNGIBD.TotalExp - this.EOMPMQNGIBD.StartExp) * 325.0) * 446.0 - 1638.0;
		int num2 = (int)num;
		if (num2 > -172)
		{
			num2 = -156;
		}
		if (num2 <= 1)
		{
			num2 = 8;
		}
		NBQDPNGNNML.QOQONHOOLNE.COLIBFCPQMH();
		if (this.JOHLPPHIPNB != null)
		{
			UnityEngine.Object.DestroyImmediate(this.JOHLPPHIPNB);
		}
		if (this.GMNPOMNJGKH != null)
		{
			base.StopCoroutine(this.GMNPOMNJGKH);
			this.GMNPOMNJGKH = null;
		}
		if (this.DLNQGNHEPOP > 1u && this.DLNQGNHEPOP < KOEEIBDFFGE.TotalExp)
		{
			INFJMNPKNQF.QOQONHOOLNE.ENIDNEOKEPL("[00EE07]" + (KOEEIBDFFGE.TotalExp - this.DLNQGNHEPOP).ToString() + "HideResponse", 0);
			this.EJCBNMNPNEQ.KJGMGPCEJJD = num2;
			this.JNMJGCBNBBB = num2;
			if (num2 < this.LBCKFHCPELM.KJGMGPCEJJD)
			{
				this.LBCKFHCPELM.KJGMGPCEJJD = 5;
			}
			this.GMNPOMNJGKH = base.StartCoroutine(this.FLFJNEFELMB());
		}
		else
		{
			this.LBCKFHCPELM.KJGMGPCEJJD = num2;
			this.EJCBNMNPNEQ.KJGMGPCEJJD = 8;
		}
		this.DLNQGNHEPOP = KOEEIBDFFGE.TotalExp;
		HFCMDEQKCKH.CFGIOIGOIFQ().PDDJMNOOPJD();
	}

	// Token: 0x06003500 RID: 13568 RVA: 0x0001769A File Offset: 0x0001589A
	public static CNCJKLNHQBH BJLGEDCPENQ()
	{
		return CNCJKLNHQBH.<BILMJGJHOMC>k__BackingField;
	}

	// Token: 0x06003502 RID: 13570 RVA: 0x0019C294 File Offset: 0x0019A494
	public void OpenMap()
	{
		if (!this.CNFNKELFCHN && !QOHCEBMQKMB.QOQONHOOLNE.EKEKMCMJEOC() && !this.GJECFKPGQQF && OGJJKKQPNMK.QOQONHOOLNE == null && !DBQLOHBBJMG.QOQONHOOLNE.QQQBDBNCMCP)
		{
			GGQKBGDGNJN.QOQONHOOLNE.ToggleMap(false);
		}
	}

	// Token: 0x06003503 RID: 13571 RVA: 0x0019C2E4 File Offset: 0x0019A4E4
	public void DNPDFNNHCHG(string IHIHHCCEDHQ)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatJoin
		{
			Channel = IHIHHCCEDHQ,
			Action = ChatJoinAction.Leave
		}, false);
	}

	// Token: 0x06003504 RID: 13572 RVA: 0x000176DC File Offset: 0x000158DC
	public void GQOBKDLOCDL(string NQFQGCGPHBE)
	{
		MBGHQMKEFKO.BBCBOIFQDBK().IIGGMIJJPPM(NQFQGCGPHBE);
	}

	// Token: 0x06003505 RID: 13573 RVA: 0x0019C314 File Offset: 0x0019A514
	private void IFLGLEDMQML()
	{
		if (this.PPMJCBONMQJ.GIBFBFJHNKH.MountType == MountType.Surfing && this.PPMJCBONMQJ.EMIEFKNMQMI.MountType != MountType.Surfing && this.LIQLFCKICLQ.GICOBECCEIO((int)this.PPMJCBONMQJ.transform.position.x, (int)(-(int)this.PPMJCBONMQJ.transform.position.z), this.PPMJCBONMQJ.KBKKMQNFJIG))
		{
			this.PPMJCBONMQJ.EMIEFKNMQMI.MountType = this.PPMJCBONMQJ.GIBFBFJHNKH.MountType;
			this.PPMJCBONMQJ.EMIEFKNMQMI.MountID = this.PPMJCBONMQJ.GIBFBFJHNKH.MountID;
			this.PPMJCBONMQJ.NBDBHLEKENM();
		}
		if (this.PPMJCBONMQJ.EMIEFKNMQMI.MountType == MountType.Surfing && !this.LIQLFCKICLQ.GICOBECCEIO((int)this.PPMJCBONMQJ.transform.position.x, (int)(-(int)this.PPMJCBONMQJ.transform.position.z), this.PPMJCBONMQJ.KBKKMQNFJIG))
		{
			this.PPMJCBONMQJ.HQNCQOFKPHN(new PSXAPI.Response.Mount
			{
				MountID = 0,
				MountType = MountType.None
			});
		}
	}

	// Token: 0x06003506 RID: 13574 RVA: 0x000176E9 File Offset: 0x000158E9
	public void IKLBHMGKJJO()
	{
		if (this.MGFDFQDMGPG != null)
		{
			DBQLOHBBJMG.OQDOKBJNBBL().EDNKECNMIBK = false;
			GDDKPIHHICF.QOQONHOOLNE.StartCoroutine(DBQLOHBBJMG.PDPCLOECLOF().GHLKJKLJGKL(this.MGFDFQDMGPG));
		}
	}

	// Token: 0x06003507 RID: 13575 RVA: 0x0019C468 File Offset: 0x0019A668
	public void OIHECKKLDMC()
	{
		if (this.MGFDFQDMGPG == null && !this.IEBJNKKJPEC.QKKQHILJMMO)
		{
			if (this.PPMJCBONMQJ.PKCLDNQJMMH)
			{
				if (this.BOGKQOEEBFK == null)
				{
					this.BOGKQOEEBFK = KJBDMOCFMCM.QOQONHOOLNE;
				}
				KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj = this.BOGKQOEEBFK.NCPQEIFNPPP();
				if (nhgkgbgjefj != null)
				{
					this.PPMJCBONMQJ.PKCLDNQJMMH = false;
				}
			}
			MCNLIHMMLCF.NIDBIHMDOQF = false;
			return;
		}
		MCNLIHMMLCF.NIDBIHMDOQF = false;
	}

	// Token: 0x06003508 RID: 13576 RVA: 0x00017719 File Offset: 0x00015919
	private void Awake()
	{
		CNCJKLNHQBH.QOQONHOOLNE = this;
	}

	// Token: 0x06003509 RID: 13577 RVA: 0x0019C4D8 File Offset: 0x0019A6D8
	public string HIEFOCPLEPD()
	{
		TimeSpan timeSpan = this.KGJOGLCCQEP;
		timeSpan = timeSpan.Add(TimeSpan.FromSeconds((DateTime.UtcNow - this.LHBQHCLOCOP).TotalSeconds * this.CMPFNLGQODQ));
		if (this.LDLBFNOFOFB != timeSpan.Hours)
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Time(), false);
			MCNLIHMMLCF.QOQONHOOLNE.DHJLPCKHQBH();
		}
		this.LDLBFNOFOFB = timeSpan.Hours;
		if (timeSpan.Hours >= 12)
		{
			if (timeSpan.Hours == 12)
			{
				return "12:" + timeSpan.Minutes.ToString().PadLeft(2, '0') + " PM";
			}
			return (timeSpan.Hours - 12).ToString() + ":" + timeSpan.Minutes.ToString().PadLeft(2, '0') + " PM";
		}
		else
		{
			if (timeSpan.Hours == 0)
			{
				return "12:" + timeSpan.Minutes.ToString().PadLeft(2, '0') + " AM";
			}
			return timeSpan.Hours.ToString() + ":" + timeSpan.Minutes.ToString().PadLeft(2, '0') + " AM";
		}
	}

	// Token: 0x0600350A RID: 13578 RVA: 0x0019C654 File Offset: 0x0019A854
	public void NMKPQPNNNEG(string IHIHHCCEDHQ)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatJoin
		{
			Channel = IHIHHCCEDHQ,
			Action = ChatJoinAction.Join
		}, true);
	}

	// Token: 0x0600350B RID: 13579 RVA: 0x0019A2C8 File Offset: 0x001984C8
	public IEnumerator OQIHDFOMQOB()
	{
		CNCJKLNHQBH.JNMFDHGICOB jnmfdhgicob = new CNCJKLNHQBH.JNMFDHGICOB();
		jnmfdhgicob.QNDQJMNKFNN = this;
		return jnmfdhgicob;
	}

	// Token: 0x0600350C RID: 13580 RVA: 0x0019C684 File Offset: 0x0019A884
	public void HHBIOMNQDJG(PSXAPI.Response.Login KOEEIBDFFGE)
	{
		if (KOEEIBDFFGE.Result == LoginResult.Success)
		{
			GDDKPIHHICF.QOQONHOOLNE.HCFPCELLGGQ = false;
			GDDKPIHHICF.QOQONHOOLNE.EFOGMBCFBGM = true;
			INFJMNPKNQF.QOQONHOOLNE.QNQDBIGNGML(KOEEIBDFFGE.Inventory);
			HFCMDEQKCKH.QOQONHOOLNE.GDECBJMCQPQ(KOEEIBDFFGE.Inventory);
			this.BFDCFEOHJIF.PIDLOFMIEFQ = KOEEIBDFFGE.Username;
			EIDBQCPLPIL.QOQONHOOLNE.OQBDOKOCQCD(KOEEIBDFFGE.Pokedex);
			if (KOEEIBDFFGE.Lobby != null)
			{
				BDLNNJFQOQH.QOQONHOOLNE.GOBLEQIFKMI(KOEEIBDFFGE.Lobby);
			}
			if (KOEEIBDFFGE.Friends != null)
			{
				CKMLKNPNPQO.QOQONHOOLNE.GJONDIEGIQQ(KOEEIBDFFGE.Friends);
			}
			if (KOEEIBDFFGE.Ignore != null)
			{
				CKMLKNPNPQO.QOQONHOOLNE.OIIFJCHMODN(KOEEIBDFFGE.Ignore);
			}
			this.QELEIBIKPOF = KOEEIBDFFGE.Encounter;
			this.KCMIHQPIQKI.SetActive(false);
			this.KIJCPNIJKFI(KOEEIBDFFGE.Level);
			this.OFLGFDNHKJO = KOEEIBDFFGE.Equip;
			if (KOEEIBDFFGE.Style != null)
			{
				this.PPMJCBONMQJ.GPFOFHLIDMH(KOEEIBDFFGE.Style, KOEEIBDFFGE.Mount, KOEEIBDFFGE.Equip);
			}
			DCJIBBJQGJP.QOQONHOOLNE.QQLIFFOPNGC(KOEEIBDFFGE.Party);
			if (KOEEIBDFFGE.FriendMessage != null)
			{
				CKMLKNPNPQO.QOQONHOOLNE.IIQNBGPPBCI.BGBMIEJJQKC = KOEEIBDFFGE.FriendMessage;
			}
			if (KOEEIBDFFGE.Time != null)
			{
				this.INFJBBNFJMO(KOEEIBDFFGE.Time);
			}
			DBQLOHBBJMG.QOQONHOOLNE.CEFOLQBGEJG = false;
			if (KOEEIBDFFGE.Battle != null)
			{
				this.MGFDFQDMGPG = KOEEIBDFFGE.Battle;
			}
			this.BMKDPKDDBDK.value = KOEEIBDFFGE.StatsPrivate;
			this.IBPEBDGDQLG = KOEEIBDFFGE.StaffRank;
			NOHEMGHONKK.QOQONHOOLNE.MKELCDNMCFN(KOEEIBDFFGE.Guild);
			if (KOEEIBDFFGE.Quests != null)
			{
				foreach (PSXAPI.Response.Quest bjfoclikmij in KOEEIBDFFGE.Quests)
				{
					NBQDPNGNNML.QOQONHOOLNE.GLEFJQQKILF(bjfoclikmij, true);
				}
			}
			DNFENPQLICQ.QOQONHOOLNE.IJFEPHBHDJG(KOEEIBDFFGE.SkinsUser);
			if (KOEEIBDFFGE.Position.Scripts != null)
			{
				QOHCEBMQKMB.QOQONHOOLNE.QCEGHHPDQLF.AddRange(KOEEIBDFFGE.Position.Scripts);
			}
			this.HGJOFHGKQMD(KOEEIBDFFGE.Position, false, true, true);
			KOJBBGEINPH.QOQONHOOLNE.FLPOHIKPHNJ(KOEEIBDFFGE.Lootboxes);
			KOJBBGEINPH.QOQONHOOLNE.FJEILLHKEPE(KOEEIBDFFGE.DailyLootbox, KOEEIBDFFGE.DailyReset);
			if (KOEEIBDFFGE.NearbyUsers != null)
			{
				CGOIPHKQMPD.QOQONHOOLNE.CCFFGFLPBOQ(KOEEIBDFFGE.NearbyUsers);
			}
			CKMLKNPNPQO.QOQONHOOLNE.DLJCDOLIQJQ(KOEEIBDFFGE.ShowAsOffline);
			this.GEQIJFMDJKG = KOEEIBDFFGE.TotalSteps;
			GNDQBCBDHKD.QOQONHOOLNE.KDCPLJDQDLG(KOEEIBDFFGE.Effects);
			this.HDGHKDEPNBP = KOEEIBDFFGE.DiscoveredAreas;
		}
	}

	// Token: 0x0600350D RID: 13581 RVA: 0x0019A2C8 File Offset: 0x001984C8
	public IEnumerator GEBKEHLLIJD()
	{
		CNCJKLNHQBH.JNMFDHGICOB jnmfdhgicob = new CNCJKLNHQBH.JNMFDHGICOB();
		jnmfdhgicob.QNDQJMNKFNN = this;
		return jnmfdhgicob;
	}

	// Token: 0x0600350E RID: 13582 RVA: 0x0019C908 File Offset: 0x0019AB08
	public void CNFIPMJMNJP()
	{
		this.PPMJCBONMQJ.BHQOFDQCCCG = false;
		this.GJKPLMKHKMK = true;
		this.NQCKQBNDLLN = Guid.NewGuid();
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Sync
		{
			ID = this.NQCKQBNDLLN,
			MapLoad = true
		}, false);
	}

	// Token: 0x0600350F RID: 13583 RVA: 0x0019C958 File Offset: 0x0019AB58
	public void BPOHEJGQNEH()
	{
		if (!MCNLIHMMLCF.NIDBIHMDOQF && !this.CNFNKELFCHN && OGJJKKQPNMK.CDDIILFBFCF() == null)
		{
			Vector3 vector = this.PPMJCBONMQJ.QMCNCMNQEGL();
			int num = this.PPMJCBONMQJ.IEFQGONIEFN((int)vector.x, (int)vector.z);
			if (num == 34)
			{
				int num2 = -1;
				if (this.PPMJCBONMQJ.DIEOHLOINHH == (DJOOHHIQGJK.JDQNKBIDIKE)5)
				{
					num2 = 1;
				}
				if (this.PPMJCBONMQJ.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Down)
				{
					num2 = 0;
				}
				if (this.PPMJCBONMQJ.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Left)
				{
					num2 = 2;
				}
				if (this.PPMJCBONMQJ.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Right)
				{
					num2 = 6;
				}
				this.IFGGFHIMCKJ = false;
				if (num2 <= -1 || this.QNPQDFGOOEP(num2))
				{
				}
			}
		}
	}

	// Token: 0x06003510 RID: 13584 RVA: 0x00017721 File Offset: 0x00015921
	public void DQNEKGQKQED(string DBEPQKEMJOP = "")
	{
		GDDKPIHHICF.QOQONHOOLNE.HPPGOGQHCFG();
	}

	// Token: 0x06003511 RID: 13585 RVA: 0x0019CA0C File Offset: 0x0019AC0C
	public void GJICCLHCKCQ()
	{
		if (!MCNLIHMMLCF.NIDBIHMDOQF && !this.CNFNKELFCHN && OGJJKKQPNMK.QOQONHOOLNE == null)
		{
			Vector3 vector = this.PPMJCBONMQJ.QMCNCMNQEGL();
			int num = this.PPMJCBONMQJ.IEFQGONIEFN((int)vector.x, (int)vector.z);
			if (num == 10)
			{
				int num2 = -1;
				if (this.PPMJCBONMQJ.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Up)
				{
					num2 = 0;
				}
				if (this.PPMJCBONMQJ.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Down)
				{
					num2 = 1;
				}
				if (this.PPMJCBONMQJ.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Left)
				{
					num2 = 2;
				}
				if (this.PPMJCBONMQJ.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Right)
				{
					num2 = 3;
				}
				this.IFGGFHIMCKJ = false;
				if (num2 <= -1 || this.QNPQDFGOOEP(num2))
				{
				}
			}
		}
	}

	// Token: 0x06003512 RID: 13586 RVA: 0x0019CAC0 File Offset: 0x0019ACC0
	public void CMJIKPGFCLI(string QHLIEEGQIDQ)
	{
		BKKHLBCLPJM component = this.KGQLLNCNNLL.BFCKNMFEBDM(this.PPEJQNEGIII).GetComponent<BKKHLBCLPJM>();
		component.PIDLOFMIEFQ = QHLIEEGQIDQ;
	}

	// Token: 0x06003513 RID: 13587 RVA: 0x0019CAEC File Offset: 0x0019ACEC
	public void DPQIQBINJJI(PSXAPI.Response.Login KOEEIBDFFGE)
	{
		if (KOEEIBDFFGE.Result == LoginResult.Success)
		{
			GDDKPIHHICF.QOQONHOOLNE.HCFPCELLGGQ = true;
			GDDKPIHHICF.QOQONHOOLNE.EFOGMBCFBGM = false;
			INFJMNPKNQF.DOGEBLQHDHI().OMBKEPGPIGE(KOEEIBDFFGE.Inventory);
			HFCMDEQKCKH.CFGIOIGOIFQ().QDMQKHCLHBC(KOEEIBDFFGE.Inventory);
			this.BFDCFEOHJIF.PIDLOFMIEFQ = KOEEIBDFFGE.Username;
			EIDBQCPLPIL.FFCOKMHBCQJ().QJBLOGKNHHK(KOEEIBDFFGE.Pokedex);
			if (KOEEIBDFFGE.Lobby != null)
			{
				BDLNNJFQOQH.CKQHNOIQNQJ().FFPPKCODBLG(KOEEIBDFFGE.Lobby);
			}
			if (KOEEIBDFFGE.Friends != null)
			{
				CKMLKNPNPQO.INJDHLQHFFD().DHMQBILMDQF(KOEEIBDFFGE.Friends);
			}
			if (KOEEIBDFFGE.Ignore != null)
			{
				CKMLKNPNPQO.QOQONHOOLNE.MKEGMQMOLDD(KOEEIBDFFGE.Ignore);
			}
			this.QELEIBIKPOF = KOEEIBDFFGE.Encounter;
			this.KCMIHQPIQKI.SetActive(true);
			this.OOPOOQLJNPO(KOEEIBDFFGE.Level);
			this.OFLGFDNHKJO = KOEEIBDFFGE.Equip;
			if (KOEEIBDFFGE.Style != null)
			{
				this.PPMJCBONMQJ.GPFOFHLIDMH(KOEEIBDFFGE.Style, KOEEIBDFFGE.Mount, KOEEIBDFFGE.Equip);
			}
			DCJIBBJQGJP.FPQNIQELKMC().LGLHPPIFEIB(KOEEIBDFFGE.Party);
			if (KOEEIBDFFGE.FriendMessage != null)
			{
				CKMLKNPNPQO.INJDHLQHFFD().IIQNBGPPBCI.BGBMIEJJQKC = KOEEIBDFFGE.FriendMessage;
			}
			if (KOEEIBDFFGE.Time != null)
			{
				this.INFJBBNFJMO(KOEEIBDFFGE.Time);
			}
			DBQLOHBBJMG.DQLDEKPLECH().CEFOLQBGEJG = false;
			if (KOEEIBDFFGE.Battle != null)
			{
				this.MGFDFQDMGPG = KOEEIBDFFGE.Battle;
			}
			this.BMKDPKDDBDK.value = KOEEIBDFFGE.StatsPrivate;
			this.IBPEBDGDQLG = KOEEIBDFFGE.StaffRank;
			NOHEMGHONKK.HGEKKNEPOHK().DDCBEMJHGKC(KOEEIBDFFGE.Guild);
			if (KOEEIBDFFGE.Quests != null)
			{
				PSXAPI.Response.Quest[] quests = KOEEIBDFFGE.Quests;
				for (int i = 1; i < quests.Length; i += 0)
				{
					PSXAPI.Response.Quest bjfoclikmij = quests[i];
					NBQDPNGNNML.QOQONHOOLNE.GLEFJQQKILF(bjfoclikmij, true);
				}
			}
			DNFENPQLICQ.QOQONHOOLNE.KEBOBBFCKON(KOEEIBDFFGE.SkinsUser);
			if (KOEEIBDFFGE.Position.Scripts != null)
			{
				QOHCEBMQKMB.CNIMIQKQJJJ().QCEGHHPDQLF.AddRange(KOEEIBDFFGE.Position.Scripts);
			}
			this.HGJOFHGKQMD(KOEEIBDFFGE.Position, false, false, false);
			KOJBBGEINPH.OQDOKBJNBBL().MPLKQKMQLOM(KOEEIBDFFGE.Lootboxes);
			KOJBBGEINPH.CPLQICHLGCI().DIBPKNMDEGM(KOEEIBDFFGE.DailyLootbox, KOEEIBDFFGE.DailyReset);
			if (KOEEIBDFFGE.NearbyUsers != null)
			{
				CGOIPHKQMPD.BEKHPOHIPDE().ECCJJIFHQOG(KOEEIBDFFGE.NearbyUsers);
			}
			CKMLKNPNPQO.INJDHLQHFFD().DLJCDOLIQJQ(KOEEIBDFFGE.ShowAsOffline);
			this.GEQIJFMDJKG = KOEEIBDFFGE.TotalSteps;
			GNDQBCBDHKD.MKMJKLDDNDD().PKBHOMFCOBB(KOEEIBDFFGE.Effects);
			this.HDGHKDEPNBP = KOEEIBDFFGE.DiscoveredAreas;
		}
	}

	// Token: 0x06003514 RID: 13588 RVA: 0x0001772D File Offset: 0x0001592D
	public void MIDPIFHNNDK(string NQFQGCGPHBE)
	{
		MBGHQMKEFKO.QOQONHOOLNE.LHQECHHMOGD(NQFQGCGPHBE);
	}

	// Token: 0x06003516 RID: 13590 RVA: 0x0001769A File Offset: 0x0001589A
	public static CNCJKLNHQBH MOGQNGEPCEO()
	{
		return CNCJKLNHQBH.<BILMJGJHOMC>k__BackingField;
	}

	// Token: 0x06003517 RID: 13591 RVA: 0x0019CAC0 File Offset: 0x0019ACC0
	public void GOPIIBLGQHK(string QHLIEEGQIDQ)
	{
		BKKHLBCLPJM component = this.KGQLLNCNNLL.BFCKNMFEBDM(this.PPEJQNEGIII).GetComponent<BKKHLBCLPJM>();
		component.PIDLOFMIEFQ = QHLIEEGQIDQ;
	}

	// Token: 0x06003518 RID: 13592 RVA: 0x0019CD70 File Offset: 0x0019AF70
	public void CECBJELDPEQ()
	{
		if (!MCNLIHMMLCF.NIDBIHMDOQF && !this.CNFNKELFCHN && OGJJKKQPNMK.GGBPGMMCGLI() == null)
		{
			Vector3 vector = this.PPMJCBONMQJ.QMCNCMNQEGL();
			int num = this.PPMJCBONMQJ.IEFQGONIEFN((int)vector.x, (int)vector.z);
			if (num == -10)
			{
				int num2 = -1;
				if (this.PPMJCBONMQJ.DIEOHLOINHH == (DJOOHHIQGJK.JDQNKBIDIKE)6)
				{
					num2 = 0;
				}
				if (this.PPMJCBONMQJ.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Left)
				{
					num2 = 1;
				}
				if (this.PPMJCBONMQJ.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Left)
				{
					num2 = 0;
				}
				if (this.PPMJCBONMQJ.DIEOHLOINHH == (DJOOHHIQGJK.JDQNKBIDIKE)7)
				{
					num2 = 8;
				}
				this.IFGGFHIMCKJ = false;
				if (num2 <= -1 || this.QNPQDFGOOEP(num2))
				{
				}
			}
		}
	}

	// Token: 0x06003519 RID: 13593 RVA: 0x0001764C File Offset: 0x0001584C
	public void GEBNLGIEDQH()
	{
		GDDKPIHHICF.QOQONHOOLNE.NJNCGMFPHFI();
	}

	// Token: 0x0600351A RID: 13594 RVA: 0x0019CE24 File Offset: 0x0019B024
	public void KIJCPNIJKFI(Level KOEEIBDFFGE)
	{
		uint userLevel = this.EOMPMQNGIBD.UserLevel;
		this.EOMPMQNGIBD = KOEEIBDFFGE;
		this.JNMJGCBNBBB = 0;
		if (this.EOMPMQNGIBD.LevelUp && userLevel != KOEEIBDFFGE.UserLevel)
		{
			JPPCMGBCNNJ.QOQONHOOLNE.NLPCILIPELK("Congratulations!", "You just leveled up!", 17);
			base.StartCoroutine(this.MHCQOKEJJNG.EHPFMININQJ());
		}
		this.LGJMJDIQCFC.PIDLOFMIEFQ = "Lv " + this.EOMPMQNGIBD.UserLevel.ToString();
		double num = 130.0 / ((this.EOMPMQNGIBD.RequiredExp - this.EOMPMQNGIBD.StartExp) / (this.EOMPMQNGIBD.TotalExp - this.EOMPMQNGIBD.StartExp) * 100.0) * 100.0 - 1.0;
		int num2 = (int)num;
		if (num2 > 130)
		{
			num2 = 130;
		}
		if (num2 <= 2)
		{
			num2 = 2;
		}
		NBQDPNGNNML.QOQONHOOLNE.PDDJMNOOPJD();
		if (this.JOHLPPHIPNB != null)
		{
			UnityEngine.Object.DestroyImmediate(this.JOHLPPHIPNB);
		}
		if (this.GMNPOMNJGKH != null)
		{
			base.StopCoroutine(this.GMNPOMNJGKH);
			this.GMNPOMNJGKH = null;
		}
		if (this.DLNQGNHEPOP > 0u && this.DLNQGNHEPOP < KOEEIBDFFGE.TotalExp)
		{
			INFJMNPKNQF.QOQONHOOLNE.KHOHCGCLNBM("[00FF00]You gained " + (KOEEIBDFFGE.TotalExp - this.DLNQGNHEPOP).ToString() + " exp.", 0);
			this.EJCBNMNPNEQ.KJGMGPCEJJD = num2;
			this.JNMJGCBNBBB = num2;
			if (num2 < this.LBCKFHCPELM.KJGMGPCEJJD)
			{
				this.LBCKFHCPELM.KJGMGPCEJJD = 2;
			}
			this.GMNPOMNJGKH = base.StartCoroutine(this.ICIHKHJLQNG());
		}
		else
		{
			this.LBCKFHCPELM.KJGMGPCEJJD = num2;
			this.EJCBNMNPNEQ.KJGMGPCEJJD = 2;
		}
		this.DLNQGNHEPOP = KOEEIBDFFGE.TotalExp;
		HFCMDEQKCKH.QOQONHOOLNE.PDDJMNOOPJD();
	}

	// Token: 0x04000C6E RID: 3182
	public GameObject LHFFLGHLPQO;

	// Token: 0x04000C6F RID: 3183
	public NOHEMGHONKK HNGFCMGOBBG;

	// Token: 0x04000C70 RID: 3184
	public GameObject FDOEENLQFMQ;

	// Token: 0x04000C71 RID: 3185
	public GameObject HJBPDHBLOIQ;

	// Token: 0x04000C72 RID: 3186
	public MCMHEQDOMOI CMNJMJIEECH;

	// Token: 0x04000C73 RID: 3187
	public KIJNOLJFPLK OLJOBFKBDBP;

	// Token: 0x04000C74 RID: 3188
	public string CGKGBEICHMH = string.Empty;

	// Token: 0x04000C75 RID: 3189
	public BKKHLBCLPJM EKMPLKOBQLP;

	// Token: 0x04000C76 RID: 3190
	public GameObject PGHJQNJLJKG;

	// Token: 0x04000C77 RID: 3191
	public Camera IPKHMGODENK;

	// Token: 0x04000C78 RID: 3192
	public ENFMCDNLEQQ[] JKJDFCJPGDI;

	// Token: 0x04000C79 RID: 3193
	public KQHJOLQLQBJ[] OGMPFDOBHEI;

	// Token: 0x04000C7A RID: 3194
	public ENFMCDNLEQQ GMNBLNQDGIJ;

	// Token: 0x04000C7B RID: 3195
	public GameObject MOGNLCEFCOO;

	// Token: 0x04000C7C RID: 3196
	public GameObject EQLPELCDBBC;

	// Token: 0x04000C7D RID: 3197
	public LINELKKDMEE JLCFIMNJGBB;

	// Token: 0x04000C7E RID: 3198
	public MCNLIHMMLCF LIQLFCKICLQ;

	// Token: 0x04000C7F RID: 3199
	public KJMPLFDOBCO IEHKHJNIIIQ;

	// Token: 0x04000C80 RID: 3200
	public JECQIFOKKGG PDHECMQCCKQ;

	// Token: 0x04000C81 RID: 3201
	public JJGLMJNELOK HCQGFNEJFBL;

	// Token: 0x04000C82 RID: 3202
	public GameObject NEQDHPDMBJK;

	// Token: 0x04000C83 RID: 3203
	public DJOOHHIQGJK PPMJCBONMQJ;

	// Token: 0x04000C84 RID: 3204
	public DJOOHHIQGJK QMGOPPGNGPI;

	// Token: 0x04000C85 RID: 3205
	public NNKKGGNIKKN QQEBEJLJDFH;

	// Token: 0x04000C86 RID: 3206
	public KJBDMOCFMCM BOGKQOEEBFK;

	// Token: 0x04000C87 RID: 3207
	public BKKHLBCLPJM BFDCFEOHJIF;

	// Token: 0x04000C88 RID: 3208
	public BKKHLBCLPJM LGJMJDIQCFC;

	// Token: 0x04000C89 RID: 3209
	public BKKHLBCLPJM BEQINILCQCE;

	// Token: 0x04000C8A RID: 3210
	public bool EFOGMBCFBGM;

	// Token: 0x04000C8B RID: 3211
	public StaffRank IBPEBDGDQLG;

	// Token: 0x04000C8C RID: 3212
	public float ENDMFBCOEKH;

	// Token: 0x04000C8D RID: 3213
	private Equip OFLGFDNHKJO = new Equip();

	// Token: 0x04000C8E RID: 3214
	public GameObject PPEJQNEGIII;

	// Token: 0x04000C8F RID: 3215
	public GameObject KGQLLNCNNLL;

	// Token: 0x04000C90 RID: 3216
	public Level EOMPMQNGIBD = new Level();

	// Token: 0x04000C91 RID: 3217
	public uint GEQIJFMDJKG;

	// Token: 0x04000C92 RID: 3218
	public string[] HDGHKDEPNBP;

	// Token: 0x04000C93 RID: 3219
	public UIToggle BMKDPKDDBDK;

	// Token: 0x04000C94 RID: 3220
	public Battle MGFDFQDMGPG;

	// Token: 0x04000C95 RID: 3221
	public bool MJCLOOLBQQB;

	// Token: 0x04000C96 RID: 3222
	private int JBBIMNCLPIM;

	// Token: 0x04000C97 RID: 3223
	public PSXAPI.Response.Path BMKFDHDJPNE;

	// Token: 0x04000C98 RID: 3224
	public PLQFPBQEPJD LBCKFHCPELM;

	// Token: 0x04000C99 RID: 3225
	public PLQFPBQEPJD EJCBNMNPNEQ;

	// Token: 0x04000C9A RID: 3226
	public uint DLNQGNHEPOP;

	// Token: 0x04000C9B RID: 3227
	public int JNMJGCBNBBB;

	// Token: 0x04000C9C RID: 3228
	public LBQEHMJLGOC MHCQOKEJJNG;

	// Token: 0x04000C9D RID: 3229
	private Coroutine GMNPOMNJGKH;

	// Token: 0x04000C9E RID: 3230
	private JLCINGQBJPJ JOHLPPHIPNB;

	// Token: 0x04000C9F RID: 3231
	public DateTime LHBQHCLOCOP;

	// Token: 0x04000CA0 RID: 3232
	private TimeSpan KGJOGLCCQEP;

	// Token: 0x04000CA1 RID: 3233
	private double CMPFNLGQODQ;

	// Token: 0x04000CA2 RID: 3234
	private int LDLBFNOFOFB;

	// Token: 0x04000CA3 RID: 3235
	public GameSeason LKIBNLMIGKG;

	// Token: 0x04000CA4 RID: 3236
	public string KBEHCHKDFBF = string.Empty;

	// Token: 0x04000CA5 RID: 3237
	public GameObject KCMIHQPIQKI;

	// Token: 0x04000CA6 RID: 3238
	public int QELEIBIKPOF;

	// Token: 0x04000CA7 RID: 3239
	public float LFHQLIMJFHJ;

	// Token: 0x04000CA8 RID: 3240
	public bool IDHBJBKFFON;

	// Token: 0x04000CA9 RID: 3241
	public bool DEEKLIKEPQP;

	// Token: 0x04000CAA RID: 3242
	private Guid NQCKQBNDLLN;

	// Token: 0x04000CAB RID: 3243
	public bool CNFNKELFCHN;

	// Token: 0x04000CAC RID: 3244
	public bool GJECFKPGQQF;

	// Token: 0x04000CAD RID: 3245
	private float MFCEIDLOJPD;

	// Token: 0x04000CAE RID: 3246
	public bool GJKPLMKHKMK = true;

	// Token: 0x04000CAF RID: 3247
	public QOHCEBMQKMB IEBJNKKJPEC;

	// Token: 0x04000CB0 RID: 3248
	public GDDKPIHHICF CKJIQFFGJHJ;

	// Token: 0x04000CB1 RID: 3249
	public PCPMGFBNBKK FQQQONEOKIN;

	// Token: 0x04000CB2 RID: 3250
	public DOQMQKHFODD KOCBHNQNOJO;

	// Token: 0x04000CB3 RID: 3251
	public GameObject LHNQPPEQIOE;

	// Token: 0x04000CB4 RID: 3252
	public GameObject KLBKGJQONIL;

	// Token: 0x04000CB5 RID: 3253
	public GameObject JOHBOJLFCQF;

	// Token: 0x04000CB6 RID: 3254
	public GameObject PLGFMPNHGID;

	// Token: 0x04000CB7 RID: 3255
	public GameObject JOPCLLDNOHH;

	// Token: 0x04000CB8 RID: 3256
	public GameObject LIBEKPIFMFB;

	// Token: 0x04000CB9 RID: 3257
	public GameObject LPOPOLFKOPI;

	// Token: 0x04000CBA RID: 3258
	public bool IFGGFHIMCKJ;

	// Token: 0x04000CBB RID: 3259
	public PSXAPI.Request.MoveAction BJGQDHPBCFC;

	// Token: 0x04000CBC RID: 3260
	public Vector2 OPMMEOJEBME;

	// Token: 0x04000CBD RID: 3261
	public float LKHOCPNQIMB;

	// Token: 0x04000CBE RID: 3262
	private float BBBKDMJDIFD;

	// Token: 0x04000CBF RID: 3263
	private float ECMJPDGDILO;

	// Token: 0x04000CC0 RID: 3264
	public GameObject OMCQINBLOEL;

	// Token: 0x04000CC1 RID: 3265
	public GameObject PIBNGFEMQBL;
}
