﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RxFFmpegCore.Models;

namespace FxFFmpeg.Web.Controllers
{
	[Route("api/[controller]")]
	public class InfoController : Controller
	{
		[HttpGet]
		[Route("[action]")]
		public async Task<IActionResult> Versions()
		{
			FFmpegTask ffmpeg = new FFmpegTask();
			ffmpeg.Start();

			FFmpegVersion version = await ffmpeg.GetOutputAsync() as FFmpegVersion;

			return Ok(version);
		}
	}
}