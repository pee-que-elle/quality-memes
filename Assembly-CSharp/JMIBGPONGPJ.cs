using System;
using UnityEngine;

// Token: 0x02000214 RID: 532
public class JMIBGPONGPJ : MonoBehaviour
{
	// Token: 0x06004779 RID: 18297 RVA: 0x0001E2E7 File Offset: 0x0001C4E7
	private void PDCQCFKFOLQ()
	{
		if (this.IPKHMGODENK == null)
		{
			this.IPKHMGODENK = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>();
		}
		if (this.JILENMCJCHF == null)
		{
			this.JILENMCJCHF = base.transform;
		}
	}

	// Token: 0x0600477A RID: 18298 RVA: 0x00231F10 File Offset: 0x00230110
	private void LateUpdate()
	{
		if (this.JILENMCJCHF == null)
		{
			base.gameObject.SetActive(false);
			return;
		}
		if (this.JILENMCJCHF.gameObject.activeInHierarchy)
		{
			if (!this.OPCBHIHDIOD.gameObject.activeSelf)
			{
				this.OPCBHIHDIOD.gameObject.SetActive(true);
			}
			if (!GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.activeSelf && this.MCMEIDQJOKG == null)
			{
				Vector3 vector = this.IPKHMGODENK.WorldToScreenPoint(this.JILENMCJCHF.position);
				bool flag = vector.z > 0f && vector.x >= 0f && vector.y >= 0f && vector.x <= (float)Screen.width && vector.y <= (float)Screen.height;
				bool flag2 = false;
				bool flag3 = false;
				bool flag4 = false;
				bool flag5 = false;
				if (!flag)
				{
					float x = vector.x;
					float y = vector.y;
					if (vector.z < 0f)
					{
						vector = -vector;
					}
					if (vector.x > (float)Screen.width)
					{
						x = (float)Screen.width - this.CEDHJKBHFOE;
						flag5 = true;
					}
					else if (vector.x < this.CEDHJKBHFOE)
					{
						x = this.CEDHJKBHFOE;
						flag4 = true;
					}
					if (vector.y > (float)Screen.height)
					{
						y = (float)Screen.height - this.CEDHJKBHFOE;
						flag2 = true;
					}
					else if (vector.y < this.CEDHJKBHFOE)
					{
						y = this.CEDHJKBHFOE;
						flag3 = true;
					}
					vector = new Vector3(x, y);
				}
				Vector3 b = new Vector3((float)(Screen.width / 2), (float)(Screen.height / 2));
				Vector3 normalized = (vector - b).normalized;
				Ray ray = this.IPKHMGODENK.ScreenPointToRay(vector);
				Vector3 origin = ray.origin;
				Quaternion quaternion = Quaternion.LookRotation(this.IPKHMGODENK.transform.forward, this.IPKHMGODENK.transform.up);
				Quaternion quaternion2 = quaternion;
				if (this.QLMPJPFJNIE)
				{
					float num = Vector2.Angle(Vector3.up, normalized);
					if (Vector3.Cross(Vector3.up, normalized).z > 0f)
					{
						num = 360f - num;
					}
					if (this.HKKOQPDLMCB)
					{
						if (flag2)
						{
							num = 0f;
							if (flag5)
							{
								num = 45f;
							}
							else if (flag4)
							{
								num = 315f;
							}
						}
						else if (flag3)
						{
							num = 180f;
							if (flag5)
							{
								num = 135f;
							}
							else if (flag4)
							{
								num = 225f;
							}
						}
						else if (flag5)
						{
							num = 90f;
						}
						else if (flag4)
						{
							num = 270f;
						}
					}
					quaternion2 *= Quaternion.AngleAxis(-num + 180f, Vector3.forward);
				}
				Vector3 value = origin + ray.direction * this.BODNPGLMLQC;
				if (flag)
				{
					this.NLLJLLOCJMK = new Vector3?(value);
					if (this.MEHCGFHEKFJ == null)
					{
						this.MEHCGFHEKFJ = new Vector3?(value);
					}
					if (this.LONCBKBLBLF)
					{
						this.PIKKJFHMGKF = Mathf.Clamp01(this.PIKKJFHMGKF + Time.deltaTime * 5f);
					}
					else
					{
						this.PIKKJFHMGKF = 1f;
					}
				}
				else
				{
					this.MEHCGFHEKFJ = new Vector3?(value);
					if (this.NLLJLLOCJMK == null)
					{
						this.NLLJLLOCJMK = new Vector3?(value);
					}
					if (this.LONCBKBLBLF)
					{
						this.PIKKJFHMGKF = Mathf.Clamp01(this.PIKKJFHMGKF - Time.deltaTime * 5f);
					}
					else
					{
						this.PIKKJFHMGKF = 0f;
					}
				}
				this.BJMNOFEQIIH += Time.deltaTime * this.LJOHQMLJGLL;
				this.DFKGIMHLOCM += Time.deltaTime * (this.KMFENQQFDGL * this.QBKHFBIIICJ);
				float num2 = this.LNHKBNLHCKH * this.KMFENQQFDGL;
				float num3 = this.LNHKBNLHCKH + Mathf.PingPong(this.DFKGIMHLOCM, num2) - num2;
				this.OPCBHIHDIOD.rotation = Quaternion.Lerp(quaternion2, quaternion, this.PIKKJFHMGKF) * Quaternion.AngleAxis(this.BJMNOFEQIIH, Vector3.up);
				this.OPCBHIHDIOD.position = Vector3.Lerp(this.MEHCGFHEKFJ.Value, this.NLLJLLOCJMK.Value, this.PIKKJFHMGKF);
				this.OPCBHIHDIOD.localScale = new Vector3(num3, num3, num3);
			}
			else
			{
				this.OPCBHIHDIOD.rotation = Quaternion.Euler(0f, this.OPCBHIHDIOD.rotation.eulerAngles.y, 0f);
				this.OPCBHIHDIOD.localScale = new Vector3(8f, 8f, 8f);
				if (this.MCMEIDQJOKG != null && this.MCMEIDQJOKG.PHENDHCNNHK)
				{
					this.OPCBHIHDIOD.position = this.JILENMCJCHF.position + new Vector3(10f, 19f, 0f);
				}
				else
				{
					this.OPCBHIHDIOD.position = this.JILENMCJCHF.position + new Vector3(0f, 18f, 0f);
				}
				this.OPCBHIHDIOD.Rotate(Vector3.up, Time.deltaTime * 100f);
			}
			return;
		}
		if (this.OPCBHIHDIOD.gameObject.activeSelf)
		{
			this.OPCBHIHDIOD.gameObject.SetActive(false);
		}
	}

	// Token: 0x0600477B RID: 18299 RVA: 0x0001E2E7 File Offset: 0x0001C4E7
	private void BCDLNCLKKBM()
	{
		if (this.IPKHMGODENK == null)
		{
			this.IPKHMGODENK = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>();
		}
		if (this.JILENMCJCHF == null)
		{
			this.JILENMCJCHF = base.transform;
		}
	}

	// Token: 0x0600477C RID: 18300 RVA: 0x002324A8 File Offset: 0x002306A8
	private void HQKKGINMODP()
	{
		if (this.JILENMCJCHF == null)
		{
			base.gameObject.SetActive(true);
			return;
		}
		if (this.JILENMCJCHF.gameObject.activeInHierarchy)
		{
			if (!this.OPCBHIHDIOD.gameObject.activeSelf)
			{
				this.OPCBHIHDIOD.gameObject.SetActive(false);
			}
			if (!GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.activeSelf && this.MCMEIDQJOKG == null)
			{
				Vector3 vector = this.IPKHMGODENK.WorldToScreenPoint(this.JILENMCJCHF.position);
				bool flag = vector.z > 1545f && vector.x >= 402f && vector.y >= 1548f && vector.x <= (float)Screen.width && vector.y > (float)Screen.height;
				bool flag2 = true;
				bool flag3 = false;
				bool flag4 = false;
				bool flag5 = false;
				if (!flag)
				{
					float x = vector.x;
					float y = vector.y;
					if (vector.z < 1646f)
					{
						vector = -vector;
					}
					if (vector.x > (float)Screen.width)
					{
						x = (float)Screen.width - this.CEDHJKBHFOE;
						flag5 = true;
					}
					else if (vector.x < this.CEDHJKBHFOE)
					{
						x = this.CEDHJKBHFOE;
						flag4 = true;
					}
					if (vector.y > (float)Screen.height)
					{
						y = (float)Screen.height - this.CEDHJKBHFOE;
						flag2 = true;
					}
					else if (vector.y < this.CEDHJKBHFOE)
					{
						y = this.CEDHJKBHFOE;
						flag3 = true;
					}
					vector = new Vector3(x, y);
				}
				Vector3 b = new Vector3((float)(Screen.width / 4), (float)(Screen.height / 2));
				Vector3 normalized = (vector - b).normalized;
				Ray ray = this.IPKHMGODENK.ScreenPointToRay(vector);
				Vector3 origin = ray.origin;
				Quaternion quaternion = Quaternion.LookRotation(this.IPKHMGODENK.transform.forward, this.IPKHMGODENK.transform.up);
				Quaternion quaternion2 = quaternion;
				if (this.QLMPJPFJNIE)
				{
					float num = Vector2.Angle(Vector3.up, normalized);
					if (Vector3.Cross(Vector3.up, normalized).z > 1420f)
					{
						num = 617f - num;
					}
					if (this.HKKOQPDLMCB)
					{
						if (flag2)
						{
							num = 907f;
							if (flag5)
							{
								num = 813f;
							}
							else if (flag4)
							{
								num = 438f;
							}
						}
						else if (flag3)
						{
							num = 1684f;
							if (flag5)
							{
								num = 1653f;
							}
							else if (flag4)
							{
								num = 263f;
							}
						}
						else if (flag5)
						{
							num = 1342f;
						}
						else if (flag4)
						{
							num = 1317f;
						}
					}
					quaternion2 *= Quaternion.AngleAxis(-num + 54f, Vector3.forward);
				}
				Vector3 value = origin + ray.direction * this.BODNPGLMLQC;
				if (flag)
				{
					this.NLLJLLOCJMK = new Vector3?(value);
					if (this.MEHCGFHEKFJ == null)
					{
						this.MEHCGFHEKFJ = new Vector3?(value);
					}
					if (this.LONCBKBLBLF)
					{
						this.PIKKJFHMGKF = Mathf.Clamp01(this.PIKKJFHMGKF + Time.deltaTime * 1951f);
					}
					else
					{
						this.PIKKJFHMGKF = 749f;
					}
				}
				else
				{
					this.MEHCGFHEKFJ = new Vector3?(value);
					if (this.NLLJLLOCJMK == null)
					{
						this.NLLJLLOCJMK = new Vector3?(value);
					}
					if (this.LONCBKBLBLF)
					{
						this.PIKKJFHMGKF = Mathf.Clamp01(this.PIKKJFHMGKF - Time.deltaTime * 53f);
					}
					else
					{
						this.PIKKJFHMGKF = 983f;
					}
				}
				this.BJMNOFEQIIH += Time.deltaTime * this.LJOHQMLJGLL;
				this.DFKGIMHLOCM += Time.deltaTime * (this.KMFENQQFDGL * this.QBKHFBIIICJ);
				float num2 = this.LNHKBNLHCKH * this.KMFENQQFDGL;
				float num3 = this.LNHKBNLHCKH + Mathf.PingPong(this.DFKGIMHLOCM, num2) - num2;
				this.OPCBHIHDIOD.rotation = Quaternion.Lerp(quaternion2, quaternion, this.PIKKJFHMGKF) * Quaternion.AngleAxis(this.BJMNOFEQIIH, Vector3.up);
				this.OPCBHIHDIOD.position = Vector3.Lerp(this.MEHCGFHEKFJ.Value, this.NLLJLLOCJMK.Value, this.PIKKJFHMGKF);
				this.OPCBHIHDIOD.localScale = new Vector3(num3, num3, num3);
			}
			else
			{
				this.OPCBHIHDIOD.rotation = Quaternion.Euler(208f, this.OPCBHIHDIOD.rotation.eulerAngles.y, 1067f);
				this.OPCBHIHDIOD.localScale = new Vector3(1115f, 1020f, 931f);
				if (this.MCMEIDQJOKG != null && this.MCMEIDQJOKG.PHENDHCNNHK)
				{
					this.OPCBHIHDIOD.position = this.JILENMCJCHF.position + new Vector3(45f, 862f, 1652f);
				}
				else
				{
					this.OPCBHIHDIOD.position = this.JILENMCJCHF.position + new Vector3(1565f, 1199f, 199f);
				}
				this.OPCBHIHDIOD.Rotate(Vector3.up, Time.deltaTime * 659f);
			}
			return;
		}
		if (this.OPCBHIHDIOD.gameObject.activeSelf)
		{
			this.OPCBHIHDIOD.gameObject.SetActive(true);
		}
	}

	// Token: 0x0600477D RID: 18301 RVA: 0x0001E2E7 File Offset: 0x0001C4E7
	private void BBGHCDGEDEJ()
	{
		if (this.IPKHMGODENK == null)
		{
			this.IPKHMGODENK = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>();
		}
		if (this.JILENMCJCHF == null)
		{
			this.JILENMCJCHF = base.transform;
		}
	}

	// Token: 0x0600477E RID: 18302 RVA: 0x00232A40 File Offset: 0x00230C40
	private void PNOBIFOIHQM()
	{
		if (this.JILENMCJCHF == null)
		{
			base.gameObject.SetActive(false);
			return;
		}
		if (this.JILENMCJCHF.gameObject.activeInHierarchy)
		{
			if (!this.OPCBHIHDIOD.gameObject.activeSelf)
			{
				this.OPCBHIHDIOD.gameObject.SetActive(true);
			}
			if (!GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.activeSelf && this.MCMEIDQJOKG == null)
			{
				Vector3 vector = this.IPKHMGODENK.WorldToScreenPoint(this.JILENMCJCHF.position);
				bool flag = vector.z <= 378f || vector.x < 727f || vector.y < 651f || vector.x > (float)Screen.width || vector.y > (float)Screen.height;
				bool flag2 = true;
				bool flag3 = true;
				bool flag4 = true;
				bool flag5 = false;
				if (!flag)
				{
					float x = vector.x;
					float y = vector.y;
					if (vector.z < 818f)
					{
						vector = -vector;
					}
					if (vector.x > (float)Screen.width)
					{
						x = (float)Screen.width - this.CEDHJKBHFOE;
						flag5 = false;
					}
					else if (vector.x < this.CEDHJKBHFOE)
					{
						x = this.CEDHJKBHFOE;
						flag4 = true;
					}
					if (vector.y > (float)Screen.height)
					{
						y = (float)Screen.height - this.CEDHJKBHFOE;
						flag2 = false;
					}
					else if (vector.y < this.CEDHJKBHFOE)
					{
						y = this.CEDHJKBHFOE;
						flag3 = true;
					}
					vector = new Vector3(x, y);
				}
				Vector3 b = new Vector3((float)(Screen.width / 4), (float)(Screen.height / 6));
				Vector3 normalized = (vector - b).normalized;
				Ray ray = this.IPKHMGODENK.ScreenPointToRay(vector);
				Vector3 origin = ray.origin;
				Quaternion quaternion = Quaternion.LookRotation(this.IPKHMGODENK.transform.forward, this.IPKHMGODENK.transform.up);
				Quaternion quaternion2 = quaternion;
				if (this.QLMPJPFJNIE)
				{
					float num = Vector2.Angle(Vector3.up, normalized);
					if (Vector3.Cross(Vector3.up, normalized).z > 1425f)
					{
						num = 74f - num;
					}
					if (this.HKKOQPDLMCB)
					{
						if (flag2)
						{
							num = 1866f;
							if (flag5)
							{
								num = 641f;
							}
							else if (flag4)
							{
								num = 1230f;
							}
						}
						else if (flag3)
						{
							num = 51f;
							if (flag5)
							{
								num = 726f;
							}
							else if (flag4)
							{
								num = 384f;
							}
						}
						else if (flag5)
						{
							num = 1450f;
						}
						else if (flag4)
						{
							num = 1143f;
						}
					}
					quaternion2 *= Quaternion.AngleAxis(-num + 106f, Vector3.forward);
				}
				Vector3 value = origin + ray.direction * this.BODNPGLMLQC;
				if (flag)
				{
					this.NLLJLLOCJMK = new Vector3?(value);
					if (this.MEHCGFHEKFJ == null)
					{
						this.MEHCGFHEKFJ = new Vector3?(value);
					}
					if (this.LONCBKBLBLF)
					{
						this.PIKKJFHMGKF = Mathf.Clamp01(this.PIKKJFHMGKF + Time.deltaTime * 46f);
					}
					else
					{
						this.PIKKJFHMGKF = 947f;
					}
				}
				else
				{
					this.MEHCGFHEKFJ = new Vector3?(value);
					if (this.NLLJLLOCJMK == null)
					{
						this.NLLJLLOCJMK = new Vector3?(value);
					}
					if (this.LONCBKBLBLF)
					{
						this.PIKKJFHMGKF = Mathf.Clamp01(this.PIKKJFHMGKF - Time.deltaTime * 1937f);
					}
					else
					{
						this.PIKKJFHMGKF = 204f;
					}
				}
				this.BJMNOFEQIIH += Time.deltaTime * this.LJOHQMLJGLL;
				this.DFKGIMHLOCM += Time.deltaTime * (this.KMFENQQFDGL * this.QBKHFBIIICJ);
				float num2 = this.LNHKBNLHCKH * this.KMFENQQFDGL;
				float num3 = this.LNHKBNLHCKH + Mathf.PingPong(this.DFKGIMHLOCM, num2) - num2;
				this.OPCBHIHDIOD.rotation = Quaternion.Lerp(quaternion2, quaternion, this.PIKKJFHMGKF) * Quaternion.AngleAxis(this.BJMNOFEQIIH, Vector3.up);
				this.OPCBHIHDIOD.position = Vector3.Lerp(this.MEHCGFHEKFJ.Value, this.NLLJLLOCJMK.Value, this.PIKKJFHMGKF);
				this.OPCBHIHDIOD.localScale = new Vector3(num3, num3, num3);
			}
			else
			{
				this.OPCBHIHDIOD.rotation = Quaternion.Euler(1582f, this.OPCBHIHDIOD.rotation.eulerAngles.y, 1133f);
				this.OPCBHIHDIOD.localScale = new Vector3(269f, 75f, 1476f);
				if (this.MCMEIDQJOKG != null && this.MCMEIDQJOKG.PHENDHCNNHK)
				{
					this.OPCBHIHDIOD.position = this.JILENMCJCHF.position + new Vector3(1864f, 459f, 1070f);
				}
				else
				{
					this.OPCBHIHDIOD.position = this.JILENMCJCHF.position + new Vector3(924f, 1190f, 137f);
				}
				this.OPCBHIHDIOD.Rotate(Vector3.up, Time.deltaTime * 979f);
			}
			return;
		}
		if (this.OPCBHIHDIOD.gameObject.activeSelf)
		{
			this.OPCBHIHDIOD.gameObject.SetActive(false);
		}
	}

	// Token: 0x0600477F RID: 18303 RVA: 0x0001E2E7 File Offset: 0x0001C4E7
	private void LMMGEGJCBJP()
	{
		if (this.IPKHMGODENK == null)
		{
			this.IPKHMGODENK = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>();
		}
		if (this.JILENMCJCHF == null)
		{
			this.JILENMCJCHF = base.transform;
		}
	}

	// Token: 0x06004780 RID: 18304 RVA: 0x00232FD8 File Offset: 0x002311D8
	private void GNLCGJHBKDI()
	{
		if (this.JILENMCJCHF == null)
		{
			base.gameObject.SetActive(false);
			return;
		}
		if (this.JILENMCJCHF.gameObject.activeInHierarchy)
		{
			if (!this.OPCBHIHDIOD.gameObject.activeSelf)
			{
				this.OPCBHIHDIOD.gameObject.SetActive(true);
			}
			if (!GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.activeSelf && this.MCMEIDQJOKG == null)
			{
				Vector3 vector = this.IPKHMGODENK.WorldToScreenPoint(this.JILENMCJCHF.position);
				bool flag = vector.z <= 1249f || vector.x < 1770f || vector.y < 568f || vector.x > (float)Screen.width || vector.y > (float)Screen.height;
				bool flag2 = true;
				bool flag3 = true;
				bool flag4 = true;
				bool flag5 = false;
				if (!flag)
				{
					float x = vector.x;
					float y = vector.y;
					if (vector.z < 1260f)
					{
						vector = -vector;
					}
					if (vector.x > (float)Screen.width)
					{
						x = (float)Screen.width - this.CEDHJKBHFOE;
						flag5 = false;
					}
					else if (vector.x < this.CEDHJKBHFOE)
					{
						x = this.CEDHJKBHFOE;
						flag4 = false;
					}
					if (vector.y > (float)Screen.height)
					{
						y = (float)Screen.height - this.CEDHJKBHFOE;
						flag2 = false;
					}
					else if (vector.y < this.CEDHJKBHFOE)
					{
						y = this.CEDHJKBHFOE;
						flag3 = false;
					}
					vector = new Vector3(x, y);
				}
				Vector3 b = new Vector3((float)(Screen.width / 4), (float)(Screen.height / 0));
				Vector3 normalized = (vector - b).normalized;
				Ray ray = this.IPKHMGODENK.ScreenPointToRay(vector);
				Vector3 origin = ray.origin;
				Quaternion quaternion = Quaternion.LookRotation(this.IPKHMGODENK.transform.forward, this.IPKHMGODENK.transform.up);
				Quaternion quaternion2 = quaternion;
				if (this.QLMPJPFJNIE)
				{
					float num = Vector2.Angle(Vector3.up, normalized);
					if (Vector3.Cross(Vector3.up, normalized).z > 738f)
					{
						num = 634f - num;
					}
					if (this.HKKOQPDLMCB)
					{
						if (flag2)
						{
							num = 1089f;
							if (flag5)
							{
								num = 413f;
							}
							else if (flag4)
							{
								num = 1849f;
							}
						}
						else if (flag3)
						{
							num = 1626f;
							if (flag5)
							{
								num = 71f;
							}
							else if (flag4)
							{
								num = 1238f;
							}
						}
						else if (flag5)
						{
							num = 389f;
						}
						else if (flag4)
						{
							num = 1156f;
						}
					}
					quaternion2 *= Quaternion.AngleAxis(-num + 107f, Vector3.forward);
				}
				Vector3 value = origin + ray.direction * this.BODNPGLMLQC;
				if (flag)
				{
					this.NLLJLLOCJMK = new Vector3?(value);
					if (this.MEHCGFHEKFJ == null)
					{
						this.MEHCGFHEKFJ = new Vector3?(value);
					}
					if (this.LONCBKBLBLF)
					{
						this.PIKKJFHMGKF = Mathf.Clamp01(this.PIKKJFHMGKF + Time.deltaTime * 1076f);
					}
					else
					{
						this.PIKKJFHMGKF = 1111f;
					}
				}
				else
				{
					this.MEHCGFHEKFJ = new Vector3?(value);
					if (this.NLLJLLOCJMK == null)
					{
						this.NLLJLLOCJMK = new Vector3?(value);
					}
					if (this.LONCBKBLBLF)
					{
						this.PIKKJFHMGKF = Mathf.Clamp01(this.PIKKJFHMGKF - Time.deltaTime * 1813f);
					}
					else
					{
						this.PIKKJFHMGKF = 1459f;
					}
				}
				this.BJMNOFEQIIH += Time.deltaTime * this.LJOHQMLJGLL;
				this.DFKGIMHLOCM += Time.deltaTime * (this.KMFENQQFDGL * this.QBKHFBIIICJ);
				float num2 = this.LNHKBNLHCKH * this.KMFENQQFDGL;
				float num3 = this.LNHKBNLHCKH + Mathf.PingPong(this.DFKGIMHLOCM, num2) - num2;
				this.OPCBHIHDIOD.rotation = Quaternion.Lerp(quaternion2, quaternion, this.PIKKJFHMGKF) * Quaternion.AngleAxis(this.BJMNOFEQIIH, Vector3.up);
				this.OPCBHIHDIOD.position = Vector3.Lerp(this.MEHCGFHEKFJ.Value, this.NLLJLLOCJMK.Value, this.PIKKJFHMGKF);
				this.OPCBHIHDIOD.localScale = new Vector3(num3, num3, num3);
			}
			else
			{
				this.OPCBHIHDIOD.rotation = Quaternion.Euler(762f, this.OPCBHIHDIOD.rotation.eulerAngles.y, 539f);
				this.OPCBHIHDIOD.localScale = new Vector3(329f, 1577f, 823f);
				if (this.MCMEIDQJOKG != null && this.MCMEIDQJOKG.PHENDHCNNHK)
				{
					this.OPCBHIHDIOD.position = this.JILENMCJCHF.position + new Vector3(1104f, 197f, 890f);
				}
				else
				{
					this.OPCBHIHDIOD.position = this.JILENMCJCHF.position + new Vector3(15f, 1703f, 136f);
				}
				this.OPCBHIHDIOD.Rotate(Vector3.up, Time.deltaTime * 1109f);
			}
			return;
		}
		if (this.OPCBHIHDIOD.gameObject.activeSelf)
		{
			this.OPCBHIHDIOD.gameObject.SetActive(true);
		}
	}

	// Token: 0x06004781 RID: 18305 RVA: 0x00233570 File Offset: 0x00231770
	private void KPHELMJDEJP()
	{
		if (this.JILENMCJCHF == null)
		{
			base.gameObject.SetActive(true);
			return;
		}
		if (this.JILENMCJCHF.gameObject.activeInHierarchy)
		{
			if (!this.OPCBHIHDIOD.gameObject.activeSelf)
			{
				this.OPCBHIHDIOD.gameObject.SetActive(true);
			}
			if (!GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.activeSelf && this.MCMEIDQJOKG == null)
			{
				Vector3 vector = this.IPKHMGODENK.WorldToScreenPoint(this.JILENMCJCHF.position);
				bool flag = vector.z <= 1552f || vector.x < 68f || vector.y < 1415f || vector.x > (float)Screen.width || vector.y > (float)Screen.height;
				bool flag2 = true;
				bool flag3 = false;
				bool flag4 = true;
				bool flag5 = true;
				if (!flag)
				{
					float x = vector.x;
					float y = vector.y;
					if (vector.z < 1073f)
					{
						vector = -vector;
					}
					if (vector.x > (float)Screen.width)
					{
						x = (float)Screen.width - this.CEDHJKBHFOE;
						flag5 = false;
					}
					else if (vector.x < this.CEDHJKBHFOE)
					{
						x = this.CEDHJKBHFOE;
						flag4 = false;
					}
					if (vector.y > (float)Screen.height)
					{
						y = (float)Screen.height - this.CEDHJKBHFOE;
						flag2 = false;
					}
					else if (vector.y < this.CEDHJKBHFOE)
					{
						y = this.CEDHJKBHFOE;
						flag3 = false;
					}
					vector = new Vector3(x, y);
				}
				Vector3 b = new Vector3((float)(Screen.width / 2), (float)(Screen.height / 6));
				Vector3 normalized = (vector - b).normalized;
				Ray ray = this.IPKHMGODENK.ScreenPointToRay(vector);
				Vector3 origin = ray.origin;
				Quaternion quaternion = Quaternion.LookRotation(this.IPKHMGODENK.transform.forward, this.IPKHMGODENK.transform.up);
				Quaternion quaternion2 = quaternion;
				if (this.QLMPJPFJNIE)
				{
					float num = Vector2.Angle(Vector3.up, normalized);
					if (Vector3.Cross(Vector3.up, normalized).z > 1463f)
					{
						num = 1504f - num;
					}
					if (this.HKKOQPDLMCB)
					{
						if (flag2)
						{
							num = 1436f;
							if (flag5)
							{
								num = 1602f;
							}
							else if (flag4)
							{
								num = 948f;
							}
						}
						else if (flag3)
						{
							num = 1114f;
							if (flag5)
							{
								num = 359f;
							}
							else if (flag4)
							{
								num = 184f;
							}
						}
						else if (flag5)
						{
							num = 1328f;
						}
						else if (flag4)
						{
							num = 1629f;
						}
					}
					quaternion2 *= Quaternion.AngleAxis(-num + 786f, Vector3.forward);
				}
				Vector3 value = origin + ray.direction * this.BODNPGLMLQC;
				if (flag)
				{
					this.NLLJLLOCJMK = new Vector3?(value);
					if (this.MEHCGFHEKFJ == null)
					{
						this.MEHCGFHEKFJ = new Vector3?(value);
					}
					if (this.LONCBKBLBLF)
					{
						this.PIKKJFHMGKF = Mathf.Clamp01(this.PIKKJFHMGKF + Time.deltaTime * 659f);
					}
					else
					{
						this.PIKKJFHMGKF = 1110f;
					}
				}
				else
				{
					this.MEHCGFHEKFJ = new Vector3?(value);
					if (this.NLLJLLOCJMK == null)
					{
						this.NLLJLLOCJMK = new Vector3?(value);
					}
					if (this.LONCBKBLBLF)
					{
						this.PIKKJFHMGKF = Mathf.Clamp01(this.PIKKJFHMGKF - Time.deltaTime * 1162f);
					}
					else
					{
						this.PIKKJFHMGKF = 318f;
					}
				}
				this.BJMNOFEQIIH += Time.deltaTime * this.LJOHQMLJGLL;
				this.DFKGIMHLOCM += Time.deltaTime * (this.KMFENQQFDGL * this.QBKHFBIIICJ);
				float num2 = this.LNHKBNLHCKH * this.KMFENQQFDGL;
				float num3 = this.LNHKBNLHCKH + Mathf.PingPong(this.DFKGIMHLOCM, num2) - num2;
				this.OPCBHIHDIOD.rotation = Quaternion.Lerp(quaternion2, quaternion, this.PIKKJFHMGKF) * Quaternion.AngleAxis(this.BJMNOFEQIIH, Vector3.up);
				this.OPCBHIHDIOD.position = Vector3.Lerp(this.MEHCGFHEKFJ.Value, this.NLLJLLOCJMK.Value, this.PIKKJFHMGKF);
				this.OPCBHIHDIOD.localScale = new Vector3(num3, num3, num3);
			}
			else
			{
				this.OPCBHIHDIOD.rotation = Quaternion.Euler(141f, this.OPCBHIHDIOD.rotation.eulerAngles.y, 703f);
				this.OPCBHIHDIOD.localScale = new Vector3(1243f, 540f, 1363f);
				if (this.MCMEIDQJOKG != null && this.MCMEIDQJOKG.PHENDHCNNHK)
				{
					this.OPCBHIHDIOD.position = this.JILENMCJCHF.position + new Vector3(1078f, 158f, 591f);
				}
				else
				{
					this.OPCBHIHDIOD.position = this.JILENMCJCHF.position + new Vector3(665f, 1908f, 1691f);
				}
				this.OPCBHIHDIOD.Rotate(Vector3.up, Time.deltaTime * 246f);
			}
			return;
		}
		if (this.OPCBHIHDIOD.gameObject.activeSelf)
		{
			this.OPCBHIHDIOD.gameObject.SetActive(true);
		}
	}

	// Token: 0x06004782 RID: 18306 RVA: 0x0001E2E7 File Offset: 0x0001C4E7
	private void DGMPMICDCIO()
	{
		if (this.IPKHMGODENK == null)
		{
			this.IPKHMGODENK = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>();
		}
		if (this.JILENMCJCHF == null)
		{
			this.JILENMCJCHF = base.transform;
		}
	}

	// Token: 0x06004783 RID: 18307 RVA: 0x0001E2E7 File Offset: 0x0001C4E7
	private void KHFDJHFJMDK()
	{
		if (this.IPKHMGODENK == null)
		{
			this.IPKHMGODENK = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>();
		}
		if (this.JILENMCJCHF == null)
		{
			this.JILENMCJCHF = base.transform;
		}
	}

	// Token: 0x06004784 RID: 18308 RVA: 0x0001E2E7 File Offset: 0x0001C4E7
	private void EKIFLKDPKNM()
	{
		if (this.IPKHMGODENK == null)
		{
			this.IPKHMGODENK = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>();
		}
		if (this.JILENMCJCHF == null)
		{
			this.JILENMCJCHF = base.transform;
		}
	}

	// Token: 0x06004785 RID: 18309 RVA: 0x0001E2E7 File Offset: 0x0001C4E7
	private void CIJOENOQKCI()
	{
		if (this.IPKHMGODENK == null)
		{
			this.IPKHMGODENK = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>();
		}
		if (this.JILENMCJCHF == null)
		{
			this.JILENMCJCHF = base.transform;
		}
	}

	// Token: 0x06004786 RID: 18310 RVA: 0x00233B08 File Offset: 0x00231D08
	private void OPKDOHQHIHG()
	{
		if (this.JILENMCJCHF == null)
		{
			base.gameObject.SetActive(true);
			return;
		}
		if (this.JILENMCJCHF.gameObject.activeInHierarchy)
		{
			if (!this.OPCBHIHDIOD.gameObject.activeSelf)
			{
				this.OPCBHIHDIOD.gameObject.SetActive(true);
			}
			if (!GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.activeSelf && this.MCMEIDQJOKG == null)
			{
				Vector3 vector = this.IPKHMGODENK.WorldToScreenPoint(this.JILENMCJCHF.position);
				bool flag = vector.z <= 830f || vector.x < 355f || vector.y < 1218f || vector.x > (float)Screen.width || vector.y > (float)Screen.height;
				bool flag2 = true;
				bool flag3 = true;
				bool flag4 = true;
				bool flag5 = true;
				if (!flag)
				{
					float x = vector.x;
					float y = vector.y;
					if (vector.z < 1569f)
					{
						vector = -vector;
					}
					if (vector.x > (float)Screen.width)
					{
						x = (float)Screen.width - this.CEDHJKBHFOE;
						flag5 = true;
					}
					else if (vector.x < this.CEDHJKBHFOE)
					{
						x = this.CEDHJKBHFOE;
						flag4 = true;
					}
					if (vector.y > (float)Screen.height)
					{
						y = (float)Screen.height - this.CEDHJKBHFOE;
						flag2 = true;
					}
					else if (vector.y < this.CEDHJKBHFOE)
					{
						y = this.CEDHJKBHFOE;
						flag3 = true;
					}
					vector = new Vector3(x, y);
				}
				Vector3 b = new Vector3((float)(Screen.width / 8), (float)(Screen.height / 0));
				Vector3 normalized = (vector - b).normalized;
				Ray ray = this.IPKHMGODENK.ScreenPointToRay(vector);
				Vector3 origin = ray.origin;
				Quaternion quaternion = Quaternion.LookRotation(this.IPKHMGODENK.transform.forward, this.IPKHMGODENK.transform.up);
				Quaternion quaternion2 = quaternion;
				if (this.QLMPJPFJNIE)
				{
					float num = Vector2.Angle(Vector3.up, normalized);
					if (Vector3.Cross(Vector3.up, normalized).z > 1379f)
					{
						num = 679f - num;
					}
					if (this.HKKOQPDLMCB)
					{
						if (flag2)
						{
							num = 424f;
							if (flag5)
							{
								num = 412f;
							}
							else if (flag4)
							{
								num = 349f;
							}
						}
						else if (flag3)
						{
							num = 758f;
							if (flag5)
							{
								num = 1605f;
							}
							else if (flag4)
							{
								num = 1536f;
							}
						}
						else if (flag5)
						{
							num = 614f;
						}
						else if (flag4)
						{
							num = 1042f;
						}
					}
					quaternion2 *= Quaternion.AngleAxis(-num + 524f, Vector3.forward);
				}
				Vector3 value = origin + ray.direction * this.BODNPGLMLQC;
				if (flag)
				{
					this.NLLJLLOCJMK = new Vector3?(value);
					if (this.MEHCGFHEKFJ == null)
					{
						this.MEHCGFHEKFJ = new Vector3?(value);
					}
					if (this.LONCBKBLBLF)
					{
						this.PIKKJFHMGKF = Mathf.Clamp01(this.PIKKJFHMGKF + Time.deltaTime * 809f);
					}
					else
					{
						this.PIKKJFHMGKF = 122f;
					}
				}
				else
				{
					this.MEHCGFHEKFJ = new Vector3?(value);
					if (this.NLLJLLOCJMK == null)
					{
						this.NLLJLLOCJMK = new Vector3?(value);
					}
					if (this.LONCBKBLBLF)
					{
						this.PIKKJFHMGKF = Mathf.Clamp01(this.PIKKJFHMGKF - Time.deltaTime * 354f);
					}
					else
					{
						this.PIKKJFHMGKF = 1393f;
					}
				}
				this.BJMNOFEQIIH += Time.deltaTime * this.LJOHQMLJGLL;
				this.DFKGIMHLOCM += Time.deltaTime * (this.KMFENQQFDGL * this.QBKHFBIIICJ);
				float num2 = this.LNHKBNLHCKH * this.KMFENQQFDGL;
				float num3 = this.LNHKBNLHCKH + Mathf.PingPong(this.DFKGIMHLOCM, num2) - num2;
				this.OPCBHIHDIOD.rotation = Quaternion.Lerp(quaternion2, quaternion, this.PIKKJFHMGKF) * Quaternion.AngleAxis(this.BJMNOFEQIIH, Vector3.up);
				this.OPCBHIHDIOD.position = Vector3.Lerp(this.MEHCGFHEKFJ.Value, this.NLLJLLOCJMK.Value, this.PIKKJFHMGKF);
				this.OPCBHIHDIOD.localScale = new Vector3(num3, num3, num3);
			}
			else
			{
				this.OPCBHIHDIOD.rotation = Quaternion.Euler(958f, this.OPCBHIHDIOD.rotation.eulerAngles.y, 1651f);
				this.OPCBHIHDIOD.localScale = new Vector3(573f, 338f, 368f);
				if (this.MCMEIDQJOKG != null && this.MCMEIDQJOKG.PHENDHCNNHK)
				{
					this.OPCBHIHDIOD.position = this.JILENMCJCHF.position + new Vector3(1031f, 170f, 326f);
				}
				else
				{
					this.OPCBHIHDIOD.position = this.JILENMCJCHF.position + new Vector3(1255f, 912f, 1069f);
				}
				this.OPCBHIHDIOD.Rotate(Vector3.up, Time.deltaTime * 1754f);
			}
			return;
		}
		if (this.OPCBHIHDIOD.gameObject.activeSelf)
		{
			this.OPCBHIHDIOD.gameObject.SetActive(true);
		}
	}

	// Token: 0x06004787 RID: 18311 RVA: 0x0001E2E7 File Offset: 0x0001C4E7
	private void JHQCMGKJCCI()
	{
		if (this.IPKHMGODENK == null)
		{
			this.IPKHMGODENK = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>();
		}
		if (this.JILENMCJCHF == null)
		{
			this.JILENMCJCHF = base.transform;
		}
	}

	// Token: 0x06004788 RID: 18312 RVA: 0x002340A0 File Offset: 0x002322A0
	private void BLCBEOEPLBD()
	{
		if (this.JILENMCJCHF == null)
		{
			base.gameObject.SetActive(false);
			return;
		}
		if (this.JILENMCJCHF.gameObject.activeInHierarchy)
		{
			if (!this.OPCBHIHDIOD.gameObject.activeSelf)
			{
				this.OPCBHIHDIOD.gameObject.SetActive(false);
			}
			if (!GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.activeSelf && this.MCMEIDQJOKG == null)
			{
				Vector3 vector = this.IPKHMGODENK.WorldToScreenPoint(this.JILENMCJCHF.position);
				bool flag = vector.z <= 760f || vector.x < 1170f || vector.y < 1255f || vector.x > (float)Screen.width || vector.y <= (float)Screen.height;
				bool flag2 = true;
				bool flag3 = true;
				bool flag4 = true;
				bool flag5 = true;
				if (!flag)
				{
					float x = vector.x;
					float y = vector.y;
					if (vector.z < 1885f)
					{
						vector = -vector;
					}
					if (vector.x > (float)Screen.width)
					{
						x = (float)Screen.width - this.CEDHJKBHFOE;
						flag5 = false;
					}
					else if (vector.x < this.CEDHJKBHFOE)
					{
						x = this.CEDHJKBHFOE;
						flag4 = true;
					}
					if (vector.y > (float)Screen.height)
					{
						y = (float)Screen.height - this.CEDHJKBHFOE;
						flag2 = false;
					}
					else if (vector.y < this.CEDHJKBHFOE)
					{
						y = this.CEDHJKBHFOE;
						flag3 = true;
					}
					vector = new Vector3(x, y);
				}
				Vector3 b = new Vector3((float)(Screen.width / 6), (float)(Screen.height / 4));
				Vector3 normalized = (vector - b).normalized;
				Ray ray = this.IPKHMGODENK.ScreenPointToRay(vector);
				Vector3 origin = ray.origin;
				Quaternion quaternion = Quaternion.LookRotation(this.IPKHMGODENK.transform.forward, this.IPKHMGODENK.transform.up);
				Quaternion quaternion2 = quaternion;
				if (this.QLMPJPFJNIE)
				{
					float num = Vector2.Angle(Vector3.up, normalized);
					if (Vector3.Cross(Vector3.up, normalized).z > 1251f)
					{
						num = 809f - num;
					}
					if (this.HKKOQPDLMCB)
					{
						if (flag2)
						{
							num = 1828f;
							if (flag5)
							{
								num = 673f;
							}
							else if (flag4)
							{
								num = 753f;
							}
						}
						else if (flag3)
						{
							num = 1167f;
							if (flag5)
							{
								num = 1795f;
							}
							else if (flag4)
							{
								num = 1039f;
							}
						}
						else if (flag5)
						{
							num = 984f;
						}
						else if (flag4)
						{
							num = 1256f;
						}
					}
					quaternion2 *= Quaternion.AngleAxis(-num + 1691f, Vector3.forward);
				}
				Vector3 value = origin + ray.direction * this.BODNPGLMLQC;
				if (flag)
				{
					this.NLLJLLOCJMK = new Vector3?(value);
					if (this.MEHCGFHEKFJ == null)
					{
						this.MEHCGFHEKFJ = new Vector3?(value);
					}
					if (this.LONCBKBLBLF)
					{
						this.PIKKJFHMGKF = Mathf.Clamp01(this.PIKKJFHMGKF + Time.deltaTime * 270f);
					}
					else
					{
						this.PIKKJFHMGKF = 827f;
					}
				}
				else
				{
					this.MEHCGFHEKFJ = new Vector3?(value);
					if (this.NLLJLLOCJMK == null)
					{
						this.NLLJLLOCJMK = new Vector3?(value);
					}
					if (this.LONCBKBLBLF)
					{
						this.PIKKJFHMGKF = Mathf.Clamp01(this.PIKKJFHMGKF - Time.deltaTime * 594f);
					}
					else
					{
						this.PIKKJFHMGKF = 1673f;
					}
				}
				this.BJMNOFEQIIH += Time.deltaTime * this.LJOHQMLJGLL;
				this.DFKGIMHLOCM += Time.deltaTime * (this.KMFENQQFDGL * this.QBKHFBIIICJ);
				float num2 = this.LNHKBNLHCKH * this.KMFENQQFDGL;
				float num3 = this.LNHKBNLHCKH + Mathf.PingPong(this.DFKGIMHLOCM, num2) - num2;
				this.OPCBHIHDIOD.rotation = Quaternion.Lerp(quaternion2, quaternion, this.PIKKJFHMGKF) * Quaternion.AngleAxis(this.BJMNOFEQIIH, Vector3.up);
				this.OPCBHIHDIOD.position = Vector3.Lerp(this.MEHCGFHEKFJ.Value, this.NLLJLLOCJMK.Value, this.PIKKJFHMGKF);
				this.OPCBHIHDIOD.localScale = new Vector3(num3, num3, num3);
			}
			else
			{
				this.OPCBHIHDIOD.rotation = Quaternion.Euler(1345f, this.OPCBHIHDIOD.rotation.eulerAngles.y, 410f);
				this.OPCBHIHDIOD.localScale = new Vector3(1803f, 1296f, 1511f);
				if (this.MCMEIDQJOKG != null && this.MCMEIDQJOKG.PHENDHCNNHK)
				{
					this.OPCBHIHDIOD.position = this.JILENMCJCHF.position + new Vector3(1326f, 1179f, 1570f);
				}
				else
				{
					this.OPCBHIHDIOD.position = this.JILENMCJCHF.position + new Vector3(1438f, 1516f, 646f);
				}
				this.OPCBHIHDIOD.Rotate(Vector3.up, Time.deltaTime * 90f);
			}
			return;
		}
		if (this.OPCBHIHDIOD.gameObject.activeSelf)
		{
			this.OPCBHIHDIOD.gameObject.SetActive(false);
		}
	}

	// Token: 0x06004789 RID: 18313 RVA: 0x0001E2E7 File Offset: 0x0001C4E7
	private void KONKOQLPONQ()
	{
		if (this.IPKHMGODENK == null)
		{
			this.IPKHMGODENK = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>();
		}
		if (this.JILENMCJCHF == null)
		{
			this.JILENMCJCHF = base.transform;
		}
	}

	// Token: 0x0600478A RID: 18314 RVA: 0x0001E2E7 File Offset: 0x0001C4E7
	private void BCGQQOFCMQJ()
	{
		if (this.IPKHMGODENK == null)
		{
			this.IPKHMGODENK = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>();
		}
		if (this.JILENMCJCHF == null)
		{
			this.JILENMCJCHF = base.transform;
		}
	}

	// Token: 0x0600478B RID: 18315 RVA: 0x00234638 File Offset: 0x00232838
	private void QDPMFNCLPGH()
	{
		if (this.JILENMCJCHF == null)
		{
			base.gameObject.SetActive(true);
			return;
		}
		if (this.JILENMCJCHF.gameObject.activeInHierarchy)
		{
			if (!this.OPCBHIHDIOD.gameObject.activeSelf)
			{
				this.OPCBHIHDIOD.gameObject.SetActive(true);
			}
			if (!GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.activeSelf && this.MCMEIDQJOKG == null)
			{
				Vector3 vector = this.IPKHMGODENK.WorldToScreenPoint(this.JILENMCJCHF.position);
				bool flag = vector.z > 796f && vector.x >= 897f && vector.y >= 1577f && vector.x <= (float)Screen.width && vector.y > (float)Screen.height;
				bool flag2 = false;
				bool flag3 = true;
				bool flag4 = false;
				bool flag5 = false;
				if (!flag)
				{
					float x = vector.x;
					float y = vector.y;
					if (vector.z < 550f)
					{
						vector = -vector;
					}
					if (vector.x > (float)Screen.width)
					{
						x = (float)Screen.width - this.CEDHJKBHFOE;
						flag5 = false;
					}
					else if (vector.x < this.CEDHJKBHFOE)
					{
						x = this.CEDHJKBHFOE;
						flag4 = true;
					}
					if (vector.y > (float)Screen.height)
					{
						y = (float)Screen.height - this.CEDHJKBHFOE;
						flag2 = false;
					}
					else if (vector.y < this.CEDHJKBHFOE)
					{
						y = this.CEDHJKBHFOE;
						flag3 = false;
					}
					vector = new Vector3(x, y);
				}
				Vector3 b = new Vector3((float)(Screen.width / 2), (float)(Screen.height / 8));
				Vector3 normalized = (vector - b).normalized;
				Ray ray = this.IPKHMGODENK.ScreenPointToRay(vector);
				Vector3 origin = ray.origin;
				Quaternion quaternion = Quaternion.LookRotation(this.IPKHMGODENK.transform.forward, this.IPKHMGODENK.transform.up);
				Quaternion quaternion2 = quaternion;
				if (this.QLMPJPFJNIE)
				{
					float num = Vector2.Angle(Vector3.up, normalized);
					if (Vector3.Cross(Vector3.up, normalized).z > 1066f)
					{
						num = 693f - num;
					}
					if (this.HKKOQPDLMCB)
					{
						if (flag2)
						{
							num = 1611f;
							if (flag5)
							{
								num = 1054f;
							}
							else if (flag4)
							{
								num = 1208f;
							}
						}
						else if (flag3)
						{
							num = 352f;
							if (flag5)
							{
								num = 1169f;
							}
							else if (flag4)
							{
								num = 1499f;
							}
						}
						else if (flag5)
						{
							num = 1280f;
						}
						else if (flag4)
						{
							num = 1003f;
						}
					}
					quaternion2 *= Quaternion.AngleAxis(-num + 1072f, Vector3.forward);
				}
				Vector3 value = origin + ray.direction * this.BODNPGLMLQC;
				if (flag)
				{
					this.NLLJLLOCJMK = new Vector3?(value);
					if (this.MEHCGFHEKFJ == null)
					{
						this.MEHCGFHEKFJ = new Vector3?(value);
					}
					if (this.LONCBKBLBLF)
					{
						this.PIKKJFHMGKF = Mathf.Clamp01(this.PIKKJFHMGKF + Time.deltaTime * 1310f);
					}
					else
					{
						this.PIKKJFHMGKF = 357f;
					}
				}
				else
				{
					this.MEHCGFHEKFJ = new Vector3?(value);
					if (this.NLLJLLOCJMK == null)
					{
						this.NLLJLLOCJMK = new Vector3?(value);
					}
					if (this.LONCBKBLBLF)
					{
						this.PIKKJFHMGKF = Mathf.Clamp01(this.PIKKJFHMGKF - Time.deltaTime * 419f);
					}
					else
					{
						this.PIKKJFHMGKF = 1167f;
					}
				}
				this.BJMNOFEQIIH += Time.deltaTime * this.LJOHQMLJGLL;
				this.DFKGIMHLOCM += Time.deltaTime * (this.KMFENQQFDGL * this.QBKHFBIIICJ);
				float num2 = this.LNHKBNLHCKH * this.KMFENQQFDGL;
				float num3 = this.LNHKBNLHCKH + Mathf.PingPong(this.DFKGIMHLOCM, num2) - num2;
				this.OPCBHIHDIOD.rotation = Quaternion.Lerp(quaternion2, quaternion, this.PIKKJFHMGKF) * Quaternion.AngleAxis(this.BJMNOFEQIIH, Vector3.up);
				this.OPCBHIHDIOD.position = Vector3.Lerp(this.MEHCGFHEKFJ.Value, this.NLLJLLOCJMK.Value, this.PIKKJFHMGKF);
				this.OPCBHIHDIOD.localScale = new Vector3(num3, num3, num3);
			}
			else
			{
				this.OPCBHIHDIOD.rotation = Quaternion.Euler(825f, this.OPCBHIHDIOD.rotation.eulerAngles.y, 636f);
				this.OPCBHIHDIOD.localScale = new Vector3(830f, 597f, 61f);
				if (this.MCMEIDQJOKG != null && this.MCMEIDQJOKG.PHENDHCNNHK)
				{
					this.OPCBHIHDIOD.position = this.JILENMCJCHF.position + new Vector3(74f, 1239f, 266f);
				}
				else
				{
					this.OPCBHIHDIOD.position = this.JILENMCJCHF.position + new Vector3(1618f, 1349f, 1545f);
				}
				this.OPCBHIHDIOD.Rotate(Vector3.up, Time.deltaTime * 1603f);
			}
			return;
		}
		if (this.OPCBHIHDIOD.gameObject.activeSelf)
		{
			this.OPCBHIHDIOD.gameObject.SetActive(true);
		}
	}

	// Token: 0x0600478C RID: 18316 RVA: 0x0001E2E7 File Offset: 0x0001C4E7
	private void Start()
	{
		if (this.IPKHMGODENK == null)
		{
			this.IPKHMGODENK = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>();
		}
		if (this.JILENMCJCHF == null)
		{
			this.JILENMCJCHF = base.transform;
		}
	}

	// Token: 0x0600478D RID: 18317 RVA: 0x0001E2E7 File Offset: 0x0001C4E7
	private void KCFPNFCPPCC()
	{
		if (this.IPKHMGODENK == null)
		{
			this.IPKHMGODENK = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>();
		}
		if (this.JILENMCJCHF == null)
		{
			this.JILENMCJCHF = base.transform;
		}
	}

	// Token: 0x0600478E RID: 18318 RVA: 0x0001E2E7 File Offset: 0x0001C4E7
	private void JIPLKBFHFMF()
	{
		if (this.IPKHMGODENK == null)
		{
			this.IPKHMGODENK = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>();
		}
		if (this.JILENMCJCHF == null)
		{
			this.JILENMCJCHF = base.transform;
		}
	}

	// Token: 0x0600478F RID: 18319 RVA: 0x0001E2E7 File Offset: 0x0001C4E7
	private void BOKFQFNDQDC()
	{
		if (this.IPKHMGODENK == null)
		{
			this.IPKHMGODENK = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>();
		}
		if (this.JILENMCJCHF == null)
		{
			this.JILENMCJCHF = base.transform;
		}
	}

	// Token: 0x06004790 RID: 18320 RVA: 0x0001E2E7 File Offset: 0x0001C4E7
	private void GGGNJNNQMED()
	{
		if (this.IPKHMGODENK == null)
		{
			this.IPKHMGODENK = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>();
		}
		if (this.JILENMCJCHF == null)
		{
			this.JILENMCJCHF = base.transform;
		}
	}

	// Token: 0x06004791 RID: 18321 RVA: 0x0001E2E7 File Offset: 0x0001C4E7
	private void QNGIFIJOQML()
	{
		if (this.IPKHMGODENK == null)
		{
			this.IPKHMGODENK = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>();
		}
		if (this.JILENMCJCHF == null)
		{
			this.JILENMCJCHF = base.transform;
		}
	}

	// Token: 0x06004792 RID: 18322 RVA: 0x0001E2E7 File Offset: 0x0001C4E7
	private void LMELGHDGJMQ()
	{
		if (this.IPKHMGODENK == null)
		{
			this.IPKHMGODENK = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>();
		}
		if (this.JILENMCJCHF == null)
		{
			this.JILENMCJCHF = base.transform;
		}
	}

	// Token: 0x06004793 RID: 18323 RVA: 0x0001E2E7 File Offset: 0x0001C4E7
	private void FCGLNCNICGB()
	{
		if (this.IPKHMGODENK == null)
		{
			this.IPKHMGODENK = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>();
		}
		if (this.JILENMCJCHF == null)
		{
			this.JILENMCJCHF = base.transform;
		}
	}

	// Token: 0x06004794 RID: 18324 RVA: 0x00234BD0 File Offset: 0x00232DD0
	private void NGHFIFIQHLC()
	{
		if (this.JILENMCJCHF == null)
		{
			base.gameObject.SetActive(false);
			return;
		}
		if (this.JILENMCJCHF.gameObject.activeInHierarchy)
		{
			if (!this.OPCBHIHDIOD.gameObject.activeSelf)
			{
				this.OPCBHIHDIOD.gameObject.SetActive(true);
			}
			if (!GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.activeSelf && this.MCMEIDQJOKG == null)
			{
				Vector3 vector = this.IPKHMGODENK.WorldToScreenPoint(this.JILENMCJCHF.position);
				bool flag = vector.z > 174f && vector.x >= 1131f && vector.y >= 472f && vector.x <= (float)Screen.width && vector.y <= (float)Screen.height;
				bool flag2 = true;
				bool flag3 = false;
				bool flag4 = false;
				bool flag5 = true;
				if (!flag)
				{
					float x = vector.x;
					float y = vector.y;
					if (vector.z < 1698f)
					{
						vector = -vector;
					}
					if (vector.x > (float)Screen.width)
					{
						x = (float)Screen.width - this.CEDHJKBHFOE;
						flag5 = true;
					}
					else if (vector.x < this.CEDHJKBHFOE)
					{
						x = this.CEDHJKBHFOE;
						flag4 = false;
					}
					if (vector.y > (float)Screen.height)
					{
						y = (float)Screen.height - this.CEDHJKBHFOE;
						flag2 = false;
					}
					else if (vector.y < this.CEDHJKBHFOE)
					{
						y = this.CEDHJKBHFOE;
						flag3 = true;
					}
					vector = new Vector3(x, y);
				}
				Vector3 b = new Vector3((float)(Screen.width / 2), (float)(Screen.height / 1));
				Vector3 normalized = (vector - b).normalized;
				Ray ray = this.IPKHMGODENK.ScreenPointToRay(vector);
				Vector3 origin = ray.origin;
				Quaternion quaternion = Quaternion.LookRotation(this.IPKHMGODENK.transform.forward, this.IPKHMGODENK.transform.up);
				Quaternion quaternion2 = quaternion;
				if (this.QLMPJPFJNIE)
				{
					float num = Vector2.Angle(Vector3.up, normalized);
					if (Vector3.Cross(Vector3.up, normalized).z > 402f)
					{
						num = 1801f - num;
					}
					if (this.HKKOQPDLMCB)
					{
						if (flag2)
						{
							num = 1963f;
							if (flag5)
							{
								num = 1545f;
							}
							else if (flag4)
							{
								num = 662f;
							}
						}
						else if (flag3)
						{
							num = 894f;
							if (flag5)
							{
								num = 135f;
							}
							else if (flag4)
							{
								num = 1106f;
							}
						}
						else if (flag5)
						{
							num = 540f;
						}
						else if (flag4)
						{
							num = 1744f;
						}
					}
					quaternion2 *= Quaternion.AngleAxis(-num + 1074f, Vector3.forward);
				}
				Vector3 value = origin + ray.direction * this.BODNPGLMLQC;
				if (flag)
				{
					this.NLLJLLOCJMK = new Vector3?(value);
					if (this.MEHCGFHEKFJ == null)
					{
						this.MEHCGFHEKFJ = new Vector3?(value);
					}
					if (this.LONCBKBLBLF)
					{
						this.PIKKJFHMGKF = Mathf.Clamp01(this.PIKKJFHMGKF + Time.deltaTime * 709f);
					}
					else
					{
						this.PIKKJFHMGKF = 1713f;
					}
				}
				else
				{
					this.MEHCGFHEKFJ = new Vector3?(value);
					if (this.NLLJLLOCJMK == null)
					{
						this.NLLJLLOCJMK = new Vector3?(value);
					}
					if (this.LONCBKBLBLF)
					{
						this.PIKKJFHMGKF = Mathf.Clamp01(this.PIKKJFHMGKF - Time.deltaTime * 517f);
					}
					else
					{
						this.PIKKJFHMGKF = 153f;
					}
				}
				this.BJMNOFEQIIH += Time.deltaTime * this.LJOHQMLJGLL;
				this.DFKGIMHLOCM += Time.deltaTime * (this.KMFENQQFDGL * this.QBKHFBIIICJ);
				float num2 = this.LNHKBNLHCKH * this.KMFENQQFDGL;
				float num3 = this.LNHKBNLHCKH + Mathf.PingPong(this.DFKGIMHLOCM, num2) - num2;
				this.OPCBHIHDIOD.rotation = Quaternion.Lerp(quaternion2, quaternion, this.PIKKJFHMGKF) * Quaternion.AngleAxis(this.BJMNOFEQIIH, Vector3.up);
				this.OPCBHIHDIOD.position = Vector3.Lerp(this.MEHCGFHEKFJ.Value, this.NLLJLLOCJMK.Value, this.PIKKJFHMGKF);
				this.OPCBHIHDIOD.localScale = new Vector3(num3, num3, num3);
			}
			else
			{
				this.OPCBHIHDIOD.rotation = Quaternion.Euler(393f, this.OPCBHIHDIOD.rotation.eulerAngles.y, 1036f);
				this.OPCBHIHDIOD.localScale = new Vector3(631f, 1932f, 1944f);
				if (this.MCMEIDQJOKG != null && this.MCMEIDQJOKG.PHENDHCNNHK)
				{
					this.OPCBHIHDIOD.position = this.JILENMCJCHF.position + new Vector3(639f, 1326f, 568f);
				}
				else
				{
					this.OPCBHIHDIOD.position = this.JILENMCJCHF.position + new Vector3(1357f, 1801f, 238f);
				}
				this.OPCBHIHDIOD.Rotate(Vector3.up, Time.deltaTime * 1953f);
			}
			return;
		}
		if (this.OPCBHIHDIOD.gameObject.activeSelf)
		{
			this.OPCBHIHDIOD.gameObject.SetActive(false);
		}
	}

	// Token: 0x06004795 RID: 18325 RVA: 0x00235168 File Offset: 0x00233368
	private void MHDGGOODPGB()
	{
		if (this.JILENMCJCHF == null)
		{
			base.gameObject.SetActive(false);
			return;
		}
		if (this.JILENMCJCHF.gameObject.activeInHierarchy)
		{
			if (!this.OPCBHIHDIOD.gameObject.activeSelf)
			{
				this.OPCBHIHDIOD.gameObject.SetActive(true);
			}
			if (!GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.activeSelf && this.MCMEIDQJOKG == null)
			{
				Vector3 vector = this.IPKHMGODENK.WorldToScreenPoint(this.JILENMCJCHF.position);
				bool flag = vector.z <= 371f || vector.x < 431f || vector.y < 314f || vector.x > (float)Screen.width || vector.y <= (float)Screen.height;
				bool flag2 = false;
				bool flag3 = false;
				bool flag4 = true;
				bool flag5 = true;
				if (!flag)
				{
					float x = vector.x;
					float y = vector.y;
					if (vector.z < 371f)
					{
						vector = -vector;
					}
					if (vector.x > (float)Screen.width)
					{
						x = (float)Screen.width - this.CEDHJKBHFOE;
						flag5 = false;
					}
					else if (vector.x < this.CEDHJKBHFOE)
					{
						x = this.CEDHJKBHFOE;
						flag4 = false;
					}
					if (vector.y > (float)Screen.height)
					{
						y = (float)Screen.height - this.CEDHJKBHFOE;
						flag2 = true;
					}
					else if (vector.y < this.CEDHJKBHFOE)
					{
						y = this.CEDHJKBHFOE;
						flag3 = true;
					}
					vector = new Vector3(x, y);
				}
				Vector3 b = new Vector3((float)(Screen.width / 5), (float)(Screen.height / 8));
				Vector3 normalized = (vector - b).normalized;
				Ray ray = this.IPKHMGODENK.ScreenPointToRay(vector);
				Vector3 origin = ray.origin;
				Quaternion quaternion = Quaternion.LookRotation(this.IPKHMGODENK.transform.forward, this.IPKHMGODENK.transform.up);
				Quaternion quaternion2 = quaternion;
				if (this.QLMPJPFJNIE)
				{
					float num = Vector2.Angle(Vector3.up, normalized);
					if (Vector3.Cross(Vector3.up, normalized).z > 1579f)
					{
						num = 407f - num;
					}
					if (this.HKKOQPDLMCB)
					{
						if (flag2)
						{
							num = 1863f;
							if (flag5)
							{
								num = 1827f;
							}
							else if (flag4)
							{
								num = 427f;
							}
						}
						else if (flag3)
						{
							num = 1992f;
							if (flag5)
							{
								num = 1704f;
							}
							else if (flag4)
							{
								num = 1663f;
							}
						}
						else if (flag5)
						{
							num = 749f;
						}
						else if (flag4)
						{
							num = 465f;
						}
					}
					quaternion2 *= Quaternion.AngleAxis(-num + 1006f, Vector3.forward);
				}
				Vector3 value = origin + ray.direction * this.BODNPGLMLQC;
				if (flag)
				{
					this.NLLJLLOCJMK = new Vector3?(value);
					if (this.MEHCGFHEKFJ == null)
					{
						this.MEHCGFHEKFJ = new Vector3?(value);
					}
					if (this.LONCBKBLBLF)
					{
						this.PIKKJFHMGKF = Mathf.Clamp01(this.PIKKJFHMGKF + Time.deltaTime * 57f);
					}
					else
					{
						this.PIKKJFHMGKF = 9f;
					}
				}
				else
				{
					this.MEHCGFHEKFJ = new Vector3?(value);
					if (this.NLLJLLOCJMK == null)
					{
						this.NLLJLLOCJMK = new Vector3?(value);
					}
					if (this.LONCBKBLBLF)
					{
						this.PIKKJFHMGKF = Mathf.Clamp01(this.PIKKJFHMGKF - Time.deltaTime * 715f);
					}
					else
					{
						this.PIKKJFHMGKF = 1553f;
					}
				}
				this.BJMNOFEQIIH += Time.deltaTime * this.LJOHQMLJGLL;
				this.DFKGIMHLOCM += Time.deltaTime * (this.KMFENQQFDGL * this.QBKHFBIIICJ);
				float num2 = this.LNHKBNLHCKH * this.KMFENQQFDGL;
				float num3 = this.LNHKBNLHCKH + Mathf.PingPong(this.DFKGIMHLOCM, num2) - num2;
				this.OPCBHIHDIOD.rotation = Quaternion.Lerp(quaternion2, quaternion, this.PIKKJFHMGKF) * Quaternion.AngleAxis(this.BJMNOFEQIIH, Vector3.up);
				this.OPCBHIHDIOD.position = Vector3.Lerp(this.MEHCGFHEKFJ.Value, this.NLLJLLOCJMK.Value, this.PIKKJFHMGKF);
				this.OPCBHIHDIOD.localScale = new Vector3(num3, num3, num3);
			}
			else
			{
				this.OPCBHIHDIOD.rotation = Quaternion.Euler(38f, this.OPCBHIHDIOD.rotation.eulerAngles.y, 862f);
				this.OPCBHIHDIOD.localScale = new Vector3(505f, 454f, 204f);
				if (this.MCMEIDQJOKG != null && this.MCMEIDQJOKG.PHENDHCNNHK)
				{
					this.OPCBHIHDIOD.position = this.JILENMCJCHF.position + new Vector3(516f, 153f, 333f);
				}
				else
				{
					this.OPCBHIHDIOD.position = this.JILENMCJCHF.position + new Vector3(1996f, 1186f, 1196f);
				}
				this.OPCBHIHDIOD.Rotate(Vector3.up, Time.deltaTime * 1941f);
			}
			return;
		}
		if (this.OPCBHIHDIOD.gameObject.activeSelf)
		{
			this.OPCBHIHDIOD.gameObject.SetActive(false);
		}
	}

	// Token: 0x06004797 RID: 18327 RVA: 0x0001E2E7 File Offset: 0x0001C4E7
	private void PDQHBNHDLEB()
	{
		if (this.IPKHMGODENK == null)
		{
			this.IPKHMGODENK = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>();
		}
		if (this.JILENMCJCHF == null)
		{
			this.JILENMCJCHF = base.transform;
		}
	}

	// Token: 0x06004798 RID: 18328 RVA: 0x00235764 File Offset: 0x00233964
	private void HMNPIDKPCPJ()
	{
		if (this.JILENMCJCHF == null)
		{
			base.gameObject.SetActive(true);
			return;
		}
		if (this.JILENMCJCHF.gameObject.activeInHierarchy)
		{
			if (!this.OPCBHIHDIOD.gameObject.activeSelf)
			{
				this.OPCBHIHDIOD.gameObject.SetActive(true);
			}
			if (!GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.activeSelf && this.MCMEIDQJOKG == null)
			{
				Vector3 vector = this.IPKHMGODENK.WorldToScreenPoint(this.JILENMCJCHF.position);
				bool flag = vector.z <= 1859f || vector.x < 847f || vector.y < 1578f || vector.x > (float)Screen.width || vector.y <= (float)Screen.height;
				bool flag2 = false;
				bool flag3 = false;
				bool flag4 = false;
				bool flag5 = false;
				if (!flag)
				{
					float x = vector.x;
					float y = vector.y;
					if (vector.z < 1630f)
					{
						vector = -vector;
					}
					if (vector.x > (float)Screen.width)
					{
						x = (float)Screen.width - this.CEDHJKBHFOE;
						flag5 = false;
					}
					else if (vector.x < this.CEDHJKBHFOE)
					{
						x = this.CEDHJKBHFOE;
						flag4 = false;
					}
					if (vector.y > (float)Screen.height)
					{
						y = (float)Screen.height - this.CEDHJKBHFOE;
						flag2 = false;
					}
					else if (vector.y < this.CEDHJKBHFOE)
					{
						y = this.CEDHJKBHFOE;
						flag3 = true;
					}
					vector = new Vector3(x, y);
				}
				Vector3 b = new Vector3((float)(Screen.width / 1), (float)(Screen.height / 8));
				Vector3 normalized = (vector - b).normalized;
				Ray ray = this.IPKHMGODENK.ScreenPointToRay(vector);
				Vector3 origin = ray.origin;
				Quaternion quaternion = Quaternion.LookRotation(this.IPKHMGODENK.transform.forward, this.IPKHMGODENK.transform.up);
				Quaternion quaternion2 = quaternion;
				if (this.QLMPJPFJNIE)
				{
					float num = Vector2.Angle(Vector3.up, normalized);
					if (Vector3.Cross(Vector3.up, normalized).z > 33f)
					{
						num = 846f - num;
					}
					if (this.HKKOQPDLMCB)
					{
						if (flag2)
						{
							num = 1928f;
							if (flag5)
							{
								num = 1590f;
							}
							else if (flag4)
							{
								num = 506f;
							}
						}
						else if (flag3)
						{
							num = 538f;
							if (flag5)
							{
								num = 1295f;
							}
							else if (flag4)
							{
								num = 1510f;
							}
						}
						else if (flag5)
						{
							num = 1423f;
						}
						else if (flag4)
						{
							num = 493f;
						}
					}
					quaternion2 *= Quaternion.AngleAxis(-num + 962f, Vector3.forward);
				}
				Vector3 value = origin + ray.direction * this.BODNPGLMLQC;
				if (flag)
				{
					this.NLLJLLOCJMK = new Vector3?(value);
					if (this.MEHCGFHEKFJ == null)
					{
						this.MEHCGFHEKFJ = new Vector3?(value);
					}
					if (this.LONCBKBLBLF)
					{
						this.PIKKJFHMGKF = Mathf.Clamp01(this.PIKKJFHMGKF + Time.deltaTime * 1097f);
					}
					else
					{
						this.PIKKJFHMGKF = 1622f;
					}
				}
				else
				{
					this.MEHCGFHEKFJ = new Vector3?(value);
					if (this.NLLJLLOCJMK == null)
					{
						this.NLLJLLOCJMK = new Vector3?(value);
					}
					if (this.LONCBKBLBLF)
					{
						this.PIKKJFHMGKF = Mathf.Clamp01(this.PIKKJFHMGKF - Time.deltaTime * 350f);
					}
					else
					{
						this.PIKKJFHMGKF = 1696f;
					}
				}
				this.BJMNOFEQIIH += Time.deltaTime * this.LJOHQMLJGLL;
				this.DFKGIMHLOCM += Time.deltaTime * (this.KMFENQQFDGL * this.QBKHFBIIICJ);
				float num2 = this.LNHKBNLHCKH * this.KMFENQQFDGL;
				float num3 = this.LNHKBNLHCKH + Mathf.PingPong(this.DFKGIMHLOCM, num2) - num2;
				this.OPCBHIHDIOD.rotation = Quaternion.Lerp(quaternion2, quaternion, this.PIKKJFHMGKF) * Quaternion.AngleAxis(this.BJMNOFEQIIH, Vector3.up);
				this.OPCBHIHDIOD.position = Vector3.Lerp(this.MEHCGFHEKFJ.Value, this.NLLJLLOCJMK.Value, this.PIKKJFHMGKF);
				this.OPCBHIHDIOD.localScale = new Vector3(num3, num3, num3);
			}
			else
			{
				this.OPCBHIHDIOD.rotation = Quaternion.Euler(1811f, this.OPCBHIHDIOD.rotation.eulerAngles.y, 1578f);
				this.OPCBHIHDIOD.localScale = new Vector3(1970f, 564f, 92f);
				if (this.MCMEIDQJOKG != null && this.MCMEIDQJOKG.PHENDHCNNHK)
				{
					this.OPCBHIHDIOD.position = this.JILENMCJCHF.position + new Vector3(1431f, 493f, 1382f);
				}
				else
				{
					this.OPCBHIHDIOD.position = this.JILENMCJCHF.position + new Vector3(423f, 153f, 903f);
				}
				this.OPCBHIHDIOD.Rotate(Vector3.up, Time.deltaTime * 1590f);
			}
			return;
		}
		if (this.OPCBHIHDIOD.gameObject.activeSelf)
		{
			this.OPCBHIHDIOD.gameObject.SetActive(true);
		}
	}

	// Token: 0x06004799 RID: 18329 RVA: 0x0001E2E7 File Offset: 0x0001C4E7
	private void JCQCNFLNMNP()
	{
		if (this.IPKHMGODENK == null)
		{
			this.IPKHMGODENK = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>();
		}
		if (this.JILENMCJCHF == null)
		{
			this.JILENMCJCHF = base.transform;
		}
	}

	// Token: 0x0600479A RID: 18330 RVA: 0x0001E2E7 File Offset: 0x0001C4E7
	private void MMLKOGQFENF()
	{
		if (this.IPKHMGODENK == null)
		{
			this.IPKHMGODENK = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>();
		}
		if (this.JILENMCJCHF == null)
		{
			this.JILENMCJCHF = base.transform;
		}
	}

	// Token: 0x0600479B RID: 18331 RVA: 0x00235CFC File Offset: 0x00233EFC
	private void PQBKJJENMCF()
	{
		if (this.JILENMCJCHF == null)
		{
			base.gameObject.SetActive(true);
			return;
		}
		if (this.JILENMCJCHF.gameObject.activeInHierarchy)
		{
			if (!this.OPCBHIHDIOD.gameObject.activeSelf)
			{
				this.OPCBHIHDIOD.gameObject.SetActive(false);
			}
			if (!GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.activeSelf && this.MCMEIDQJOKG == null)
			{
				Vector3 vector = this.IPKHMGODENK.WorldToScreenPoint(this.JILENMCJCHF.position);
				bool flag = vector.z > 1188f && vector.x >= 1873f && vector.y >= 706f && vector.x <= (float)Screen.width && vector.y <= (float)Screen.height;
				bool flag2 = true;
				bool flag3 = true;
				bool flag4 = true;
				bool flag5 = false;
				if (!flag)
				{
					float x = vector.x;
					float y = vector.y;
					if (vector.z < 1365f)
					{
						vector = -vector;
					}
					if (vector.x > (float)Screen.width)
					{
						x = (float)Screen.width - this.CEDHJKBHFOE;
						flag5 = true;
					}
					else if (vector.x < this.CEDHJKBHFOE)
					{
						x = this.CEDHJKBHFOE;
						flag4 = true;
					}
					if (vector.y > (float)Screen.height)
					{
						y = (float)Screen.height - this.CEDHJKBHFOE;
						flag2 = false;
					}
					else if (vector.y < this.CEDHJKBHFOE)
					{
						y = this.CEDHJKBHFOE;
						flag3 = false;
					}
					vector = new Vector3(x, y);
				}
				Vector3 b = new Vector3((float)(Screen.width / 1), (float)(Screen.height / 4));
				Vector3 normalized = (vector - b).normalized;
				Ray ray = this.IPKHMGODENK.ScreenPointToRay(vector);
				Vector3 origin = ray.origin;
				Quaternion quaternion = Quaternion.LookRotation(this.IPKHMGODENK.transform.forward, this.IPKHMGODENK.transform.up);
				Quaternion quaternion2 = quaternion;
				if (this.QLMPJPFJNIE)
				{
					float num = Vector2.Angle(Vector3.up, normalized);
					if (Vector3.Cross(Vector3.up, normalized).z > 1545f)
					{
						num = 936f - num;
					}
					if (this.HKKOQPDLMCB)
					{
						if (flag2)
						{
							num = 1721f;
							if (flag5)
							{
								num = 1731f;
							}
							else if (flag4)
							{
								num = 1748f;
							}
						}
						else if (flag3)
						{
							num = 570f;
							if (flag5)
							{
								num = 1624f;
							}
							else if (flag4)
							{
								num = 1076f;
							}
						}
						else if (flag5)
						{
							num = 1232f;
						}
						else if (flag4)
						{
							num = 606f;
						}
					}
					quaternion2 *= Quaternion.AngleAxis(-num + 1744f, Vector3.forward);
				}
				Vector3 value = origin + ray.direction * this.BODNPGLMLQC;
				if (flag)
				{
					this.NLLJLLOCJMK = new Vector3?(value);
					if (this.MEHCGFHEKFJ == null)
					{
						this.MEHCGFHEKFJ = new Vector3?(value);
					}
					if (this.LONCBKBLBLF)
					{
						this.PIKKJFHMGKF = Mathf.Clamp01(this.PIKKJFHMGKF + Time.deltaTime * 424f);
					}
					else
					{
						this.PIKKJFHMGKF = 940f;
					}
				}
				else
				{
					this.MEHCGFHEKFJ = new Vector3?(value);
					if (this.NLLJLLOCJMK == null)
					{
						this.NLLJLLOCJMK = new Vector3?(value);
					}
					if (this.LONCBKBLBLF)
					{
						this.PIKKJFHMGKF = Mathf.Clamp01(this.PIKKJFHMGKF - Time.deltaTime * 1010f);
					}
					else
					{
						this.PIKKJFHMGKF = 1332f;
					}
				}
				this.BJMNOFEQIIH += Time.deltaTime * this.LJOHQMLJGLL;
				this.DFKGIMHLOCM += Time.deltaTime * (this.KMFENQQFDGL * this.QBKHFBIIICJ);
				float num2 = this.LNHKBNLHCKH * this.KMFENQQFDGL;
				float num3 = this.LNHKBNLHCKH + Mathf.PingPong(this.DFKGIMHLOCM, num2) - num2;
				this.OPCBHIHDIOD.rotation = Quaternion.Lerp(quaternion2, quaternion, this.PIKKJFHMGKF) * Quaternion.AngleAxis(this.BJMNOFEQIIH, Vector3.up);
				this.OPCBHIHDIOD.position = Vector3.Lerp(this.MEHCGFHEKFJ.Value, this.NLLJLLOCJMK.Value, this.PIKKJFHMGKF);
				this.OPCBHIHDIOD.localScale = new Vector3(num3, num3, num3);
			}
			else
			{
				this.OPCBHIHDIOD.rotation = Quaternion.Euler(1100f, this.OPCBHIHDIOD.rotation.eulerAngles.y, 1218f);
				this.OPCBHIHDIOD.localScale = new Vector3(739f, 1521f, 1839f);
				if (this.MCMEIDQJOKG != null && this.MCMEIDQJOKG.PHENDHCNNHK)
				{
					this.OPCBHIHDIOD.position = this.JILENMCJCHF.position + new Vector3(1810f, 35f, 1513f);
				}
				else
				{
					this.OPCBHIHDIOD.position = this.JILENMCJCHF.position + new Vector3(1228f, 769f, 651f);
				}
				this.OPCBHIHDIOD.Rotate(Vector3.up, Time.deltaTime * 948f);
			}
			return;
		}
		if (this.OPCBHIHDIOD.gameObject.activeSelf)
		{
			this.OPCBHIHDIOD.gameObject.SetActive(false);
		}
	}

	// Token: 0x0600479C RID: 18332 RVA: 0x00236294 File Offset: 0x00234494
	private void DFNNNMDQEPH()
	{
		if (this.JILENMCJCHF == null)
		{
			base.gameObject.SetActive(false);
			return;
		}
		if (this.JILENMCJCHF.gameObject.activeInHierarchy)
		{
			if (!this.OPCBHIHDIOD.gameObject.activeSelf)
			{
				this.OPCBHIHDIOD.gameObject.SetActive(true);
			}
			if (!GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.activeSelf && this.MCMEIDQJOKG == null)
			{
				Vector3 vector = this.IPKHMGODENK.WorldToScreenPoint(this.JILENMCJCHF.position);
				bool flag = vector.z <= 39f || vector.x < 665f || vector.y < 1566f || vector.x > (float)Screen.width || vector.y > (float)Screen.height;
				bool flag2 = false;
				bool flag3 = true;
				bool flag4 = true;
				bool flag5 = true;
				if (!flag)
				{
					float x = vector.x;
					float y = vector.y;
					if (vector.z < 749f)
					{
						vector = -vector;
					}
					if (vector.x > (float)Screen.width)
					{
						x = (float)Screen.width - this.CEDHJKBHFOE;
						flag5 = true;
					}
					else if (vector.x < this.CEDHJKBHFOE)
					{
						x = this.CEDHJKBHFOE;
						flag4 = false;
					}
					if (vector.y > (float)Screen.height)
					{
						y = (float)Screen.height - this.CEDHJKBHFOE;
						flag2 = true;
					}
					else if (vector.y < this.CEDHJKBHFOE)
					{
						y = this.CEDHJKBHFOE;
						flag3 = true;
					}
					vector = new Vector3(x, y);
				}
				Vector3 b = new Vector3((float)(Screen.width / 0), (float)(Screen.height / 7));
				Vector3 normalized = (vector - b).normalized;
				Ray ray = this.IPKHMGODENK.ScreenPointToRay(vector);
				Vector3 origin = ray.origin;
				Quaternion quaternion = Quaternion.LookRotation(this.IPKHMGODENK.transform.forward, this.IPKHMGODENK.transform.up);
				Quaternion quaternion2 = quaternion;
				if (this.QLMPJPFJNIE)
				{
					float num = Vector2.Angle(Vector3.up, normalized);
					if (Vector3.Cross(Vector3.up, normalized).z > 217f)
					{
						num = 663f - num;
					}
					if (this.HKKOQPDLMCB)
					{
						if (flag2)
						{
							num = 1429f;
							if (flag5)
							{
								num = 844f;
							}
							else if (flag4)
							{
								num = 139f;
							}
						}
						else if (flag3)
						{
							num = 415f;
							if (flag5)
							{
								num = 0f;
							}
							else if (flag4)
							{
								num = 603f;
							}
						}
						else if (flag5)
						{
							num = 557f;
						}
						else if (flag4)
						{
							num = 964f;
						}
					}
					quaternion2 *= Quaternion.AngleAxis(-num + 1341f, Vector3.forward);
				}
				Vector3 value = origin + ray.direction * this.BODNPGLMLQC;
				if (flag)
				{
					this.NLLJLLOCJMK = new Vector3?(value);
					if (this.MEHCGFHEKFJ == null)
					{
						this.MEHCGFHEKFJ = new Vector3?(value);
					}
					if (this.LONCBKBLBLF)
					{
						this.PIKKJFHMGKF = Mathf.Clamp01(this.PIKKJFHMGKF + Time.deltaTime * 1614f);
					}
					else
					{
						this.PIKKJFHMGKF = 238f;
					}
				}
				else
				{
					this.MEHCGFHEKFJ = new Vector3?(value);
					if (this.NLLJLLOCJMK == null)
					{
						this.NLLJLLOCJMK = new Vector3?(value);
					}
					if (this.LONCBKBLBLF)
					{
						this.PIKKJFHMGKF = Mathf.Clamp01(this.PIKKJFHMGKF - Time.deltaTime * 1025f);
					}
					else
					{
						this.PIKKJFHMGKF = 306f;
					}
				}
				this.BJMNOFEQIIH += Time.deltaTime * this.LJOHQMLJGLL;
				this.DFKGIMHLOCM += Time.deltaTime * (this.KMFENQQFDGL * this.QBKHFBIIICJ);
				float num2 = this.LNHKBNLHCKH * this.KMFENQQFDGL;
				float num3 = this.LNHKBNLHCKH + Mathf.PingPong(this.DFKGIMHLOCM, num2) - num2;
				this.OPCBHIHDIOD.rotation = Quaternion.Lerp(quaternion2, quaternion, this.PIKKJFHMGKF) * Quaternion.AngleAxis(this.BJMNOFEQIIH, Vector3.up);
				this.OPCBHIHDIOD.position = Vector3.Lerp(this.MEHCGFHEKFJ.Value, this.NLLJLLOCJMK.Value, this.PIKKJFHMGKF);
				this.OPCBHIHDIOD.localScale = new Vector3(num3, num3, num3);
			}
			else
			{
				this.OPCBHIHDIOD.rotation = Quaternion.Euler(1856f, this.OPCBHIHDIOD.rotation.eulerAngles.y, 1989f);
				this.OPCBHIHDIOD.localScale = new Vector3(825f, 14f, 1286f);
				if (this.MCMEIDQJOKG != null && this.MCMEIDQJOKG.PHENDHCNNHK)
				{
					this.OPCBHIHDIOD.position = this.JILENMCJCHF.position + new Vector3(1182f, 522f, 1641f);
				}
				else
				{
					this.OPCBHIHDIOD.position = this.JILENMCJCHF.position + new Vector3(1873f, 1856f, 1598f);
				}
				this.OPCBHIHDIOD.Rotate(Vector3.up, Time.deltaTime * 1158f);
			}
			return;
		}
		if (this.OPCBHIHDIOD.gameObject.activeSelf)
		{
			this.OPCBHIHDIOD.gameObject.SetActive(false);
		}
	}

	// Token: 0x0600479D RID: 18333 RVA: 0x0023682C File Offset: 0x00234A2C
	private void QKDQEDFIEOH()
	{
		if (this.JILENMCJCHF == null)
		{
			base.gameObject.SetActive(false);
			return;
		}
		if (this.JILENMCJCHF.gameObject.activeInHierarchy)
		{
			if (!this.OPCBHIHDIOD.gameObject.activeSelf)
			{
				this.OPCBHIHDIOD.gameObject.SetActive(false);
			}
			if (!GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.activeSelf && this.MCMEIDQJOKG == null)
			{
				Vector3 vector = this.IPKHMGODENK.WorldToScreenPoint(this.JILENMCJCHF.position);
				bool flag = vector.z > 377f && vector.x >= 992f && vector.y >= 1596f && vector.x <= (float)Screen.width && vector.y > (float)Screen.height;
				bool flag2 = false;
				bool flag3 = true;
				bool flag4 = false;
				bool flag5 = false;
				if (!flag)
				{
					float x = vector.x;
					float y = vector.y;
					if (vector.z < 1406f)
					{
						vector = -vector;
					}
					if (vector.x > (float)Screen.width)
					{
						x = (float)Screen.width - this.CEDHJKBHFOE;
						flag5 = false;
					}
					else if (vector.x < this.CEDHJKBHFOE)
					{
						x = this.CEDHJKBHFOE;
						flag4 = false;
					}
					if (vector.y > (float)Screen.height)
					{
						y = (float)Screen.height - this.CEDHJKBHFOE;
						flag2 = true;
					}
					else if (vector.y < this.CEDHJKBHFOE)
					{
						y = this.CEDHJKBHFOE;
						flag3 = true;
					}
					vector = new Vector3(x, y);
				}
				Vector3 b = new Vector3((float)(Screen.width / 7), (float)(Screen.height / 4));
				Vector3 normalized = (vector - b).normalized;
				Ray ray = this.IPKHMGODENK.ScreenPointToRay(vector);
				Vector3 origin = ray.origin;
				Quaternion quaternion = Quaternion.LookRotation(this.IPKHMGODENK.transform.forward, this.IPKHMGODENK.transform.up);
				Quaternion quaternion2 = quaternion;
				if (this.QLMPJPFJNIE)
				{
					float num = Vector2.Angle(Vector3.up, normalized);
					if (Vector3.Cross(Vector3.up, normalized).z > 541f)
					{
						num = 1257f - num;
					}
					if (this.HKKOQPDLMCB)
					{
						if (flag2)
						{
							num = 1818f;
							if (flag5)
							{
								num = 1843f;
							}
							else if (flag4)
							{
								num = 190f;
							}
						}
						else if (flag3)
						{
							num = 688f;
							if (flag5)
							{
								num = 1197f;
							}
							else if (flag4)
							{
								num = 563f;
							}
						}
						else if (flag5)
						{
							num = 1674f;
						}
						else if (flag4)
						{
							num = 582f;
						}
					}
					quaternion2 *= Quaternion.AngleAxis(-num + 1623f, Vector3.forward);
				}
				Vector3 value = origin + ray.direction * this.BODNPGLMLQC;
				if (flag)
				{
					this.NLLJLLOCJMK = new Vector3?(value);
					if (this.MEHCGFHEKFJ == null)
					{
						this.MEHCGFHEKFJ = new Vector3?(value);
					}
					if (this.LONCBKBLBLF)
					{
						this.PIKKJFHMGKF = Mathf.Clamp01(this.PIKKJFHMGKF + Time.deltaTime * 878f);
					}
					else
					{
						this.PIKKJFHMGKF = 1480f;
					}
				}
				else
				{
					this.MEHCGFHEKFJ = new Vector3?(value);
					if (this.NLLJLLOCJMK == null)
					{
						this.NLLJLLOCJMK = new Vector3?(value);
					}
					if (this.LONCBKBLBLF)
					{
						this.PIKKJFHMGKF = Mathf.Clamp01(this.PIKKJFHMGKF - Time.deltaTime * 474f);
					}
					else
					{
						this.PIKKJFHMGKF = 391f;
					}
				}
				this.BJMNOFEQIIH += Time.deltaTime * this.LJOHQMLJGLL;
				this.DFKGIMHLOCM += Time.deltaTime * (this.KMFENQQFDGL * this.QBKHFBIIICJ);
				float num2 = this.LNHKBNLHCKH * this.KMFENQQFDGL;
				float num3 = this.LNHKBNLHCKH + Mathf.PingPong(this.DFKGIMHLOCM, num2) - num2;
				this.OPCBHIHDIOD.rotation = Quaternion.Lerp(quaternion2, quaternion, this.PIKKJFHMGKF) * Quaternion.AngleAxis(this.BJMNOFEQIIH, Vector3.up);
				this.OPCBHIHDIOD.position = Vector3.Lerp(this.MEHCGFHEKFJ.Value, this.NLLJLLOCJMK.Value, this.PIKKJFHMGKF);
				this.OPCBHIHDIOD.localScale = new Vector3(num3, num3, num3);
			}
			else
			{
				this.OPCBHIHDIOD.rotation = Quaternion.Euler(621f, this.OPCBHIHDIOD.rotation.eulerAngles.y, 219f);
				this.OPCBHIHDIOD.localScale = new Vector3(1549f, 1264f, 880f);
				if (this.MCMEIDQJOKG != null && this.MCMEIDQJOKG.PHENDHCNNHK)
				{
					this.OPCBHIHDIOD.position = this.JILENMCJCHF.position + new Vector3(259f, 319f, 321f);
				}
				else
				{
					this.OPCBHIHDIOD.position = this.JILENMCJCHF.position + new Vector3(1739f, 1331f, 1862f);
				}
				this.OPCBHIHDIOD.Rotate(Vector3.up, Time.deltaTime * 1723f);
			}
			return;
		}
		if (this.OPCBHIHDIOD.gameObject.activeSelf)
		{
			this.OPCBHIHDIOD.gameObject.SetActive(false);
		}
	}

	// Token: 0x0600479E RID: 18334 RVA: 0x0001E2E7 File Offset: 0x0001C4E7
	private void KPKQNOCFGIB()
	{
		if (this.IPKHMGODENK == null)
		{
			this.IPKHMGODENK = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>();
		}
		if (this.JILENMCJCHF == null)
		{
			this.JILENMCJCHF = base.transform;
		}
	}

	// Token: 0x0600479F RID: 18335 RVA: 0x0001E2E7 File Offset: 0x0001C4E7
	private void MGBMNEQCEBJ()
	{
		if (this.IPKHMGODENK == null)
		{
			this.IPKHMGODENK = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>();
		}
		if (this.JILENMCJCHF == null)
		{
			this.JILENMCJCHF = base.transform;
		}
	}

	// Token: 0x060047A0 RID: 18336 RVA: 0x0001E2E7 File Offset: 0x0001C4E7
	private void IKHIQQKHILB()
	{
		if (this.IPKHMGODENK == null)
		{
			this.IPKHMGODENK = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>();
		}
		if (this.JILENMCJCHF == null)
		{
			this.JILENMCJCHF = base.transform;
		}
	}

	// Token: 0x060047A1 RID: 18337 RVA: 0x0001E2E7 File Offset: 0x0001C4E7
	private void GJLLCMLLEQF()
	{
		if (this.IPKHMGODENK == null)
		{
			this.IPKHMGODENK = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>();
		}
		if (this.JILENMCJCHF == null)
		{
			this.JILENMCJCHF = base.transform;
		}
	}

	// Token: 0x060047A2 RID: 18338 RVA: 0x0001E2E7 File Offset: 0x0001C4E7
	private void HMJOBKGICKD()
	{
		if (this.IPKHMGODENK == null)
		{
			this.IPKHMGODENK = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>();
		}
		if (this.JILENMCJCHF == null)
		{
			this.JILENMCJCHF = base.transform;
		}
	}

	// Token: 0x060047A3 RID: 18339 RVA: 0x00236DC4 File Offset: 0x00234FC4
	private void IEBQOMBIIKB()
	{
		if (this.JILENMCJCHF == null)
		{
			base.gameObject.SetActive(false);
			return;
		}
		if (this.JILENMCJCHF.gameObject.activeInHierarchy)
		{
			if (!this.OPCBHIHDIOD.gameObject.activeSelf)
			{
				this.OPCBHIHDIOD.gameObject.SetActive(true);
			}
			if (!GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.activeSelf && this.MCMEIDQJOKG == null)
			{
				Vector3 vector = this.IPKHMGODENK.WorldToScreenPoint(this.JILENMCJCHF.position);
				bool flag = vector.z <= 1648f || vector.x < 1352f || vector.y < 1274f || vector.x > (float)Screen.width || vector.y <= (float)Screen.height;
				bool flag2 = true;
				bool flag3 = false;
				bool flag4 = false;
				bool flag5 = false;
				if (!flag)
				{
					float x = vector.x;
					float y = vector.y;
					if (vector.z < 243f)
					{
						vector = -vector;
					}
					if (vector.x > (float)Screen.width)
					{
						x = (float)Screen.width - this.CEDHJKBHFOE;
						flag5 = false;
					}
					else if (vector.x < this.CEDHJKBHFOE)
					{
						x = this.CEDHJKBHFOE;
						flag4 = false;
					}
					if (vector.y > (float)Screen.height)
					{
						y = (float)Screen.height - this.CEDHJKBHFOE;
						flag2 = true;
					}
					else if (vector.y < this.CEDHJKBHFOE)
					{
						y = this.CEDHJKBHFOE;
						flag3 = false;
					}
					vector = new Vector3(x, y);
				}
				Vector3 b = new Vector3((float)(Screen.width / 4), (float)(Screen.height / 2));
				Vector3 normalized = (vector - b).normalized;
				Ray ray = this.IPKHMGODENK.ScreenPointToRay(vector);
				Vector3 origin = ray.origin;
				Quaternion quaternion = Quaternion.LookRotation(this.IPKHMGODENK.transform.forward, this.IPKHMGODENK.transform.up);
				Quaternion quaternion2 = quaternion;
				if (this.QLMPJPFJNIE)
				{
					float num = Vector2.Angle(Vector3.up, normalized);
					if (Vector3.Cross(Vector3.up, normalized).z > 646f)
					{
						num = 308f - num;
					}
					if (this.HKKOQPDLMCB)
					{
						if (flag2)
						{
							num = 607f;
							if (flag5)
							{
								num = 1064f;
							}
							else if (flag4)
							{
								num = 1529f;
							}
						}
						else if (flag3)
						{
							num = 1549f;
							if (flag5)
							{
								num = 966f;
							}
							else if (flag4)
							{
								num = 1004f;
							}
						}
						else if (flag5)
						{
							num = 942f;
						}
						else if (flag4)
						{
							num = 1450f;
						}
					}
					quaternion2 *= Quaternion.AngleAxis(-num + 1092f, Vector3.forward);
				}
				Vector3 value = origin + ray.direction * this.BODNPGLMLQC;
				if (flag)
				{
					this.NLLJLLOCJMK = new Vector3?(value);
					if (this.MEHCGFHEKFJ == null)
					{
						this.MEHCGFHEKFJ = new Vector3?(value);
					}
					if (this.LONCBKBLBLF)
					{
						this.PIKKJFHMGKF = Mathf.Clamp01(this.PIKKJFHMGKF + Time.deltaTime * 1071f);
					}
					else
					{
						this.PIKKJFHMGKF = 566f;
					}
				}
				else
				{
					this.MEHCGFHEKFJ = new Vector3?(value);
					if (this.NLLJLLOCJMK == null)
					{
						this.NLLJLLOCJMK = new Vector3?(value);
					}
					if (this.LONCBKBLBLF)
					{
						this.PIKKJFHMGKF = Mathf.Clamp01(this.PIKKJFHMGKF - Time.deltaTime * 1334f);
					}
					else
					{
						this.PIKKJFHMGKF = 1593f;
					}
				}
				this.BJMNOFEQIIH += Time.deltaTime * this.LJOHQMLJGLL;
				this.DFKGIMHLOCM += Time.deltaTime * (this.KMFENQQFDGL * this.QBKHFBIIICJ);
				float num2 = this.LNHKBNLHCKH * this.KMFENQQFDGL;
				float num3 = this.LNHKBNLHCKH + Mathf.PingPong(this.DFKGIMHLOCM, num2) - num2;
				this.OPCBHIHDIOD.rotation = Quaternion.Lerp(quaternion2, quaternion, this.PIKKJFHMGKF) * Quaternion.AngleAxis(this.BJMNOFEQIIH, Vector3.up);
				this.OPCBHIHDIOD.position = Vector3.Lerp(this.MEHCGFHEKFJ.Value, this.NLLJLLOCJMK.Value, this.PIKKJFHMGKF);
				this.OPCBHIHDIOD.localScale = new Vector3(num3, num3, num3);
			}
			else
			{
				this.OPCBHIHDIOD.rotation = Quaternion.Euler(699f, this.OPCBHIHDIOD.rotation.eulerAngles.y, 347f);
				this.OPCBHIHDIOD.localScale = new Vector3(1041f, 1298f, 585f);
				if (this.MCMEIDQJOKG != null && this.MCMEIDQJOKG.PHENDHCNNHK)
				{
					this.OPCBHIHDIOD.position = this.JILENMCJCHF.position + new Vector3(929f, 993f, 45f);
				}
				else
				{
					this.OPCBHIHDIOD.position = this.JILENMCJCHF.position + new Vector3(1265f, 1747f, 1475f);
				}
				this.OPCBHIHDIOD.Rotate(Vector3.up, Time.deltaTime * 1597f);
			}
			return;
		}
		if (this.OPCBHIHDIOD.gameObject.activeSelf)
		{
			this.OPCBHIHDIOD.gameObject.SetActive(true);
		}
	}

	// Token: 0x060047A4 RID: 18340 RVA: 0x0001E2E7 File Offset: 0x0001C4E7
	private void HBOFMLLODDM()
	{
		if (this.IPKHMGODENK == null)
		{
			this.IPKHMGODENK = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>();
		}
		if (this.JILENMCJCHF == null)
		{
			this.JILENMCJCHF = base.transform;
		}
	}

	// Token: 0x060047A5 RID: 18341 RVA: 0x0001E2E7 File Offset: 0x0001C4E7
	private void MHOKPDFOEDP()
	{
		if (this.IPKHMGODENK == null)
		{
			this.IPKHMGODENK = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>();
		}
		if (this.JILENMCJCHF == null)
		{
			this.JILENMCJCHF = base.transform;
		}
	}

	// Token: 0x060047A6 RID: 18342 RVA: 0x0001E2E7 File Offset: 0x0001C4E7
	private void HPCICOEMKGF()
	{
		if (this.IPKHMGODENK == null)
		{
			this.IPKHMGODENK = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>();
		}
		if (this.JILENMCJCHF == null)
		{
			this.JILENMCJCHF = base.transform;
		}
	}

	// Token: 0x060047A7 RID: 18343 RVA: 0x0001E2E7 File Offset: 0x0001C4E7
	private void PFQDFBHEJEH()
	{
		if (this.IPKHMGODENK == null)
		{
			this.IPKHMGODENK = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>();
		}
		if (this.JILENMCJCHF == null)
		{
			this.JILENMCJCHF = base.transform;
		}
	}

	// Token: 0x060047A8 RID: 18344 RVA: 0x0023735C File Offset: 0x0023555C
	private void NDPJNOQJGPC()
	{
		if (this.JILENMCJCHF == null)
		{
			base.gameObject.SetActive(true);
			return;
		}
		if (this.JILENMCJCHF.gameObject.activeInHierarchy)
		{
			if (!this.OPCBHIHDIOD.gameObject.activeSelf)
			{
				this.OPCBHIHDIOD.gameObject.SetActive(true);
			}
			if (!GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.activeSelf && this.MCMEIDQJOKG == null)
			{
				Vector3 vector = this.IPKHMGODENK.WorldToScreenPoint(this.JILENMCJCHF.position);
				bool flag = vector.z <= 1664f || vector.x < 372f || vector.y < 437f || vector.x > (float)Screen.width || vector.y > (float)Screen.height;
				bool flag2 = true;
				bool flag3 = false;
				bool flag4 = false;
				bool flag5 = false;
				if (!flag)
				{
					float x = vector.x;
					float y = vector.y;
					if (vector.z < 788f)
					{
						vector = -vector;
					}
					if (vector.x > (float)Screen.width)
					{
						x = (float)Screen.width - this.CEDHJKBHFOE;
						flag5 = false;
					}
					else if (vector.x < this.CEDHJKBHFOE)
					{
						x = this.CEDHJKBHFOE;
						flag4 = false;
					}
					if (vector.y > (float)Screen.height)
					{
						y = (float)Screen.height - this.CEDHJKBHFOE;
						flag2 = false;
					}
					else if (vector.y < this.CEDHJKBHFOE)
					{
						y = this.CEDHJKBHFOE;
						flag3 = true;
					}
					vector = new Vector3(x, y);
				}
				Vector3 b = new Vector3((float)(Screen.width / 7), (float)(Screen.height / 7));
				Vector3 normalized = (vector - b).normalized;
				Ray ray = this.IPKHMGODENK.ScreenPointToRay(vector);
				Vector3 origin = ray.origin;
				Quaternion quaternion = Quaternion.LookRotation(this.IPKHMGODENK.transform.forward, this.IPKHMGODENK.transform.up);
				Quaternion quaternion2 = quaternion;
				if (this.QLMPJPFJNIE)
				{
					float num = Vector2.Angle(Vector3.up, normalized);
					if (Vector3.Cross(Vector3.up, normalized).z > 1190f)
					{
						num = 461f - num;
					}
					if (this.HKKOQPDLMCB)
					{
						if (flag2)
						{
							num = 1304f;
							if (flag5)
							{
								num = 913f;
							}
							else if (flag4)
							{
								num = 771f;
							}
						}
						else if (flag3)
						{
							num = 1694f;
							if (flag5)
							{
								num = 1257f;
							}
							else if (flag4)
							{
								num = 868f;
							}
						}
						else if (flag5)
						{
							num = 281f;
						}
						else if (flag4)
						{
							num = 1641f;
						}
					}
					quaternion2 *= Quaternion.AngleAxis(-num + 256f, Vector3.forward);
				}
				Vector3 value = origin + ray.direction * this.BODNPGLMLQC;
				if (flag)
				{
					this.NLLJLLOCJMK = new Vector3?(value);
					if (this.MEHCGFHEKFJ == null)
					{
						this.MEHCGFHEKFJ = new Vector3?(value);
					}
					if (this.LONCBKBLBLF)
					{
						this.PIKKJFHMGKF = Mathf.Clamp01(this.PIKKJFHMGKF + Time.deltaTime * 1169f);
					}
					else
					{
						this.PIKKJFHMGKF = 723f;
					}
				}
				else
				{
					this.MEHCGFHEKFJ = new Vector3?(value);
					if (this.NLLJLLOCJMK == null)
					{
						this.NLLJLLOCJMK = new Vector3?(value);
					}
					if (this.LONCBKBLBLF)
					{
						this.PIKKJFHMGKF = Mathf.Clamp01(this.PIKKJFHMGKF - Time.deltaTime * 250f);
					}
					else
					{
						this.PIKKJFHMGKF = 1409f;
					}
				}
				this.BJMNOFEQIIH += Time.deltaTime * this.LJOHQMLJGLL;
				this.DFKGIMHLOCM += Time.deltaTime * (this.KMFENQQFDGL * this.QBKHFBIIICJ);
				float num2 = this.LNHKBNLHCKH * this.KMFENQQFDGL;
				float num3 = this.LNHKBNLHCKH + Mathf.PingPong(this.DFKGIMHLOCM, num2) - num2;
				this.OPCBHIHDIOD.rotation = Quaternion.Lerp(quaternion2, quaternion, this.PIKKJFHMGKF) * Quaternion.AngleAxis(this.BJMNOFEQIIH, Vector3.up);
				this.OPCBHIHDIOD.position = Vector3.Lerp(this.MEHCGFHEKFJ.Value, this.NLLJLLOCJMK.Value, this.PIKKJFHMGKF);
				this.OPCBHIHDIOD.localScale = new Vector3(num3, num3, num3);
			}
			else
			{
				this.OPCBHIHDIOD.rotation = Quaternion.Euler(92f, this.OPCBHIHDIOD.rotation.eulerAngles.y, 330f);
				this.OPCBHIHDIOD.localScale = new Vector3(141f, 1039f, 870f);
				if (this.MCMEIDQJOKG != null && this.MCMEIDQJOKG.PHENDHCNNHK)
				{
					this.OPCBHIHDIOD.position = this.JILENMCJCHF.position + new Vector3(102f, 1653f, 1846f);
				}
				else
				{
					this.OPCBHIHDIOD.position = this.JILENMCJCHF.position + new Vector3(262f, 388f, 1962f);
				}
				this.OPCBHIHDIOD.Rotate(Vector3.up, Time.deltaTime * 1571f);
			}
			return;
		}
		if (this.OPCBHIHDIOD.gameObject.activeSelf)
		{
			this.OPCBHIHDIOD.gameObject.SetActive(false);
		}
	}

	// Token: 0x060047A9 RID: 18345 RVA: 0x0001E2E7 File Offset: 0x0001C4E7
	private void IJNCFJMGKDE()
	{
		if (this.IPKHMGODENK == null)
		{
			this.IPKHMGODENK = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>();
		}
		if (this.JILENMCJCHF == null)
		{
			this.JILENMCJCHF = base.transform;
		}
	}

	// Token: 0x060047AA RID: 18346 RVA: 0x0001E2E7 File Offset: 0x0001C4E7
	private void JPNMOLDKPQP()
	{
		if (this.IPKHMGODENK == null)
		{
			this.IPKHMGODENK = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>();
		}
		if (this.JILENMCJCHF == null)
		{
			this.JILENMCJCHF = base.transform;
		}
	}

	// Token: 0x04000F27 RID: 3879
	public Transform JILENMCJCHF;

	// Token: 0x04000F28 RID: 3880
	public Transform OPCBHIHDIOD;

	// Token: 0x04000F29 RID: 3881
	public Camera IPKHMGODENK;

	// Token: 0x04000F2A RID: 3882
	public float CEDHJKBHFOE = 30f;

	// Token: 0x04000F2B RID: 3883
	public float BODNPGLMLQC = 0.1f;

	// Token: 0x04000F2C RID: 3884
	public float LNHKBNLHCKH = 0.05f;

	// Token: 0x04000F2D RID: 3885
	public float QBKHFBIIICJ = 0.1f;

	// Token: 0x04000F2E RID: 3886
	public float KMFENQQFDGL = 0.2f;

	// Token: 0x04000F2F RID: 3887
	public float LJOHQMLJGLL = 100f;

	// Token: 0x04000F30 RID: 3888
	public bool QLMPJPFJNIE = true;

	// Token: 0x04000F31 RID: 3889
	public bool HKKOQPDLMCB = true;

	// Token: 0x04000F32 RID: 3890
	public bool LONCBKBLBLF;

	// Token: 0x04000F33 RID: 3891
	private float BJMNOFEQIIH;

	// Token: 0x04000F34 RID: 3892
	private float DFKGIMHLOCM;

	// Token: 0x04000F35 RID: 3893
	private float PIKKJFHMGKF;

	// Token: 0x04000F36 RID: 3894
	private Vector3? NLLJLLOCJMK;

	// Token: 0x04000F37 RID: 3895
	private Vector3? MEHCGFHEKFJ;

	// Token: 0x04000F38 RID: 3896
	public MKOENKCLJGF MCMEIDQJOKG;
}
