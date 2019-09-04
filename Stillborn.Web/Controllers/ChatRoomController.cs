﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stillborn.Domain.Entities;
using Stillborn.Services.Interfaces;
using Stillborn.Services.Repositories;

namespace Stillborn.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatRoomController : ControllerBase
    {
        private readonly IChatRoomService _chatRoomService;
        private readonly RepositoryService _repository;
        public ChatRoomController(IChatRoomService chatRoomService, RepositoryService repository)
        {
            _chatRoomService = chatRoomService;
            _repository = repository;
        }
        [HttpGet("{id}")]
        public IActionResult GetChatRoomById(int id)
        {
            return Ok(_repository.GetRepository<ChatRoom>().GetEntity(id));
        }
        [HttpGet("{id}")]
        public IActionResult GetUserChatRooms(string userId)
        {
            return Ok(_chatRoomService.GetUserChatRooms(userId));
        }
        //Add
        [HttpPost]
        public IActionResult Post(ChatRoom chatRoom)//id Юзера?
        {
            if (ModelState.IsValid)
            {
                //_chatRoomService.
                return Ok();
            }
            return BadRequest();
        }

        //Обновить
        [HttpPut("{id}")]
        public IActionResult Put(ChatRoom chatRoom)
        {
            if (ModelState.IsValid)
            {
                _repository.GetRepository<ChatRoom>().UpdateEntity(chatRoom);
                return Ok();
            }
            return BadRequest();
        }
    }
}