
-- Структура таблицы `car`
--

CREATE TABLE `car` (
  `id_car` int NOT NULL,
  `car_model` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `id_client` int DEFAULT NULL,
  `id_perfomancecar` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `client`
--

CREATE TABLE `client` (
  `id` int NOT NULL,
  `name` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `surname` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `patronymic` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `phone_number` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `place_of_work` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `passport_id` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `employee`
--

CREATE TABLE `employee` (
  `id` int NOT NULL,
  `name` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `surname` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `patronymic` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `rank` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `job_title` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `login`
--

CREATE TABLE `login` (
  `id` int NOT NULL,
  `login` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `pass` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `id_client` int DEFAULT NULL,
  `id_employee` int DEFAULT NULL,
  `is_employee` tinyint(1) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `ordercar`
--

CREATE TABLE `ordercar` (
  `id` int NOT NULL,
  `id_car` int NOT NULL,
  `id_client` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `passport`
--

CREATE TABLE `passport` (
  `id` int NOT NULL,
  `passport_number` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `passport_series` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `date_issue` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `authority` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `perfomancecar`
--

CREATE TABLE `perfomancecar` (
  `id_perfcar` int NOT NULL,
  `body_color` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `engine_capacity` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `year_issue` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `type_car` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `vin_number` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `report`
--

CREATE TABLE `report` (
  `id` int NOT NULL,
  `result` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `end_time` date DEFAULT NULL,
  `car_appraisal` int NOT NULL,
  `malfunctions` varchar(1000) COLLATE utf8mb4_unicode_ci NOT NULL,
  `fault_fixed` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `id_employee` int DEFAULT NULL,
  `id_client` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `request`
--

CREATE TABLE `request` (
  `id_req` int NOT NULL,
  `id_client` int DEFAULT NULL,
  `id_car` int DEFAULT NULL,
  `sent_tech_inspect` tinyint NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `techinspection`
--

CREATE TABLE `techinspection` (
  `id_techinsp` int NOT NULL,
  `time_spending` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `cost` double DEFAULT NULL,
  `id_car` int NOT NULL,
  `id_employee` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `car`
--
ALTER TABLE `car`
  ADD PRIMARY KEY (`id_car`),
  ADD KEY `id_client` (`id_client`),
  ADD KEY `id_perfomancecar` (`id_perfomancecar`);

--
-- Индексы таблицы `client`
--
ALTER TABLE `client`
  ADD PRIMARY KEY (`id`),
  ADD KEY `passport_id` (`passport_id`);

--
-- Индексы таблицы `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `login` (`login`),
  ADD KEY `id_client` (`id_client`),
  ADD KEY `id_employee` (`id_employee`);

--
-- Индексы таблицы `ordercar`
--
ALTER TABLE `ordercar`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_car` (`id_car`),
  ADD KEY `id_client` (`id_client`);

--
-- Индексы таблицы `passport`
--
ALTER TABLE `passport`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `perfomancecar`
--
ALTER TABLE `perfomancecar`
  ADD PRIMARY KEY (`id_perfcar`);

--
-- Индексы таблицы `report`
--
ALTER TABLE `report`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_employee` (`id_employee`),
  ADD KEY `id_client` (`id_client`) USING BTREE;

--
-- Индексы таблицы `request`
--
ALTER TABLE `request`
  ADD PRIMARY KEY (`id_req`),
  ADD KEY `id_client` (`id_client`),
  ADD KEY `id_car` (`id_car`);

--
-- Индексы таблицы `techinspection`
--
ALTER TABLE `techinspection`
  ADD PRIMARY KEY (`id_techinsp`),
  ADD KEY `id_car` (`id_car`),
  ADD KEY `id_employee` (`id_employee`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `car`
--
ALTER TABLE `car`
  MODIFY `id_car` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT для таблицы `client`
--
ALTER TABLE `client`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT для таблицы `employee`
--
ALTER TABLE `employee`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT для таблицы `login`
--
ALTER TABLE `login`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT для таблицы `ordercar`
--
ALTER TABLE `ordercar`
  MODIFY `id` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `passport`
--
ALTER TABLE `passport`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- AUTO_INCREMENT для таблицы `perfomancecar`
--
ALTER TABLE `perfomancecar`
  MODIFY `id_perfcar` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- AUTO_INCREMENT для таблицы `report`
--
ALTER TABLE `report`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT для таблицы `request`
--
ALTER TABLE `request`
  MODIFY `id_req` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT для таблицы `techinspection`
--
ALTER TABLE `techinspection`
  MODIFY `id_techinsp` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `car`
--
ALTER TABLE `car`
  ADD CONSTRAINT `car_ibfk_1` FOREIGN KEY (`id_client`) REFERENCES `client` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `car_ibfk_2` FOREIGN KEY (`id_perfomancecar`) REFERENCES `perfomancecar` (`id_perfcar`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `client`
--
ALTER TABLE `client`
  ADD CONSTRAINT `client_ibfk_1` FOREIGN KEY (`passport_id`) REFERENCES `passport` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `login`
--
ALTER TABLE `login`
  ADD CONSTRAINT `login_ibfk_1` FOREIGN KEY (`id_client`) REFERENCES `client` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `login_ibfk_2` FOREIGN KEY (`id_employee`) REFERENCES `employee` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `ordercar`
--
ALTER TABLE `ordercar`
  ADD CONSTRAINT `ordercar_ibfk_1` FOREIGN KEY (`id_car`) REFERENCES `car` (`id_car`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ordercar_ibfk_2` FOREIGN KEY (`id_client`) REFERENCES `client` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `report`
--
ALTER TABLE `report`
  ADD CONSTRAINT `report_ibfk_1` FOREIGN KEY (`id_client`) REFERENCES `techinspection` (`id_techinsp`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `report_ibfk_2` FOREIGN KEY (`id_employee`) REFERENCES `employee` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `request`
--
ALTER TABLE `request`
  ADD CONSTRAINT `request_ibfk_1` FOREIGN KEY (`id_client`) REFERENCES `client` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `request_ibfk_2` FOREIGN KEY (`id_car`) REFERENCES `car` (`id_car`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `techinspection`
--
ALTER TABLE `techinspection`
  ADD CONSTRAINT `techinspection_ibfk_1` FOREIGN KEY (`id_car`) REFERENCES `car` (`id_car`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `techinspection_ibfk_2` FOREIGN KEY (`id_employee`) REFERENCES `employee` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

