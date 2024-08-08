CREATE DATABASE BLOG_DB;

CREATE EXTENSION IF NOT EXISTS "uuid-ossp";

CREATE TABLE post
(
    id      UUID UNIQUE DEFAULT uuid_generate_v4()  NOT NULL ,
    title   VARCHAR(255) NOT NULL,
    content TEXT         NOT NULL
);

CREATE TABLE comment
(
    id      UUID UNIQUE DEFAULT uuid_generate_v4()  NOT NULL ,
    post_id UUID NOT NULL,
    content TEXT NOT NULL
);

CREATE INDEX post_id_index ON post (id);
CREATE INDEX comment_id_index ON comment (post_id);
CREATE INDEX comment_id_index ON comment (id);
