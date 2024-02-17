package com.example.retrofitandroid.Clases;

public class CreateUserResponse {
        @SerializedName("name")
        public String name;
        @SerializedName("job")
        public String job;
        @SerializedName("id")
        public String id;
        @SerializedName("createdAt")
        public String createdAt;
}
