using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;
using PSXAPI;
using PSXAPI.Request;
using PSXAPI.Response;
using PSXAPI.Response.Payload;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000227 RID: 551
public class GDDKPIHHICF : MonoBehaviour
{
	// Token: 0x06004B08 RID: 19208 RVA: 0x00268ABC File Offset: 0x00266CBC
	private void Awake()
	{
		GDDKPIHHICF.HBFFCJHOCPE = this;
		string name = "Global\\{B1E7934A-F688-417f-8FCB-65C3995E9E27}";
		MutexAccessRule rule = new MutexAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), MutexRights.FullControl, AccessControlType.Allow);
		MutexSecurity mutexSecurity = new MutexSecurity();
		mutexSecurity.AddAccessRule(rule);
		bool flag;
		this.DGDPEFQHILI = new Mutex(false, name, ref flag, mutexSecurity);
		this.BIECICNHDLK = false;
		try
		{
			this.BIECICNHDLK = this.DGDPEFQHILI.WaitOne(5000, false);
			if (!this.BIECICNHDLK)
			{
				Application.Quit();
			}
		}
		catch (AbandonedMutexException)
		{
			this.BIECICNHDLK = true;
		}
		finally
		{
		}
	}

	// Token: 0x06004B09 RID: 19209 RVA: 0x00268B5C File Offset: 0x00266D5C
	public void KNFHIKIONMF(IProto DCGCLGQCGDQ, bool OIMBKLCGOIG = false)
	{
		if (GDDKPIHHICF.HBFFCJHOCPE != null)
		{
			if (!OIMBKLCGOIG && DCGCLGQCGDQ is PSXAPI.Request.Move)
			{
				if (this.JIKKBCNDLOC.Count > 0 && this.JIKKBCNDLOC[this.JIKKBCNDLOC.Count - 1].Map != ((PSXAPI.Request.Move)DCGCLGQCGDQ).Map)
				{
					this.PDKBHHPOQPJ();
				}
				if (this.JIKKBCNDLOC.Count == 0)
				{
					this.IMQNHDIEFMM = UnityEngine.Time.time;
				}
				if (UnityEngine.Time.time < this.IMQNHDIEFMM + this.COFDEBBQNKF)
				{
					this.JIKKBCNDLOC.Add((PSXAPI.Request.Move)DCGCLGQCGDQ);
					if (QOHCEBMQKMB.QOQONHOOLNE.DLNELFIPOHB())
					{
						this.PDKBHHPOQPJ();
					}
					return;
				}
				this.PDKBHHPOQPJ();
			}
			if (this.OGIIKDBIMIK)
			{
				this.NKIJOONCCDQ.Enqueue(DCGCLGQCGDQ);
				base.StartCoroutine(this.OOQMPLNGGJJ());
			}
			else
			{
				GDDKPIHHICF.HBFFCJHOCPE.CBMLQJPGPMO.Send(DCGCLGQCGDQ);
			}
		}
	}

	// Token: 0x06004B0A RID: 19210 RVA: 0x00268C58 File Offset: 0x00266E58
	private IEnumerator OFDFIPBCNKF()
	{
		yield return new WaitForSeconds(this.FNDBKCIPBKO);
		return 1;
		if (this.NKIJOONCCDQ.Count <= 0)
		{
			goto IL_77;
		}
		GDDKPIHHICF.HBFFCJHOCPE.CBMLQJPGPMO.Send(this.NKIJOONCCDQ.Dequeue());
		IL_77:
		yield break;
	}

	// Token: 0x06004B0B RID: 19211 RVA: 0x00268C74 File Offset: 0x00266E74
	private void JHQCMGKJCCI()
	{
		if (GameObject.Find("No camera found for layer "))
		{
			UnityEngine.Object.Destroy(GameObject.Find("[-]"));
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		base.gameObject.name = "Plant";
		KGQECFKLKOP.GKHNLKOPGGD();
		this.QQEBEJLJDFH = base.GetComponent<NNKKGGNIKKN>();
		if (PlayerPrefs.GetInt("grassyterrain") == 1)
		{
			this.HNNDDLEPMHD.value = true;
			this.QIOFBCDMLCB.BGBMIEJJQKC = PlayerPrefs.GetString(".", string.Empty);
			this.LFGLJBKOFIN.BGBMIEJJQKC = PlayerPrefs.GetString("whitesmoke", string.Empty);
		}
		else
		{
			this.HNNDDLEPMHD.value = false;
		}
		this.CCOFBCLEMGO();
	}

	// Token: 0x06004B0C RID: 19212 RVA: 0x00268D30 File Offset: 0x00266F30
	public void KIDKGONQBQD(PSXAPI.Response.VerifyEmail BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Result == VerifyEmailResult.Verified)
		{
			this.OBCNMKNGFIF("Verification", "Congratulations " + BJGCBDNBQCJ.Username + "! Your account has been verified, you may now log in.", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, true);
			ENEINMKKFHQ.QOQONHOOLNE.Close();
			this.NJNCGMFPHFI();
		}
		else if (BJGCBDNBQCJ.Result == VerifyEmailResult.Resent)
		{
			this.OBCNMKNGFIF("Verification", "An email containing a new verification code has been sent.", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, true);
			ENEINMKKFHQ.QOQONHOOLNE.Open();
		}
		else if (BJGCBDNBQCJ.Result == VerifyEmailResult.Failed)
		{
			this.OBCNMKNGFIF("Verification", "Unable to verify account, please check your code and try again.", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, true);
			ENEINMKKFHQ.QOQONHOOLNE.Open();
		}
	}

	// Token: 0x06004B0D RID: 19213 RVA: 0x00268DD4 File Offset: 0x00266FD4
	public void OPBDELJELEP()
	{
		if (!this.EFOGMBCFBGM && !this.ODOGMJJQQKE && !this.HCFPCELLGGQ)
		{
			if (this.QIOFBCDMLCB.HJMJDJKOILH().Length < 4 || this.LFGLJBKOFIN.BGBMIEJJQKC.Length < 1)
			{
				return;
			}
			this.HCFPCELLGGQ = false;
			this.BEDINLHEHDB.LKPOBCBOFIC(string.Empty);
			this.BEDINLHEHDB.transform.parent.gameObject.SetActive(true);
			this.LQFIDMKBJBF.SetActive(false);
			this.NCBPEGNKKCM = false;
			if (this.JOQBIMQCNDO)
			{
				base.CancelInvoke("´");
				this.BEDINLHEHDB.PIDLOFMIEFQ = "HideResponse";
				this.LQFIDMKBJBF.SetActive(false);
				this.NCBPEGNKKCM = false;
				this.CCOFBCLEMGO();
				PSXAPI.Request.Login dcgclgqcgdq = new PSXAPI.Request.Login
				{
					Name = this.QIOFBCDMLCB.BGBMIEJJQKC,
					Password = this.LFGLJBKOFIN.HJMJDJKOILH(),
					Platform = ClientPlatform.None,
					Version = this.QLPEFCHNPQG
				};
				this.KNFHIKIONMF(dcgclgqcgdq, false);
				return;
			}
			this.EPNBECQFKEK();
		}
	}

	// Token: 0x06004B0E RID: 19214 RVA: 0x0001F13C File Offset: 0x0001D33C
	private void HideResponse()
	{
		if (this.BEDINLHEHDB != null)
		{
			this.BEDINLHEHDB.transform.parent.gameObject.SetActive(false);
		}
	}

	// Token: 0x06004B0F RID: 19215 RVA: 0x00268F00 File Offset: 0x00267100
	private void CBLIFECCHIC()
	{
		GDDKPIHHICF.HBFFCJHOCPE = this;
		string name = "deltrastream";
		MutexAccessRule rule = new MutexAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), (MutexRights)30, AccessControlType.Allow);
		MutexSecurity mutexSecurity = new MutexSecurity();
		mutexSecurity.AddAccessRule(rule);
		bool flag;
		this.DGDPEFQHILI = new Mutex(true, name, ref flag, mutexSecurity);
		this.BIECICNHDLK = false;
		try
		{
			this.BIECICNHDLK = this.DGDPEFQHILI.WaitOne(116, true);
			if (!this.BIECICNHDLK)
			{
				Application.Quit();
			}
		}
		catch (AbandonedMutexException)
		{
			this.BIECICNHDLK = true;
		}
		finally
		{
		}
	}

	// Token: 0x06004B10 RID: 19216 RVA: 0x0001F167 File Offset: 0x0001D367
	public void CCOFBCLEMGO()
	{
		NBQDPNGNNML.QOQONHOOLNE = null;
		QOHCEBMQKMB.QOQONHOOLNE = null;
	}

	// Token: 0x06004B11 RID: 19217 RVA: 0x0001F13C File Offset: 0x0001D33C
	private void FGGMCOMIGJI()
	{
		if (this.BEDINLHEHDB != null)
		{
			this.BEDINLHEHDB.transform.parent.gameObject.SetActive(false);
		}
	}

	// Token: 0x06004B12 RID: 19218 RVA: 0x00268FA0 File Offset: 0x002671A0
	public void KKQGLJGFMKO()
	{
		if (!this.EFOGMBCFBGM && !this.ODOGMJJQQKE && !this.HCFPCELLGGQ)
		{
			if (this.QIOFBCDMLCB.BGBMIEJJQKC.Length < 2 || this.LFGLJBKOFIN.HJMJDJKOILH().Length < 3)
			{
				return;
			}
			this.HCFPCELLGGQ = false;
			this.BEDINLHEHDB.LKPOBCBOFIC(string.Empty);
			this.BEDINLHEHDB.transform.parent.gameObject.SetActive(false);
			this.LQFIDMKBJBF.SetActive(true);
			this.NCBPEGNKKCM = true;
			if (this.JOQBIMQCNDO)
			{
				base.CancelInvoke("inky");
				this.BEDINLHEHDB.LKPOBCBOFIC("Parallax");
				this.LQFIDMKBJBF.SetActive(true);
				this.NCBPEGNKKCM = true;
				this.CCOFBCLEMGO();
				PSXAPI.Request.Login dcgclgqcgdq = new PSXAPI.Request.Login
				{
					Name = this.QIOFBCDMLCB.HJMJDJKOILH(),
					Password = this.LFGLJBKOFIN.HJMJDJKOILH(),
					Platform = ClientPlatform.None,
					Version = this.QLPEFCHNPQG
				};
				this.KNFHIKIONMF(dcgclgqcgdq, false);
				return;
			}
			this.EPNBECQFKEK();
		}
	}

	// Token: 0x06004B13 RID: 19219 RVA: 0x002690CC File Offset: 0x002672CC
	public void PDKBHHPOQPJ()
	{
		this.IMQNHDIEFMM = UnityEngine.Time.time;
		if (this.JIKKBCNDLOC.Count > 0)
		{
			List<PSXAPI.Request.MoveAction> list = new List<PSXAPI.Request.MoveAction>();
			int i = 0;
			while (i < this.JIKKBCNDLOC.Count)
			{
				if (i + 1 >= this.JIKKBCNDLOC.Count)
				{
					goto IL_FF;
				}
				if (this.JIKKBCNDLOC[i].Actions[0] != PSXAPI.Request.MoveAction.TurnDown || this.JIKKBCNDLOC[i + 1].Actions[0] != PSXAPI.Request.MoveAction.Down)
				{
					if (this.JIKKBCNDLOC[i].Actions[0] != PSXAPI.Request.MoveAction.TurnLeft || this.JIKKBCNDLOC[i + 1].Actions[0] != PSXAPI.Request.MoveAction.Left)
					{
						if (this.JIKKBCNDLOC[i].Actions[0] != PSXAPI.Request.MoveAction.TurnRight || this.JIKKBCNDLOC[i + 1].Actions[0] != PSXAPI.Request.MoveAction.Right)
						{
							if (this.JIKKBCNDLOC[i].Actions[0] != PSXAPI.Request.MoveAction.TurnUp || this.JIKKBCNDLOC[i + 1].Actions[0] != PSXAPI.Request.MoveAction.Up)
							{
								goto IL_FF;
							}
						}
					}
				}
				IL_118:
				i++;
				continue;
				IL_FF:
				list.Add(this.JIKKBCNDLOC[i].Actions[0]);
				goto IL_118;
			}
			this.HLIOFPONLLE(new PSXAPI.Request.Move
			{
				Actions = list.ToArray(),
				Map = this.JIKKBCNDLOC[0].Map,
				X = this.JIKKBCNDLOC[0].X,
				Y = this.JIKKBCNDLOC[0].Y
			}, true);
			this.JIKKBCNDLOC.Clear();
		}
	}

	// Token: 0x06004B14 RID: 19220 RVA: 0x0001F13C File Offset: 0x0001D33C
	private void HOFFKGEKPCN()
	{
		if (this.BEDINLHEHDB != null)
		{
			this.BEDINLHEHDB.transform.parent.gameObject.SetActive(false);
		}
	}

	// Token: 0x06004B15 RID: 19221 RVA: 0x0001F175 File Offset: 0x0001D375
	private void OnApplicationQuit()
	{
		if (this.CBMLQJPGPMO != null)
		{
			this.CBMLQJPGPMO.Disconnect();
		}
		this.CBMLQJPGPMO = null;
		if (this.BIECICNHDLK)
		{
			this.DGDPEFQHILI.ReleaseMutex();
		}
		this.DGDPEFQHILI.Dispose();
	}

	// Token: 0x170002A4 RID: 676
	// (get) Token: 0x06004B16 RID: 19222 RVA: 0x0001F1AF File Offset: 0x0001D3AF
	public static GDDKPIHHICF QOQONHOOLNE
	{
		get
		{
			return GDDKPIHHICF.HBFFCJHOCPE;
		}
	}

	// Token: 0x06004B17 RID: 19223 RVA: 0x00269270 File Offset: 0x00267470
	private void SaveLogin()
	{
		if (this.HNNDDLEPMHD.value)
		{
			PlayerPrefs.SetString("Username", this.QIOFBCDMLCB.BGBMIEJJQKC);
			PlayerPrefs.SetString("Password", this.LFGLJBKOFIN.BGBMIEJJQKC);
			PlayerPrefs.SetInt("remember", 1);
		}
		else
		{
			PlayerPrefs.SetInt("remember", 0);
		}
	}

	// Token: 0x06004B18 RID: 19224 RVA: 0x0001F13C File Offset: 0x0001D33C
	private void FNCQDDINCLK()
	{
		if (this.BEDINLHEHDB != null)
		{
			this.BEDINLHEHDB.transform.parent.gameObject.SetActive(false);
		}
	}

	// Token: 0x06004B19 RID: 19225 RVA: 0x002692CC File Offset: 0x002674CC
	private void OBCNMKNGFIF(string HIEFQEEDHGG, string NQFQGCGPHBE, string GQFFOBCKGKG, LPBPDPMJKNN.PJIJIFKBMBB DPQFDCNLLPC, bool FJDHJMOMGPC = false)
	{
		if (FJDHJMOMGPC)
		{
			GameObject gameObject = GameObject.Find("MSGBOX - " + HIEFQEEDHGG);
			if (gameObject != null)
			{
				UnityEngine.Object.Destroy(gameObject);
			}
		}
		LPBPDPMJKNN component = this.QDOOQHPBCLJ.BFCKNMFEBDM(this.EQLPELCDBBC).GetComponent<LPBPDPMJKNN>();
		component.BQLIIQIIMDH(null, HIEFQEEDHGG, NQFQGCGPHBE, GQFFOBCKGKG, DPQFDCNLLPC, null, -1);
		component.gameObject.name = "MSGBOX - " + HIEFQEEDHGG;
	}

	// Token: 0x06004B1A RID: 19226 RVA: 0x00269338 File Offset: 0x00267538
	public void Login()
	{
		if (!this.EFOGMBCFBGM && !this.ODOGMJJQQKE && !this.HCFPCELLGGQ)
		{
			if (this.QIOFBCDMLCB.BGBMIEJJQKC.Length < 3 || this.LFGLJBKOFIN.BGBMIEJJQKC.Length < 4)
			{
				return;
			}
			this.HCFPCELLGGQ = true;
			this.BEDINLHEHDB.PIDLOFMIEFQ = string.Empty;
			this.BEDINLHEHDB.transform.parent.gameObject.SetActive(true);
			this.LQFIDMKBJBF.SetActive(false);
			this.NCBPEGNKKCM = true;
			if (this.JOQBIMQCNDO)
			{
				base.CancelInvoke("HideResponse");
				this.BEDINLHEHDB.PIDLOFMIEFQ = "Logging in..";
				this.LQFIDMKBJBF.SetActive(true);
				this.NCBPEGNKKCM = false;
				this.CCOFBCLEMGO();
				PSXAPI.Request.Login dcgclgqcgdq = new PSXAPI.Request.Login
				{
					Name = this.QIOFBCDMLCB.BGBMIEJJQKC,
					Password = this.LFGLJBKOFIN.BGBMIEJJQKC,
					Platform = ClientPlatform.PC,
					Version = this.QLPEFCHNPQG
				};
				this.HLIOFPONLLE(dcgclgqcgdq, false);
				return;
			}
			this.EPNBECQFKEK();
		}
	}

	// Token: 0x06004B1B RID: 19227 RVA: 0x00269464 File Offset: 0x00267664
	public void JBIHPGINCDJ(PSXAPI.Response.VerifyEmail BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Result == VerifyEmailResult.Failed)
		{
			this.OBCNMKNGFIF("whiteherb", "_LayerThickness" + BJGCBDNBQCJ.Username + "Blank", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, true);
			ENEINMKKFHQ.QDGLKKGJDGI().EMQNOCQMFQF();
			this.HPPGOGQHCFG();
		}
		else if (BJGCBDNBQCJ.Result == (VerifyEmailResult)5)
		{
			this.OBCNMKNGFIF("bind", "Zen", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, false);
			ENEINMKKFHQ.LQIDEJOEHNH().KIDQJPCNBCG();
		}
		else if (BJGCBDNBQCJ.Result == VerifyEmailResult.Failed)
		{
			this.OBCNMKNGFIF("Mute", "Powers up Steel-type moves.", string.Empty, (LPBPDPMJKNN.PJIJIFKBMBB)0, true);
			ENEINMKKFHQ.GHFFHFCEENG().HQCNPOPPIQL();
		}
	}

	// Token: 0x06004B1C RID: 19228 RVA: 0x00269508 File Offset: 0x00267708
	private void JHGPOIHCHPK()
	{
		if (this.HNNDDLEPMHD.value)
		{
			PlayerPrefs.SetString("memento", this.QIOFBCDMLCB.HJMJDJKOILH());
			PlayerPrefs.SetString(": ", this.LFGLJBKOFIN.HJMJDJKOILH());
			PlayerPrefs.SetInt("psdata", 0);
		}
		else
		{
			PlayerPrefs.SetInt(" grew drowsy!\r\n", 0);
		}
	}

	// Token: 0x06004B1D RID: 19229 RVA: 0x00269564 File Offset: 0x00267764
	public void KQDBCGDBICQ(PSXAPI.Response.Login KOEEIBDFFGE)
	{
		this.LQFIDMKBJBF.SetActive(true);
		if (KOEEIBDFFGE.Result == LoginResult.Error)
		{
			KDJLKQQBGNE.LOHDQNKHLOI().CQLGHKLBHDJ();
			this.QDPQGIQQLNB();
			base.StartCoroutine(this.NFJKCEOGNKL(KOEEIBDFFGE));
		}
		else
		{
			this.BEDINLHEHDB.transform.parent.gameObject.SetActive(true);
			base.CancelInvoke("'s [ffff00]");
			if (KOEEIBDFFGE.Error == LoginError.AccountNotFound)
			{
				this.BEDINLHEHDB.PIDLOFMIEFQ = "I Hope These Don't Land On My Head";
			}
			else if (KOEEIBDFFGE.Error == LoginError.WrongPassword)
			{
				this.BEDINLHEHDB.LKPOBCBOFIC("-fieldactivate");
			}
			else if (KOEEIBDFFGE.Error == LoginError.Banned)
			{
				this.BEDINLHEHDB.LKPOBCBOFIC(".\r\n");
			}
			else if (KOEEIBDFFGE.Error == (LoginError)7)
			{
				this.BEDINLHEHDB.LKPOBCBOFIC(", input focus");
			}
			else if (KOEEIBDFFGE.Error == (LoginError)7)
			{
				if (KOEEIBDFFGE.Banned.Permanent)
				{
					this.BEDINLHEHDB.PIDLOFMIEFQ = "300";
					this.OBCNMKNGFIF(":", "dots" + KOEEIBDFFGE.Banned.Reason, string.Empty, (LPBPDPMJKNN.PJIJIFKBMBB)0, true);
				}
				else
				{
					this.BEDINLHEHDB.LKPOBCBOFIC("_Axis");
					this.OBCNMKNGFIF("ChatSettings", "Boosts the Sp. Atk stat of the Pokémon if an ally with the Plus or Minus Ability is also in battle." + KOEEIBDFFGE.Banned.Reason, string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, true);
				}
			}
			else
			{
				if (KOEEIBDFFGE.Error == (LoginError)7)
				{
					ENEINMKKFHQ.LQIDEJOEHNH().MBPHKDQMJJH = KOEEIBDFFGE.Username;
					this.BEDINLHEHDB.PIDLOFMIEFQ = "door_2";
					ENEINMKKFHQ.CLPQIKCDHPP().QPJDLDFNNPJ();
					return;
				}
				this.BEDINLHEHDB.PIDLOFMIEFQ = "CombinersAlphaScale";
			}
			base.Invoke("[-] was removed!\r\n", 1500f);
			this.DEBGPFHHPMM();
		}
	}

	// Token: 0x06004B1E RID: 19230 RVA: 0x0001F175 File Offset: 0x0001D375
	private void QOIHCIGBLEH()
	{
		if (this.CBMLQJPGPMO != null)
		{
			this.CBMLQJPGPMO.Disconnect();
		}
		this.CBMLQJPGPMO = null;
		if (this.BIECICNHDLK)
		{
			this.DGDPEFQHILI.ReleaseMutex();
		}
		this.DGDPEFQHILI.Dispose();
	}

	// Token: 0x06004B1F RID: 19231 RVA: 0x0026972C File Offset: 0x0026792C
	public void EGKCGDKFPMQ()
	{
		if (UnityEngine.Time.time > this.INKDJJOHQNQ + 1612f)
		{
			this.INKDJJOHQNQ = UnityEngine.Time.time;
			if (this.EFOGMBCFBGM && CNCJKLNHQBH.MOGQNGEPCEO() != null)
			{
				if (this.CBMLQJPGPMO.Ping >= 142)
				{
					CNCJKLNHQBH.BJLGEDCPENQ().LHFFLGHLPQO.SetActive(true);
					if (this.CBMLQJPGPMO.PingUpdateTime.TotalSeconds != 224.0)
					{
						this.CBMLQJPGPMO.PingUpdateTime = TimeSpan.FromSeconds(1938.0);
					}
				}
				else
				{
					CNCJKLNHQBH.MOGQNGEPCEO().LHFFLGHLPQO.SetActive(true);
					if (this.CBMLQJPGPMO.PingUpdateTime.TotalSeconds != 815.0)
					{
						this.CBMLQJPGPMO.PingUpdateTime = TimeSpan.FromSeconds(1511.0);
					}
				}
			}
		}
		if (UnityEngine.Time.time > this.IMQNHDIEFMM + this.COFDEBBQNKF && this.JIKKBCNDLOC.Count > 0)
		{
			this.PDKBHHPOQPJ();
		}
	}

	// Token: 0x06004B20 RID: 19232 RVA: 0x00269840 File Offset: 0x00267A40
	private void QDPQGIQQLNB()
	{
		if (this.HNNDDLEPMHD.value)
		{
			PlayerPrefs.SetString("Vertical", this.QIOFBCDMLCB.BGBMIEJJQKC);
			PlayerPrefs.SetString("DirX", this.LFGLJBKOFIN.BGBMIEJJQKC);
			PlayerPrefs.SetInt("_History2LumaTex", 0);
		}
		else
		{
			PlayerPrefs.SetInt("~", 1);
		}
	}

	// Token: 0x06004B21 RID: 19233 RVA: 0x0026989C File Offset: 0x00267A9C
	public void NJNCGMFPHFI()
	{
		this.NKIJOONCCDQ = new Queue<IProto>();
		this.JIKKBCNDLOC = new List<PSXAPI.Request.Move>();
		if (this.CBMLQJPGPMO != null)
		{
			this.CBMLQJPGPMO.Disconnect();
			this.CBMLQJPGPMO.Dispose();
			this.CBMLQJPGPMO = null;
		}
		if (this.EFOGMBCFBGM)
		{
			this.EFOGMBCFBGM = false;
			SceneManager.LoadScene("Login");
		}
		this.NCBPEGNKKCM = false;
		this.HCFPCELLGGQ = false;
		this.ODOGMJJQQKE = false;
		this.JOQBIMQCNDO = false;
	}

	// Token: 0x06004B22 RID: 19234 RVA: 0x0001F175 File Offset: 0x0001D375
	private void DBIOPBOKDBP()
	{
		if (this.CBMLQJPGPMO != null)
		{
			this.CBMLQJPGPMO.Disconnect();
		}
		this.CBMLQJPGPMO = null;
		if (this.BIECICNHDLK)
		{
			this.DGDPEFQHILI.ReleaseMutex();
		}
		this.DGDPEFQHILI.Dispose();
	}

	// Token: 0x06004B23 RID: 19235 RVA: 0x0026991C File Offset: 0x00267B1C
	private IEnumerator NFJKCEOGNKL(PSXAPI.Response.Login KOEEIBDFFGE)
	{
		yield return null;
		return 1;
		SceneManager.LoadScene("Game", LoadSceneMode.Single);
		yield return 0;
		return 1;
		this.PJLQKEJMDPG(KOEEIBDFFGE.Username);
		CNCJKLNHQBH.QOQONHOOLNE.HHBIOMNQDJG(KOEEIBDFFGE);
		yield break;
	}

	// Token: 0x06004B24 RID: 19236 RVA: 0x0026991C File Offset: 0x00267B1C
	private IEnumerator QJFPQJGCCDK(PSXAPI.Response.Login KOEEIBDFFGE)
	{
		yield return null;
		return 1;
		SceneManager.LoadScene("Game", LoadSceneMode.Single);
		yield return 0;
		return 1;
		this.PJLQKEJMDPG(KOEEIBDFFGE.Username);
		CNCJKLNHQBH.QOQONHOOLNE.HHBIOMNQDJG(KOEEIBDFFGE);
		yield break;
	}

	// Token: 0x06004B25 RID: 19237 RVA: 0x00269940 File Offset: 0x00267B40
	private void JJFGLHQQLOF()
	{
		if (this.HNNDDLEPMHD.value)
		{
			PlayerPrefs.SetString("FOG_AREA_BOX", this.QIOFBCDMLCB.HJMJDJKOILH());
			PlayerPrefs.SetString("-1", this.LFGLJBKOFIN.BGBMIEJJQKC);
			PlayerPrefs.SetInt("Congratulations ", 1);
		}
		else
		{
			PlayerPrefs.SetInt("Light Metal", 1);
		}
	}

	// Token: 0x06004B26 RID: 19238 RVA: 0x0001F1B6 File Offset: 0x0001D3B6
	public void FGMIKQLOEEQ()
	{
		this.JIKKBCNDLOC.Clear();
		this.IMQNHDIEFMM = UnityEngine.Time.time;
	}

	// Token: 0x06004B27 RID: 19239 RVA: 0x0026999C File Offset: 0x00267B9C
	private void Start()
	{
		if (GameObject.Find("TCPManager"))
		{
			UnityEngine.Object.Destroy(GameObject.Find("TCPManager"));
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		base.gameObject.name = "TCPManager";
		KGQECFKLKOP.GKHNLKOPGGD();
		this.QQEBEJLJDFH = base.GetComponent<NNKKGGNIKKN>();
		if (PlayerPrefs.GetInt("remember") == 1)
		{
			this.HNNDDLEPMHD.value = true;
			this.QIOFBCDMLCB.BGBMIEJJQKC = PlayerPrefs.GetString("Username", string.Empty);
			this.LFGLJBKOFIN.BGBMIEJJQKC = PlayerPrefs.GetString("Password", string.Empty);
		}
		else
		{
			this.HNNDDLEPMHD.value = false;
		}
		this.CCOFBCLEMGO();
	}

	// Token: 0x06004B28 RID: 19240 RVA: 0x00269A58 File Offset: 0x00267C58
	public void HPPGOGQHCFG()
	{
		this.NKIJOONCCDQ = new Queue<IProto>();
		this.JIKKBCNDLOC = new List<PSXAPI.Request.Move>();
		if (this.CBMLQJPGPMO != null)
		{
			this.CBMLQJPGPMO.Disconnect();
			this.CBMLQJPGPMO.Dispose();
			this.CBMLQJPGPMO = null;
		}
		if (this.EFOGMBCFBGM)
		{
			this.EFOGMBCFBGM = false;
			SceneManager.LoadScene("Script:");
		}
		this.NCBPEGNKKCM = false;
		this.HCFPCELLGGQ = true;
		this.ODOGMJJQQKE = false;
		this.JOQBIMQCNDO = true;
	}

	// Token: 0x06004B29 RID: 19241 RVA: 0x00269AD8 File Offset: 0x00267CD8
	public void HLIOFPONLLE(IProto DCGCLGQCGDQ, bool OIMBKLCGOIG = false)
	{
		if (GDDKPIHHICF.HBFFCJHOCPE != null)
		{
			if (!OIMBKLCGOIG && DCGCLGQCGDQ is PSXAPI.Request.Move)
			{
				if (this.JIKKBCNDLOC.Count > 0 && this.JIKKBCNDLOC[this.JIKKBCNDLOC.Count - 1].Map != ((PSXAPI.Request.Move)DCGCLGQCGDQ).Map)
				{
					this.PDKBHHPOQPJ();
				}
				if (this.JIKKBCNDLOC.Count == 0)
				{
					this.IMQNHDIEFMM = UnityEngine.Time.time;
				}
				if (UnityEngine.Time.time < this.IMQNHDIEFMM + this.COFDEBBQNKF)
				{
					this.JIKKBCNDLOC.Add((PSXAPI.Request.Move)DCGCLGQCGDQ);
					if (QOHCEBMQKMB.QOQONHOOLNE.EKEKMCMJEOC())
					{
						this.PDKBHHPOQPJ();
					}
					return;
				}
				this.PDKBHHPOQPJ();
			}
			if (this.OGIIKDBIMIK)
			{
				this.NKIJOONCCDQ.Enqueue(DCGCLGQCGDQ);
				base.StartCoroutine(this.OFDFIPBCNKF());
			}
			else
			{
				GDDKPIHHICF.HBFFCJHOCPE.CBMLQJPGPMO.Send(DCGCLGQCGDQ);
			}
		}
	}

	// Token: 0x06004B2A RID: 19242 RVA: 0x00269BD4 File Offset: 0x00267DD4
	private void FOLBFDNJLII()
	{
		GDDKPIHHICF.HBFFCJHOCPE = this;
		string name = ")";
		MutexAccessRule rule = new MutexAccessRule(new SecurityIdentifier(WellKnownSidType.NullSid, null), (MutexRights)(-33), AccessControlType.Deny);
		MutexSecurity mutexSecurity = new MutexSecurity();
		mutexSecurity.AddAccessRule(rule);
		bool flag;
		this.DGDPEFQHILI = new Mutex(true, name, ref flag, mutexSecurity);
		this.BIECICNHDLK = false;
		try
		{
			this.BIECICNHDLK = this.DGDPEFQHILI.WaitOne(50, false);
			if (!this.BIECICNHDLK)
			{
				Application.Quit();
			}
		}
		catch (AbandonedMutexException)
		{
			this.BIECICNHDLK = true;
		}
		finally
		{
		}
	}

	// Token: 0x06004B2C RID: 19244 RVA: 0x00269CE0 File Offset: 0x00267EE0
	public void JOBPMCHGFQK(PSXAPI.Response.VerifyEmail BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Result == VerifyEmailResult.Verified)
		{
			this.OBCNMKNGFIF("[/O]", "_WaveOffset" + BJGCBDNBQCJ.Username + " Pokédollars.", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, false);
			ENEINMKKFHQ.QDGLKKGJDGI().PBPCFIJBJDB();
			this.DEBGPFHHPMM();
		}
		else if (BJGCBDNBQCJ.Result == VerifyEmailResult.Failed)
		{
			this.OBCNMKNGFIF("???", "[-]", string.Empty, (LPBPDPMJKNN.PJIJIFKBMBB)0, false);
			ENEINMKKFHQ.GHFFHFCEENG().CGBGQBFBLIJ();
		}
		else if (BJGCBDNBQCJ.Result == VerifyEmailResult.Failed)
		{
			this.OBCNMKNGFIF("Music", " Obtained", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, true);
			ENEINMKKFHQ.HGEKKNEPOHK().NHFQKBOMHGE();
		}
	}

	// Token: 0x06004B2D RID: 19245 RVA: 0x00269D84 File Offset: 0x00267F84
	private void Update()
	{
		if (this.CBMLQJPGPMO != null)
		{
			if (this.ODOGMJJQQKE)
			{
				try
				{
					if (this.CBMLQJPGPMO.Status == ConnectionStatus.Connecting)
					{
						this.JOQBIMQCNDO = false;
					}
					else
					{
						this.JOQBIMQCNDO = this.CBMLQJPGPMO.IsConnected;
						if (!this.JOQBIMQCNDO)
						{
							this.CBMLQJPGPMO.Dispose();
							this.CBMLQJPGPMO = null;
						}
						this.ODOGMJJQQKE = false;
						if (this.JOQBIMQCNDO)
						{
							base.CancelInvoke("HideResponse");
							this.BEDINLHEHDB.PIDLOFMIEFQ = "Connection Established..";
							this.LQFIDMKBJBF.SetActive(false);
							if (this.NCBPEGNKKCM)
							{
								this.NCBPEGNKKCM = false;
								this.CCOFBCLEMGO();
								PSXAPI.Request.Login dcgclgqcgdq = new PSXAPI.Request.Login
								{
									Name = this.QIOFBCDMLCB.BGBMIEJJQKC,
									Password = this.LFGLJBKOFIN.BGBMIEJJQKC,
									Platform = ClientPlatform.PC,
									Version = this.QLPEFCHNPQG
								};
								this.HLIOFPONLLE(dcgclgqcgdq, false);
								this.BEDINLHEHDB.PIDLOFMIEFQ = "Logging in..";
								this.LQFIDMKBJBF.SetActive(true);
							}
						}
						else
						{
							this.NCBPEGNKKCM = false;
							base.CancelInvoke("HideResponse");
							this.BEDINLHEHDB.PIDLOFMIEFQ = "Could not connect to Server..";
							this.LQFIDMKBJBF.SetActive(false);
							this.HCFPCELLGGQ = false;
						}
						base.Invoke("HideResponse", 3f);
						this.SaveLogin();
					}
				}
				catch (Exception)
				{
					base.CancelInvoke("HideResponse");
					this.NCBPEGNKKCM = false;
					this.LQFIDMKBJBF.SetActive(false);
					this.BEDINLHEHDB.PIDLOFMIEFQ = "Could not connect to Server..";
					this.HCFPCELLGGQ = false;
					base.Invoke("HideResponse", 3f);
					this.SaveLogin();
					this.JOQBIMQCNDO = false;
					this.ODOGMJJQQKE = false;
				}
				return;
			}
			if (!this.CBMLQJPGPMO.IsConnected && this.CBMLQJPGPMO.Status != ConnectionStatus.Connecting)
			{
				this.NJNCGMFPHFI();
				return;
			}
			this.MOIKNOKFIQF();
			foreach (IProto proto in this.CBMLQJPGPMO.GetResponses())
			{
				if (!(proto is Greeting))
				{
					if (proto is DebugMessage)
					{
						DebugMessage debugMessage = (DebugMessage)proto;
						if (debugMessage.Message != null && (debugMessage.Message.Contains("Orleans.Runtime.GatewayTooBusyException") || debugMessage.Message.Contains("Command Exception [Login]: System.TimeoutException")) && this.HCFPCELLGGQ && !this.EFOGMBCFBGM)
						{
							this.NJNCGMFPHFI();
							base.CancelInvoke("HideResponse");
							this.BEDINLHEHDB.PIDLOFMIEFQ = "Could not login at this time..";
							base.Invoke("HideResponse", 3f);
						}
					}
					else if (proto is Discovered)
					{
						JPPCMGBCNNJ.QOQONHOOLNE.NLPCILIPELK("Discovered Area", ((Discovered)proto).Area, 30);
						CNCJKLNHQBH.QOQONHOOLNE.HDGHKDEPNBP = CNCJKLNHQBH.QOQONHOOLNE.HDGHKDEPNBP.Concat(new string[]
						{
							((Discovered)proto).Area
						}).ToArray<string>();
					}
					else if (proto is PSXAPI.Response.Login)
					{
						this.HHBIOMNQDJG((PSXAPI.Response.Login)proto);
					}
					else if (proto is PSXAPI.Response.Logout)
					{
						CNCJKLNHQBH.QOQONHOOLNE.Logout(string.Empty);
					}
					else if (proto is DailyLootbox)
					{
						KOJBBGEINPH.QOQONHOOLNE.FJEILLHKEPE((DailyLootbox)proto, new TimeSpan(0L));
					}
					else if (proto is PSXAPI.Response.Time)
					{
						CNCJKLNHQBH.QOQONHOOLNE.INFJBBNFJMO((PSXAPI.Response.Time)proto);
					}
					else if (proto is PSXAPI.Response.Skins)
					{
						DNFENPQLICQ.QOQONHOOLNE.HNIQIFCKMNC((PSXAPI.Response.Skins)proto);
					}
					else if (proto is PSXAPI.Response.VerifyEmail)
					{
						this.KIDKGONQBQD((PSXAPI.Response.VerifyEmail)proto);
					}
					else if (proto is PSXAPI.Response.Password)
					{
						if (CNCJKLNHQBH.QOQONHOOLNE != null)
						{
							NPOFODNPJIL.QOQONHOOLNE.KOIQEELOBJL((PSXAPI.Response.Password)proto);
						}
						else if (GHBIMQCKMEJ.QOQONHOOLNE != null)
						{
							GHBIMQCKMEJ.QOQONHOOLNE.PHEPIPPFNGD((PSXAPI.Response.Password)proto);
						}
					}
					else if (proto is PSXAPI.Response.Skin)
					{
						DNFENPQLICQ.QOQONHOOLNE.EMQECLQMBEC((PSXAPI.Response.Skin)proto);
					}
					else if (proto is PSXAPI.Response.Spin)
					{
						CNCJKLNHQBH.QOQONHOOLNE.LHNQPPEQIOE.GetComponent<GQFGBNEHHPC>().OILGJPIELNN((PSXAPI.Response.Spin)proto);
					}
					else if (proto is Broadcast)
					{
						Broadcast broadcast = (Broadcast)proto;
						if (broadcast.Type == BroadcastMessageType.System)
						{
							MBGHQMKEFKO.QOQONHOOLNE.IGFCQCCEMFF(new PSXAPI.Response.ChatMessage
							{
								Channel = "System",
								Messages = new PSXAPI.Response.Payload.ChatMessage[]
								{
									new PSXAPI.Response.Payload.ChatMessage
									{
										Message = broadcast.Message,
										Timestamp = DateTime.Now,
										Username = string.Empty,
										Pokemon = null
									}
								}
							});
						}
						else if (broadcast.Type == BroadcastMessageType.Message)
						{
							CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("System Message", broadcast.Message, string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, false, null, -1, false);
						}
						else if (broadcast.Type == BroadcastMessageType.Notification)
						{
							if (CKMLKNPNPQO.QOQONHOOLNE != null)
							{
								CKMLKNPNPQO.QOQONHOOLNE.OKKHCPOJJNQ(broadcast.Message);
							}
						}
						else
						{
							CNCJKLNHQBH.QOQONHOOLNE.CMJIKPGFCLI(broadcast.Message);
						}
					}
					else if (proto is RegionUpdate)
					{
						INFJMNPKNQF.QOQONHOOLNE.ENNNINOENPO((RegionUpdate)proto);
					}
					else if (proto is Thunder)
					{
						MCNLIHMMLCF.QOQONHOOLNE.DDCIBJFCFDK = true;
					}
					else if (proto is PSXAPI.Response.Guild)
					{
						NOHEMGHONKK.QOQONHOOLNE.MKELCDNMCFN((PSXAPI.Response.Guild)proto);
					}
					else if (proto is PSXAPI.Response.GuildEmblem)
					{
						NOHEMGHONKK.QOQONHOOLNE.MECJMBNDFFD((PSXAPI.Response.GuildEmblem)proto);
						NOHEMGHONKK.QOQONHOOLNE.QNPFCMNEOEB((PSXAPI.Response.GuildEmblem)proto);
					}
					else if (proto is GuildMember)
					{
						NOHEMGHONKK.QOQONHOOLNE.EQNKDHNGLNI((GuildMember)proto);
					}
					else if (proto is GuildResult)
					{
						NOHEMGHONKK.QOQONHOOLNE.FKOMEGBDBQG((GuildResult)proto);
					}
					else if (proto is PSXAPI.Response.ChatJoin)
					{
						MBGHQMKEFKO.QOQONHOOLNE.IGFCQCCEMFF((PSXAPI.Response.ChatJoin)proto);
					}
					else if (proto is PSXAPI.Response.Stats)
					{
						HDQHPMCPDNJ.QOQONHOOLNE.ILPEJPEFIHI((PSXAPI.Response.Stats)proto);
					}
					else if (proto is PSXAPI.Response.Achievement)
					{
						JPPCMGBCNNJ.QOQONHOOLNE.ONDLGFGCNDP((PSXAPI.Response.Achievement)proto);
					}
					else if (proto is PSXAPI.Response.Achievements)
					{
						JPPCMGBCNNJ.QOQONHOOLNE.MCPHPECGQNI((PSXAPI.Response.Achievements)proto);
					}
					else if (proto is PSXAPI.Response.ChatMessage)
					{
						MBGHQMKEFKO.QOQONHOOLNE.IGFCQCCEMFF((PSXAPI.Response.ChatMessage)proto);
					}
					else if (proto is PSXAPI.Response.Move)
					{
						if (this.EFOGMBCFBGM)
						{
							if (this.EGDKLIHHJEG.Count > 0)
							{
								this.EGDKLIHHJEG.Add(proto);
							}
							else
							{
								this.FGMIKQLOEEQ();
								CNCJKLNHQBH.QOQONHOOLNE.CEDNIOKLNNP((PSXAPI.Response.Move)proto);
							}
						}
						else
						{
							this.EGDKLIHHJEG.Add(proto);
						}
					}
					else if (proto is EncounterReset)
					{
						CNCJKLNHQBH.QOQONHOOLNE.QELEIBIKPOF = -1;
						CNCJKLNHQBH.QOQONHOOLNE.KCMIHQPIQKI.SetActive(false);
					}
					else if (proto is PSXAPI.Response.Area)
					{
						GBQODOBKJBG.QOQONHOOLNE.QBPDHIJCHHN((PSXAPI.Response.Area)proto);
					}
					else if (proto is PSXAPI.Response.Search)
					{
						JJGLMJNELOK.QOQONHOOLNE.JPOHCQNNNIL((PSXAPI.Response.Search)proto);
					}
					else if (proto is PSXAPI.Response.Message)
					{
						if (LQCPKKCJPPB.QOQONHOOLNE != null && CKMLKNPNPQO.QOQONHOOLNE != null)
						{
							LQCPKKCJPPB.QOQONHOOLNE.NHENHBGIFIG((PSXAPI.Response.Message)proto);
						}
					}
					else if (proto is MapUsers)
					{
						if (CGOIPHKQMPD.QOQONHOOLNE != null)
						{
							CGOIPHKQMPD.QOQONHOOLNE.CCFFGFLPBOQ((MapUsers)proto);
						}
						else
						{
							this.FPQLHPFDFGI.Add(proto);
						}
					}
					else if (proto is PSXAPI.Response.Badges)
					{
						INFJMNPKNQF.QOQONHOOLNE.DFMLMCDHNCM = ((PSXAPI.Response.Badges)proto).All;
						NBQDPNGNNML.QOQONHOOLNE.PDDJMNOOPJD();
					}
					else if (proto is Level)
					{
						CNCJKLNHQBH.QOQONHOOLNE.KIJCPNIJKFI((Level)proto);
					}
					else if (proto is PSXAPI.Response.Path)
					{
						CNCJKLNHQBH.QOQONHOOLNE.PECGJDEFFFI((PSXAPI.Response.Path)proto);
					}
					else if (proto is PSXAPI.Response.Quest)
					{
						if (NBQDPNGNNML.QOQONHOOLNE != null)
						{
							NBQDPNGNNML.QOQONHOOLNE.GLEFJQQKILF((PSXAPI.Response.Quest)proto, false);
						}
					}
					else if (proto is Battle)
					{
						if (DBQLOHBBJMG.QOQONHOOLNE != null)
						{
							DBQLOHBBJMG.QOQONHOOLNE.EDNKECNMIBK = false;
							base.StartCoroutine(DBQLOHBBJMG.QOQONHOOLNE.GLJOODPHBCN((Battle)proto));
						}
					}
					else if (proto is PSXAPI.Response.BattleItem)
					{
						if (DBQLOHBBJMG.QOQONHOOLNE != null)
						{
							DBQLOHBBJMG.QOQONHOOLNE.JNNOLQJBNJC((PSXAPI.Response.BattleItem)proto);
						}
					}
					else if (proto is PSXAPI.Response.BattleSide)
					{
						if (DBQLOHBBJMG.QOQONHOOLNE != null)
						{
							DBQLOHBBJMG.QOQONHOOLNE.FMDBQPPQKBO((PSXAPI.Response.BattleSide)proto);
						}
					}
					else if (proto is PSXAPI.Response.BattleBroadcast)
					{
						if (DBQLOHBBJMG.QOQONHOOLNE != null)
						{
							DBQLOHBBJMG.QOQONHOOLNE.EPQJQILCNOE((PSXAPI.Response.BattleBroadcast)proto);
						}
					}
					else if (proto is PSXAPI.Response.Inventory)
					{
						INFJMNPKNQF.QOQONHOOLNE.QNQDBIGNGML((PSXAPI.Response.Inventory)proto);
					}
					else if (proto is InventoryPokemon)
					{
						HFCMDEQKCKH.QOQONHOOLNE.MNICELEPBHO((InventoryPokemon)proto, true);
					}
					else if (proto is PSXAPI.Response.Lootbox)
					{
						KOJBBGEINPH.QOQONHOOLNE.QLKEMCGJIDC((PSXAPI.Response.Lootbox)proto);
					}
					else if (proto is PSXAPI.Response.Evs)
					{
						HFCMDEQKCKH.QOQONHOOLNE.EDQIHJMOIID((PSXAPI.Response.Evs)proto);
					}
					else if (proto is PSXAPI.Response.Ivs)
					{
						HFCMDEQKCKH.QOQONHOOLNE.FHNJGBQIDFC((PSXAPI.Response.Ivs)proto);
					}
					else if (proto is PSXAPI.Response.Release)
					{
						HFCMDEQKCKH.QOQONHOOLNE.JDBLBHFELNQ((PSXAPI.Response.Release)proto);
					}
					else if (proto is InventoryItem)
					{
						INFJMNPKNQF.QOQONHOOLNE.IGIKNHQQQJB((InventoryItem)proto);
						if (JICJEENBPEO.QOQONHOOLNE.QPPGQJFBPMH.gameObject.activeSelf)
						{
							JICJEENBPEO.QOQONHOOLNE.ResetAmount();
						}
					}
					else if (proto is PSXAPI.Response.CheckUser)
					{
						if (OGIHGEJKOGL.QOQONHOOLNE != null)
						{
							OGIHGEJKOGL.QOQONHOOLNE.CCGFFHJPNKB((PSXAPI.Response.CheckUser)proto);
						}
					}
					else if (proto is PSXAPI.Response.CreateUser)
					{
						if (OGIHGEJKOGL.QOQONHOOLNE != null)
						{
							OGIHGEJKOGL.QOQONHOOLNE.QMMDGPGDFOG((PSXAPI.Response.CreateUser)proto);
						}
					}
					else if (proto is PSXAPI.Response.CheckEmail)
					{
						if (OGIHGEJKOGL.QOQONHOOLNE != null)
						{
							OGIHGEJKOGL.QOQONHOOLNE.EPQJDPBNHEL((PSXAPI.Response.CheckEmail)proto);
						}
					}
					else if (proto is PSXAPI.Response.HoldItem)
					{
						INFJMNPKNQF.QOQONHOOLNE.JNKOHNKQNQH((PSXAPI.Response.HoldItem)proto);
					}
					else if (proto is Money)
					{
						INFJMNPKNQF.QOQONHOOLNE.PEHLHEBCKMB((Money)proto);
					}
					else if (proto is PSXAPI.Response.Learn)
					{
						HFCMDEQKCKH.QOQONHOOLNE.EGNCKJPNONP((PSXAPI.Response.Learn)proto);
					}
					else if (proto is PSXAPI.Response.Evolve)
					{
						HFCMDEQKCKH.QOQONHOOLNE.FCOQCHGIIGN((PSXAPI.Response.Evolve)proto);
					}
					else if (proto is PSXAPI.Response.Reorder)
					{
						HFCMDEQKCKH.QOQONHOOLNE.JLHPNIEEGJD((PSXAPI.Response.Reorder)proto);
					}
					else if (proto is PSXAPI.Response.UseItem)
					{
						INFJMNPKNQF.QOQONHOOLNE.GPBLEHILJOQ((PSXAPI.Response.UseItem)proto);
					}
					else if (proto is PSXAPI.Response.Pokemon)
					{
						JJGLMJNELOK.QOQONHOOLNE.KDQLQNFEQII((PSXAPI.Response.Pokemon)proto);
					}
					else if (proto is PSXAPI.Response.Transfer)
					{
						JJGLMJNELOK.QOQONHOOLNE.MIBEJDFGPFC((PSXAPI.Response.Transfer)proto);
					}
					else if (proto is PokedexUpdate)
					{
						EIDBQCPLPIL.QOQONHOOLNE.HLEHBGMIHHB((PokedexUpdate)proto);
					}
					else if (proto is Style)
					{
						CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.GPFOFHLIDMH((Style)proto, null, null);
					}
					else if (proto is PSXAPI.Response.Effect)
					{
						if (this.EFOGMBCFBGM)
						{
							if (this.EGDKLIHHJEG.Count > 0)
							{
								this.EGDKLIHHJEG.Add(proto);
							}
							else
							{
								GNDQBCBDHKD.QOQONHOOLNE.KDCPLJDQDLG((PSXAPI.Response.Effect)proto);
							}
						}
						else
						{
							this.EGDKLIHHJEG.Add(proto);
						}
					}
					else if (proto is PSXAPI.Response.Upgrade)
					{
						PSXAPI.Response.Upgrade upgrade = (PSXAPI.Response.Upgrade)proto;
						if (upgrade.Type == UpgradeType.Pokebox)
						{
							if (JJGLMJNELOK.QOQONHOOLNE != null)
							{
								JJGLMJNELOK.QOQONHOOLNE.OICDQNHQFDB(upgrade);
							}
						}
						else if (upgrade.Type == UpgradeType.Guild && NOHEMGHONKK.QOQONHOOLNE != null)
						{
							NOHEMGHONKK.QOQONHOOLNE.OICDQNHQFDB(upgrade);
						}
					}
					else if (proto is Equip)
					{
						CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.LNMPOMFDEGC((Equip)proto);
						CNCJKLNHQBH.QOQONHOOLNE.GIHGBGQJEJJ((Equip)proto);
						DNFENPQLICQ.QOQONHOOLNE.UpdateGUI();
					}
					else
					{
						if (proto is PSXAPI.Response.Mount)
						{
							CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.HQNCQOFKPHN((PSXAPI.Response.Mount)proto);
							HFCMDEQKCKH.QOQONHOOLNE.BJFKOHCDFKN();
							if (((PSXAPI.Response.Mount)proto).MountType == MountType.Bike)
							{
								goto IL_D19;
							}
							if (((PSXAPI.Response.Mount)proto).MountType == MountType.Pokemon)
							{
								goto IL_D19;
							}
							if (((PSXAPI.Response.Mount)proto).MountType == MountType.Surfing)
							{
								DNFENPQLICQ.QOQONHOOLNE.FGMFPEOQBNO = ((PSXAPI.Response.Mount)proto).MountID;
							}
							IL_D2E:
							DNFENPQLICQ.QOQONHOOLNE.UpdateGUI();
							goto IL_1459;
							IL_D19:
							DNFENPQLICQ.QOQONHOOLNE.HHNPLECEPEI = ((PSXAPI.Response.Mount)proto).MountID;
							goto IL_D2E;
						}
						if (proto is EquipFly)
						{
							DNFENPQLICQ.QOQONHOOLNE.MCPQEOLLKNH = ((EquipFly)proto).Skin;
							DNFENPQLICQ.QOQONHOOLNE.UpdateGUI();
							GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.MCHMMNBMHHC();
						}
						else if (proto is PSXAPI.Response.Trade)
						{
							PJCCMHCDFJQ.QOQONHOOLNE.PGIQGOFDIDJ((PSXAPI.Response.Trade)proto);
						}
						else if (proto is FlyStart)
						{
							GGQKBGDGNJN.QOQONHOOLNE.QMFDMMQKLNB((FlyStart)proto);
						}
						else if (proto is FlyUsers)
						{
							EMLOFJDOMKH.QOQONHOOLNE.GOFKQQJLBLK((FlyUsers)proto);
						}
						else if (proto is Party)
						{
							if (this.EFOGMBCFBGM)
							{
								if (this.EGDKLIHHJEG.Count > 0)
								{
									this.EGDKLIHHJEG.Add(proto);
								}
								else
								{
									DCJIBBJQGJP.QOQONHOOLNE.QQLIFFOPNGC((Party)proto);
								}
							}
							else
							{
								this.EGDKLIHHJEG.Add(proto);
							}
						}
						else if (proto is PartyPokemon)
						{
							if (this.EFOGMBCFBGM)
							{
								if (this.EGDKLIHHJEG.Count > 0)
								{
									this.EGDKLIHHJEG.Add(proto);
								}
								else
								{
									DCJIBBJQGJP.QOQONHOOLNE.HKDDHICDELN((PartyPokemon)proto);
								}
							}
							else
							{
								this.EGDKLIHHJEG.Add(proto);
							}
						}
						else if (proto is PartyRemove)
						{
							if (this.EFOGMBCFBGM)
							{
								if (this.EGDKLIHHJEG.Count > 0)
								{
									this.EGDKLIHHJEG.Add(proto);
								}
								else
								{
									DCJIBBJQGJP.QOQONHOOLNE.FCMDDBMHCQP((PartyRemove)proto);
								}
							}
							else
							{
								this.EGDKLIHHJEG.Add(proto);
							}
						}
						else if (proto is PSXAPI.Response.Friends)
						{
							if (CKMLKNPNPQO.QOQONHOOLNE != null)
							{
								CKMLKNPNPQO.QOQONHOOLNE.GJONDIEGIQQ((PSXAPI.Response.Friends)proto);
							}
						}
						else if (proto is PSXAPI.Response.Ignore)
						{
							CKMLKNPNPQO.QOQONHOOLNE.OIIFJCHMODN((PSXAPI.Response.Ignore)proto);
						}
						else if (proto is Lobby)
						{
							if (BDLNNJFQOQH.QOQONHOOLNE != null)
							{
								BDLNNJFQOQH.QOQONHOOLNE.GOBLEQIFKMI((Lobby)proto);
							}
						}
						else if (proto is LobbyRemove)
						{
							if (BDLNNJFQOQH.QOQONHOOLNE != null)
							{
								BDLNNJFQOQH.QOQONHOOLNE.LBJGBQIJOPD((LobbyRemove)proto);
							}
						}
						else if (proto is PSXAPI.Response.LobbyMessage)
						{
							if (BDLNNJFQOQH.QOQONHOOLNE != null)
							{
								BDLNNJFQOQH.QOQONHOOLNE.EQNDFEFKQBL((PSXAPI.Response.LobbyMessage)proto);
							}
						}
						else if (proto is PSXAPI.Response.LootVote)
						{
							IBJOGQJFQEP.QOQONHOOLNE.KCPCKMEMFDB((PSXAPI.Response.LootVote)proto);
						}
						else if (proto is PSXAPI.Response.Loot)
						{
							IBJOGQJFQEP.QOQONHOOLNE.KOPGFIIJDHI((PSXAPI.Response.Loot)proto);
						}
						else if (proto is PSXAPI.Response.Areas)
						{
							EIDBQCPLPIL.QOQONHOOLNE.LELFDOQONPD = false;
							GGQKBGDGNJN.QOQONHOOLNE.DEKPOPOLJOM((PSXAPI.Response.Areas)proto);
						}
						else if (proto is PSXAPI.Response.Sync)
						{
							CNCJKLNHQBH.QOQONHOOLNE.NIODFIFQBFE((PSXAPI.Response.Sync)proto);
						}
						else if (proto is PSXAPI.Response.Script)
						{
							if (QOHCEBMQKMB.QOQONHOOLNE == null)
							{
								this.EGDKLIHHJEG.Add(proto);
							}
							else if (this.EGDKLIHHJEG.Count > 0)
							{
								this.EGDKLIHHJEG.Add(proto);
							}
							else
							{
								QOHCEBMQKMB.QOQONHOOLNE.LFPNDNQGFQK((PSXAPI.Response.Script)proto);
							}
						}
						else if (proto is PSXAPI.Response.Request)
						{
							PSXAPI.Response.Request request = (PSXAPI.Response.Request)proto;
							if (request.Type == PSXAPI.Response.RequestType.Trade)
							{
								if ((OGJJKKQPNMK.QOQONHOOLNE != null && CKMLKNPNPQO.QOQONHOOLNE.OFKHICHJCIP(request.Sender)) || (CNCJKLNHQBH.QOQONHOOLNE != null && CNCJKLNHQBH.QOQONHOOLNE.KOCBHNQNOJO != null && CNCJKLNHQBH.QOQONHOOLNE.KOCBHNQNOJO.MJGMICNJJBE))
								{
									this.HLIOFPONLLE(new PSXAPI.Request.Request
									{
										Accepted = false,
										Sender = request.Sender,
										Type = PSXAPI.Request.RequestType.Trade
									}, false);
								}
								else
								{
									CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Trade Request", request.Sender + " would like to trade with you. Do you wish to trade?", request.Sender, LPBPDPMJKNN.PJIJIFKBMBB.YesNo, true, null, 59, true);
								}
							}
							else if (request.Type == PSXAPI.Response.RequestType.Friend)
							{
								if (!CKMLKNPNPQO.QOQONHOOLNE.OFKHICHJCIP(request.Sender) && (!(CNCJKLNHQBH.QOQONHOOLNE != null) || !(CNCJKLNHQBH.QOQONHOOLNE.KOCBHNQNOJO != null) || !CNCJKLNHQBH.QOQONHOOLNE.KOCBHNQNOJO.MLQKMBCHFLL))
								{
									CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Friend Request", request.Sender + " would like to be friends. Do you wish to accept?", request.Sender, LPBPDPMJKNN.PJIJIFKBMBB.YesNo, true, null, 59, true);
								}
								else
								{
									this.HLIOFPONLLE(new PSXAPI.Request.Request
									{
										Accepted = false,
										Sender = request.Sender,
										Type = PSXAPI.Request.RequestType.Friend
									}, false);
								}
							}
							else if (request.Type == PSXAPI.Response.RequestType.Party)
							{
								if (CKMLKNPNPQO.QOQONHOOLNE.OFKHICHJCIP(request.Sender))
								{
									this.HLIOFPONLLE(new PSXAPI.Request.Request
									{
										Accepted = false,
										Sender = request.Sender,
										Type = PSXAPI.Request.RequestType.Party
									}, false);
								}
								else
								{
									CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Party Request", request.Sender + " would like you to join their Party. Do you wish to join?", request.Sender, LPBPDPMJKNN.PJIJIFKBMBB.YesNo, true, null, 59, true);
								}
							}
							else if (request.Type == PSXAPI.Response.RequestType.Battle)
							{
								if (!CKMLKNPNPQO.QOQONHOOLNE.OFKHICHJCIP(request.Sender) && (!(CNCJKLNHQBH.QOQONHOOLNE != null) || !(CNCJKLNHQBH.QOQONHOOLNE.KOCBHNQNOJO != null) || !CNCJKLNHQBH.QOQONHOOLNE.KOCBHNQNOJO.PFODCGLOHFD))
								{
									CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Battle Request", request.Sender + " would like to Battle with you. Do you wish to Battle?", request.Sender, LPBPDPMJKNN.PJIJIFKBMBB.YesNo, true, null, 59, true);
								}
								else
								{
									this.HLIOFPONLLE(new PSXAPI.Request.Request
									{
										Accepted = false,
										Sender = request.Sender,
										Type = PSXAPI.Request.RequestType.Battle
									}, false);
								}
							}
							else if (request.Type == PSXAPI.Response.RequestType.Guild)
							{
								if (CKMLKNPNPQO.QOQONHOOLNE.OFKHICHJCIP(request.Sender))
								{
									this.HLIOFPONLLE(new PSXAPI.Request.Request
									{
										Accepted = false,
										Sender = request.Sender,
										Type = PSXAPI.Request.RequestType.Guild
									}, false);
								}
								else
								{
									CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Guild Request", request.Sender + " would like you to join their Guild, do you wish to accept? ", request.Sender, LPBPDPMJKNN.PJIJIFKBMBB.YesNo, true, null, 59, true);
								}
							}
							else if (request.Type == PSXAPI.Response.RequestType.TradeDecline)
							{
								CNCJKLNHQBH.QOQONHOOLNE.MIDPIFHNNDK(request.Sender + " declined the Trade Request.");
							}
							else if (request.Type == PSXAPI.Response.RequestType.BattleDecline)
							{
								CNCJKLNHQBH.QOQONHOOLNE.MIDPIFHNNDK(request.Sender + " declined the Battle Request.");
							}
							else if (request.Type == PSXAPI.Response.RequestType.FriendDecline)
							{
								CNCJKLNHQBH.QOQONHOOLNE.MIDPIFHNNDK(request.Sender + " declined the Friend Request.");
							}
							else if (request.Type == PSXAPI.Response.RequestType.GuildDecline)
							{
								CNCJKLNHQBH.QOQONHOOLNE.MIDPIFHNNDK(request.Sender + " declined the Guild Request.");
							}
						}
					}
				}
				IL_1459:;
			}
		}
	}

	// Token: 0x06004B2E RID: 19246 RVA: 0x0026B218 File Offset: 0x00269418
	public void EPNBECQFKEK()
	{
		if (this.ODOGMJJQQKE)
		{
			return;
		}
		if (!this.JOQBIMQCNDO)
		{
			this.EGDKLIHHJEG.Clear();
			this.FPQLHPFDFGI.Clear();
			this.ODOGMJJQQKE = true;
			this.JOQBIMQCNDO = false;
			if (this.CBMLQJPGPMO != null)
			{
				this.CBMLQJPGPMO.Dispose();
			}
			base.CancelInvoke("HideResponse");
			this.BEDINLHEHDB.PIDLOFMIEFQ = "Connecting to Server..";
			this.LQFIDMKBJBF.SetActive(false);
			this.CBMLQJPGPMO = new Connection();
			switch (UnityEngine.Random.Range(0, 4))
			{
			case 0:
				this.MGKCHOQDBQD = "game.poke.one";
				break;
			case 1:
				this.MGKCHOQDBQD = "game2.poke.one";
				break;
			case 2:
				this.MGKCHOQDBQD = "game3.poke.one";
				break;
			case 3:
				this.MGKCHOQDBQD = "game4.poke.one";
				break;
			}
			this.CBMLQJPGPMO.Connect(this.MGKCHOQDBQD, this.BLJNJLGJHLD);
			return;
		}
		if (this.CBMLQJPGPMO != null && this.CBMLQJPGPMO.IsConnected)
		{
			return;
		}
	}

	// Token: 0x06004B2F RID: 19247 RVA: 0x00268C58 File Offset: 0x00266E58
	private IEnumerator OOQMPLNGGJJ()
	{
		yield return new WaitForSeconds(this.FNDBKCIPBKO);
		return 1;
		if (this.NKIJOONCCDQ.Count <= 0)
		{
			goto IL_77;
		}
		GDDKPIHHICF.HBFFCJHOCPE.CBMLQJPGPMO.Send(this.NKIJOONCCDQ.Dequeue());
		IL_77:
		yield break;
	}

	// Token: 0x06004B30 RID: 19248 RVA: 0x0026B320 File Offset: 0x00269520
	public void MOIKNOKFIQF()
	{
		if (UnityEngine.Time.time > this.INKDJJOHQNQ + 2f)
		{
			this.INKDJJOHQNQ = UnityEngine.Time.time;
			if (this.EFOGMBCFBGM && CNCJKLNHQBH.QOQONHOOLNE != null)
			{
				if (this.CBMLQJPGPMO.Ping >= 5000)
				{
					CNCJKLNHQBH.QOQONHOOLNE.LHFFLGHLPQO.SetActive(true);
					if (this.CBMLQJPGPMO.PingUpdateTime.TotalSeconds != 2.0)
					{
						this.CBMLQJPGPMO.PingUpdateTime = TimeSpan.FromSeconds(2.0);
					}
				}
				else
				{
					CNCJKLNHQBH.QOQONHOOLNE.LHFFLGHLPQO.SetActive(false);
					if (this.CBMLQJPGPMO.PingUpdateTime.TotalSeconds != 5.0)
					{
						this.CBMLQJPGPMO.PingUpdateTime = TimeSpan.FromSeconds(5.0);
					}
				}
			}
		}
		if (UnityEngine.Time.time > this.IMQNHDIEFMM + this.COFDEBBQNKF && this.JIKKBCNDLOC.Count > 0)
		{
			this.PDKBHHPOQPJ();
		}
	}

	// Token: 0x06004B31 RID: 19249 RVA: 0x0001F1CE File Offset: 0x0001D3CE
	public void PJLQKEJMDPG(string IHIHHCCEDHQ)
	{
		CNCJKLNHQBH.QOQONHOOLNE.CGKGBEICHMH = IHIHHCCEDHQ;
		MBGHQMKEFKO.QOQONHOOLNE.BQLIIQIIMDH();
		CNCJKLNHQBH.QOQONHOOLNE.QQEBEJLJDFH = this.QQEBEJLJDFH;
		GFHGEJNHLFQ.QOQONHOOLNE.CBGPDPJLFNE();
	}

	// Token: 0x06004B32 RID: 19250 RVA: 0x0026B434 File Offset: 0x00269634
	public void FGQOFOQMNID()
	{
		this.NKIJOONCCDQ = new Queue<IProto>();
		this.JIKKBCNDLOC = new List<PSXAPI.Request.Move>();
		if (this.CBMLQJPGPMO != null)
		{
			this.CBMLQJPGPMO.Disconnect();
			this.CBMLQJPGPMO.Dispose();
			this.CBMLQJPGPMO = null;
		}
		if (this.EFOGMBCFBGM)
		{
			this.EFOGMBCFBGM = true;
			SceneManager.LoadScene("COLOR_GRADING");
		}
		this.NCBPEGNKKCM = false;
		this.HCFPCELLGGQ = false;
		this.ODOGMJJQQKE = true;
		this.JOQBIMQCNDO = true;
	}

	// Token: 0x06004B33 RID: 19251 RVA: 0x0026B4B4 File Offset: 0x002696B4
	public void HHBIOMNQDJG(PSXAPI.Response.Login KOEEIBDFFGE)
	{
		this.LQFIDMKBJBF.SetActive(false);
		if (KOEEIBDFFGE.Result == LoginResult.Success)
		{
			KDJLKQQBGNE.QOQONHOOLNE.Reset();
			this.SaveLogin();
			base.StartCoroutine(this.NFJKCEOGNKL(KOEEIBDFFGE));
		}
		else
		{
			this.BEDINLHEHDB.transform.parent.gameObject.SetActive(true);
			base.CancelInvoke("HideResponse");
			if (KOEEIBDFFGE.Error == LoginError.AccountNotFound)
			{
				this.BEDINLHEHDB.PIDLOFMIEFQ = "Invalid Username or Password..";
			}
			else if (KOEEIBDFFGE.Error == LoginError.WrongPassword)
			{
				this.BEDINLHEHDB.PIDLOFMIEFQ = "Invalid Username or Password..";
			}
			else if (KOEEIBDFFGE.Error == LoginError.AlreadyLoggedIn)
			{
				this.BEDINLHEHDB.PIDLOFMIEFQ = "Your account is already logged in..";
			}
			else if (KOEEIBDFFGE.Error == LoginError.Unsupported)
			{
				this.BEDINLHEHDB.PIDLOFMIEFQ = "Your game version is out of date..";
			}
			else if (KOEEIBDFFGE.Error == LoginError.Banned)
			{
				if (KOEEIBDFFGE.Banned.Permanent)
				{
					this.BEDINLHEHDB.PIDLOFMIEFQ = "Your account is Banned.";
					this.OBCNMKNGFIF("Account Suspended", "Reason: " + KOEEIBDFFGE.Banned.Reason, string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, true);
				}
				else
				{
					this.BEDINLHEHDB.PIDLOFMIEFQ = "Your account is Temporarily Suspended.";
					this.OBCNMKNGFIF("Temporarily Suspended", "Reason: " + KOEEIBDFFGE.Banned.Reason, string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, true);
				}
			}
			else
			{
				if (KOEEIBDFFGE.Error == LoginError.NotVerified)
				{
					ENEINMKKFHQ.QOQONHOOLNE.MBPHKDQMJJH = KOEEIBDFFGE.Username;
					this.BEDINLHEHDB.PIDLOFMIEFQ = "You account is not Verified yet..";
					ENEINMKKFHQ.QOQONHOOLNE.Open();
					return;
				}
				this.BEDINLHEHDB.PIDLOFMIEFQ = "Login Error";
			}
			base.Invoke("HideResponse", 3f);
			this.NJNCGMFPHFI();
		}
	}

	// Token: 0x06004B34 RID: 19252 RVA: 0x0026B67C File Offset: 0x0026987C
	public void DEBGPFHHPMM()
	{
		this.NKIJOONCCDQ = new Queue<IProto>();
		this.JIKKBCNDLOC = new List<PSXAPI.Request.Move>();
		if (this.CBMLQJPGPMO != null)
		{
			this.CBMLQJPGPMO.Disconnect();
			this.CBMLQJPGPMO.Dispose();
			this.CBMLQJPGPMO = null;
		}
		if (this.EFOGMBCFBGM)
		{
			this.EFOGMBCFBGM = true;
			SceneManager.LoadScene("qTrack");
		}
		this.NCBPEGNKKCM = false;
		this.HCFPCELLGGQ = true;
		this.ODOGMJJQQKE = false;
		this.JOQBIMQCNDO = false;
	}

	// Token: 0x04001017 RID: 4119
	private bool BIECICNHDLK;

	// Token: 0x04001018 RID: 4120
	private Mutex DGDPEFQHILI;

	// Token: 0x04001019 RID: 4121
	private static GDDKPIHHICF HBFFCJHOCPE;

	// Token: 0x0400101A RID: 4122
	private Connection CBMLQJPGPMO;

	// Token: 0x0400101B RID: 4123
	public NNKKGGNIKKN QQEBEJLJDFH;

	// Token: 0x0400101C RID: 4124
	public string QLPEFCHNPQG;

	// Token: 0x0400101D RID: 4125
	public int BLJNJLGJHLD = 807;

	// Token: 0x0400101E RID: 4126
	public string MGKCHOQDBQD;

	// Token: 0x0400101F RID: 4127
	public bool JOQBIMQCNDO;

	// Token: 0x04001020 RID: 4128
	public bool ODOGMJJQQKE;

	// Token: 0x04001021 RID: 4129
	public List<IProto> EGDKLIHHJEG = new List<IProto>();

	// Token: 0x04001022 RID: 4130
	public List<IProto> FPQLHPFDFGI = new List<IProto>();

	// Token: 0x04001023 RID: 4131
	private float HPIGGKPLKBE;

	// Token: 0x04001024 RID: 4132
	public bool OGIIKDBIMIK;

	// Token: 0x04001025 RID: 4133
	public float FNDBKCIPBKO = 1.5f;

	// Token: 0x04001026 RID: 4134
	private Queue<IProto> NKIJOONCCDQ = new Queue<IProto>();

	// Token: 0x04001027 RID: 4135
	private List<PSXAPI.Request.Move> JIKKBCNDLOC = new List<PSXAPI.Request.Move>();

	// Token: 0x04001028 RID: 4136
	private float IMQNHDIEFMM;

	// Token: 0x04001029 RID: 4137
	private float COFDEBBQNKF = 0.75f;

	// Token: 0x0400102A RID: 4138
	private float INKDJJOHQNQ;

	// Token: 0x0400102B RID: 4139
	public JIMBBPLINGI QIOFBCDMLCB;

	// Token: 0x0400102C RID: 4140
	public JIMBBPLINGI LFGLJBKOFIN;

	// Token: 0x0400102D RID: 4141
	public UIToggle HNNDDLEPMHD;

	// Token: 0x0400102E RID: 4142
	public bool EFOGMBCFBGM;

	// Token: 0x0400102F RID: 4143
	public BKKHLBCLPJM BEDINLHEHDB;

	// Token: 0x04001030 RID: 4144
	public bool HCFPCELLGGQ;

	// Token: 0x04001031 RID: 4145
	private bool NCBPEGNKKCM;

	// Token: 0x04001032 RID: 4146
	public GameObject LQFIDMKBJBF;

	// Token: 0x04001033 RID: 4147
	public GameObject QDOOQHPBCLJ;

	// Token: 0x04001034 RID: 4148
	public GameObject EQLPELCDBBC;

	// Token: 0x04001035 RID: 4149
	public string GLDLNDLCCKO = string.Empty;
}
