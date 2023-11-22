create database pacificprint;

create schema shop;

CREATE EXTENSION IF NOT EXISTS "uuid-ossp";

create table shop.clients (
      id                uuid default uuid_generate_v4(),
      first_name        text        not null,
      optional_name     text,
      middle_name       text,
      last_name         text,
      phone_number      text        not null,
      company_name      text,
      street            text        not null,
      house_number      numeric     not null,
      neighborhood      text        not null,
      postal_code       numeric     not null,
      city              text        not null,
      state             text        not null,
      country           text        not null,
      created_at        timestamp   not null default now(),
      updated_at        timestamp   not null default now(),
      primary key (id)
);

create table shop.users
(
    id            uuid    default uuid_generate_v4() not null
        constraint users_pk
            primary key,
    first_name    text                               not null,
    optional_name text,
    middle_name   text,
    last_name     text,
    email         text                               not null,
    username      text                               not null,
    password      text                               not null,
    role          integer default 0                  not null,
    created_at    timestamp default now()             not null,
    updated_at    timestamp default now()             not null
);

create table shop.products
(
    id            uuid    default uuid_generate_v4() not null
        constraint products_pk
            primary key,
    name          text                                not null,
    description   text,
    category      integer default 0                  not null,
    unit_value    numeric default 0                  not null,
    created_at    timestamp default now()            not null,
    updated_at    timestamp default now()            not null
);

create table shop.orders
(
    id            uuid    default uuid_generate_v4() not null
        constraint orders_pk
            primary key,
    client_id     uuid                                not null
        constraint orders_clients_id_fk
            references shop.clients
            on update cascade on delete cascade,
    user_id       uuid                                not null
        constraint orders_users_id_fk
            references shop.users
            on update cascade on delete cascade,
    status        integer default 0                  not null,
    payment       integer default 0                  not null,
    payment_value numeric default 0                  not null,
    total_value   numeric default 0                  not null,
    created_at    timestamp default now()            not null,
    updated_at    timestamp default now()            not null
);

create table shop.order_detail (
    id            uuid    default uuid_generate_v4() not null
        constraint order_detail_pk
            primary key,
    order_id      uuid                                not null
        constraint order_detail_orders_id_fk
            references shop.orders
            on update cascade on delete cascade,
    product_id    uuid                                not null
        constraint order_detail_products_id_fk
            references shop.products
            on update cascade on delete cascade,
    quantity      integer default 0                  not null,
    unit_value    numeric default 0                  not null,
    total_value   numeric default 0                  not null,
    created_at    timestamp default now()            not null,
    updated_at    timestamp default now()            not null
);